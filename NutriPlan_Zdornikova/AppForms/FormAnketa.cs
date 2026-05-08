using Guna.UI2.WinForms;
using NutriPlan_Zdornikova.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static NutriPlan_Zdornikova.Program;
using System.Data.Entity;

namespace NutriPlan_Zdornikova.AppForms
{
    public partial class FormAnketa : Form
    {
        int SelectedGenderId = 0;
        private int _currentUserId;
        public FormAnketa(int UserId)
        {
            InitializeComponent();
            //labelUser.Text = $"Приветствую, {Session.CurrentUser.FullName}! Пожалуйста, заполните анкету для получения персонального плана питания.";
            labelUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            labelUser.AutoSize = false;
            labelUser.Size = new Size(400, 50);
            Panel1IMT.ShadowDepth = 5;
            Panel1IMT.Padding = new Padding(10);
            _currentUserId = UserId;

        }

       



        private void FormAnketa_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nutriPlan_ZdornikovaDataSet.ActivityLevel". При необходимости она может быть перемещена или удалена.
            this.activityLevelTableAdapter.Fill(this.nutriPlan_ZdornikovaDataSet.ActivityLevel);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nutriPlan_ZdornikovaDataSet.Goal". При необходимости она может быть перемещена или удалена.
            this.goalTableAdapter.Fill(this.nutriPlan_ZdornikovaDataSet.Goal);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nutriPlan_ZdornikovaDataSet.UserProfiles". При необходимости она может быть перемещена или удалена.
            //this.userProfilesTableAdapter.Fill(this.nutriPlan_ZdornikovaDataSet.UserProfiles);


        }
        private void CalculateAndDisplayCalories()
        {
            // 1. Получаем данные из полей формы
            int weight = TrackBarWeight.Value; // кг
            int height = TrackBarHeigh.Value;  // см
            int age = DateTime.Now.Year - DateTimePickerOfBirdthay.Value.Year; // Примерный возраст

            // Корректировка возраста, если день рождения еще не наступил в этом году
            if (DateTime.Now.DayOfYear < DateTimePickerOfBirdthay.Value.DayOfYear)
                age--;

            int genderId = SelectedGenderId; // 1 - Мужской, 2 - Женский (проверьте ваши ID)

            // Получаем ID активности и цели из ComboBox
            // Важно: убедитесь, что SelectedValue не null
            if (ActivityLevelComboBox2.SelectedValue == null || GoalComboBox1.SelectedValue == null)
                return;

            int activityId = (int)ActivityLevelComboBox2.SelectedValue;
            int goalId = (int)GoalComboBox1.SelectedValue;

            // 2. Расчет Базового Обмена Веществ (BMR) по формуле Миффлина-Сан Жеора
            double bmr;
            if (genderId == 1) // Мужчина
            {
                bmr = (10 * weight) + (6.25 * height) - (5 * age) + 5;
            }
            else // Женщина
            {
                bmr = (10 * weight) + (6.25 * height) - (5 * age) - 161;
            }

            // 3. Коэффициент физической активности
            double activityMultiplier = 1.2; // По умолчанию сидячий образ жизни

            switch (activityId)
            {
                case 1: activityMultiplier = 1.2; break; // Сидячий
                case 2: activityMultiplier = 1.375; break; // Легкая активность (1-3 раза в неделю)
                case 3: activityMultiplier = 1.55; break; // Средняя (3-5 раз)
                case 4: activityMultiplier = 1.725; break; // Высокая (6-7 раз)
                case 5: activityMultiplier = 1.9; break; // Экстремальная
            }

            // 4. Расчет нормы поддержания веса (TDEE)
            double maintenanceCalories = bmr * activityMultiplier;

            // 5. Корректировка под цель
            double finalCalories = maintenanceCalories;
            string goalText = "";

            switch (goalId)
            {
                case 1: // Похудение
                    finalCalories = maintenanceCalories * 0.85; // Дефицит 15%
                    goalText = "для похудения";
                    break;
                case 2: // Поддержание
                    finalCalories = maintenanceCalories;
                    goalText = "для поддержания веса";
                    break;
                case 3: // Набор массы
                    finalCalories = maintenanceCalories * 1.15; // Профицит 15%
                    goalText = "для набора массы";
                    break;
            }

            // Округляем до целого
            int resultCalories = (int)Math.Round(finalCalories);

            // 6. Вывод результата на финальный экран
            // Предположим, у вас есть Label для вывода рекомендации, например labelRecommendedCalories
            labelSovet.Text = $"{resultCalories} ккал/день";

            // Можно также вывести пояснение
            labelAdvace.Text = $"Ваша суточная норма {goalText}: {resultCalories} ккал.\n" +
                               $"Базовый обмен (BMR): {(int)bmr} ккал.\n" +
                               $"С учетом активности: {(int)maintenanceCalories} ккал.";

            if(resultCalories < CaloriesTrackBar1.Minimum)
                 resultCalories = CaloriesTrackBar1.Minimum;

            if (resultCalories > CaloriesTrackBar1.Maximum)
                resultCalories = CaloriesTrackBar1.Maximum;

            // 7. Автоматически устанавливаем это значение в TrackBar калорий, 
            // чтобы пользователь мог его сохранить в анкету
            CaloriesTrackBar1.Value = resultCalories;
            labelCount.Text = $"{resultCalories} ккал/день"; // Обновляем подпись под трекбаром
        }


        private void buttonMale_Click(object sender, EventArgs e)
        {
            var btn = (Guna.UI2.WinForms.Guna2Button)sender;

            if (btn.Tag != null)
            {
                SelectedGenderId = int.Parse(btn.Tag.ToString());
            }
        }

      

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            panel1Step.Visible = false;
            panel2Step.Visible = true;

            ProgressBar1.Value = 33;
        }

 

        private void ButtonNext2_Click(object sender, EventArgs e)
        {
            panel2Step.Visible = false;
            panel3Step.Visible = true;
            ProgressBar1.Value = 66;
        }

        private void ButtonLast_Click(object sender, EventArgs e)
        {
            panel2Step.Visible = false;
            panel1Step.Visible = true;
            ProgressBar1.Value = 0;
        }

        private void TrackBarHeigh_ValueChanged(object sender, EventArgs e)
        {
            labelHeight.Text = $"{TrackBarHeigh.Value} см";
        }

        private void TrackBarWeight_ValueChanged(object sender, EventArgs e)
        {
            labelWeight.Text = $"{TrackBarWeight.Value} кг";
        }

        private void ButtonLast2_Click(object sender, EventArgs e)
        {
            panel3Step.Visible = false;
            panel2Step.Visible = true;
            ProgressBar1.Value = 33;
        }

        private void CaloriesTrackBar1_ValueChanged(object sender, EventArgs e)
        {
            int val =   CaloriesTrackBar1.Value;
            string tipTitle = "";
            string tipText = "";
            labelCount.Text = $"{val} ккал/день";

            if (val < 1500)
            {
                tipTitle = "НИЗКИЙ КАЛОРАЖ";
                tipText = "Обычно для быстрого похудения.\nТребует контроля врача!";
            }
            else if (val >= 1500 && val <= 2200)
            {
                tipTitle = "ПОДДЕРЖАНИЕ";
                tipText = "Средняя норма для большинства людей\nс умеренной активностью.";
            }
            else if (val > 2200 && val <= 3000)
            {
                tipTitle = "ПРОФИЦИТ";
                tipText = "Подходит для тренировок\nи постепенного набора массы.";
            }
            else
            {
                tipTitle = "ВЫСОКАЯ ЭНЕРГИЯ";
                tipText = "Для атлетов или тяжелого\nфизического труда.";
            }

            // Собираем чистый текст без тегов
            string fullMessage = $"{tipTitle}\n{tipText}";

            // Выводим подсказку
            CaloriesToolTip.SetToolTip(CaloriesTrackBar1, fullMessage);

            // Обновляем число под ползунком
            labelcalories.Text = $"{val} ккал";
        }
        

        private void CalulateResults()
        {
            int goalId = Convert.ToInt32(GoalComboBox1.SelectedValue);
            int calories = (int)CaloriesTrackBar1.Value;
            string mainAdvice = "";
            int activityId = Convert.ToInt32(ActivityLevelComboBox2.SelectedValue);
            double weight = (double)TrackBarWeight.Value;
            double heightMeters = (double)TrackBarHeigh.Value / 100.0; // переводим см в метры для ИМТ
            int calories1 = (int)CaloriesTrackBar1.Value;

            // 2. Расчет ИМТ
            double imt = weight / (heightMeters * heightMeters);
            labelIMTStatus.Text = Math.Round(imt, 1).ToString();
            if (imt < 18.5)
            {
                labelStatus.Text = "Дефицит веса";
                labelStatus.ForeColor = Color.Blue;
            }
            else if (imt < 25)
            {
                labelStatus.Text = "Норма";
                labelStatus.ForeColor = Color.Green;
            }
            else
            {
                labelStatus.Text = "Избыточный вес";
                labelStatus.ForeColor = Color.Orange;
            }
            double waterNorm = weight * 0.035;
            labelLitr.Text = $"{Math.Round(waterNorm, 1)} л";
            string waterAdvice = "";
            if (activityId >= 3) // Если выбрана высокая или экстремальная активность
            {
                // Спортсменам нужно больше воды
                waterNorm += 0.5;
                waterAdvice = "Т.к. вы активно тренируетесь, ваша норма увеличена на 500 мл для компенсации потери влаги.";
            }
            else if (activityId == 1) // Сидячий образ жизни
            {
                waterAdvice = "При сидячей работе важно пить воду равномерно, чтобы избежать отеков и сонливости.";
            }
            else
            {
                waterAdvice = "Начинайте день со стакана воды. Это поможет вашему организму проснуться и включить метаболизм.";
            }

           
            labelAdvance.Text = waterAdvice;


           
            double p = (calories * 0.3) / 4;
            double f = (calories * 0.3) / 9;
            double c = (calories * 0.4) / 4;

            labelBelki.Text = $"{Math.Round(p)}г";
            labelFat.Text = $"{Math.Round(f)}г";
           labelcarbs.Text = $"{Math.Round(c)}г";

            ProgressBarBelki.Value = 30;
            ProgressBarFat.Value = 30;
            ProgressBarYgli.Value = 40;
            if (goalId == 1) // Снижение веса
            {
                if (calories < 1500)
                    mainAdvice = "Внимание: Вы выбрали очень низкий калораж. Старайтесь не придерживаться его дольше 2 недель, чтобы не замедлить метаболизм. Сделайте упор на белок!";
                else
                    mainAdvice =  "Отличный выбор для плавного похудения. Главное — стабильность. Старайтесь заменять быстрые углеводы (сладкое) на сложные (крупы).";
            }
            else if (goalId == 3) // Набор массы
            {
                mainAdvice = "Для роста мышц важен профицит. Если вес «стоит», добавьте в рацион полезные жиры (орехи, масла). И не забывайте про силовые тренировки!";
            }
            else // Поддержание / Баланс
            {
                mainAdvice = "Ваша стратегия — долголетие. Разнообразьте рацион овощами разных цветов и следите за качеством сна, чтобы энергия была на высоте.";
            }

            labelSovet.Text = mainAdvice;
        }
        
        private void ButtonNext3_Click(object sender, EventArgs e)
        {
            CalulateResults();
            CalculateAndDisplayCalories();
            // 2. Скрываем предыдущую панель
            panel3Step.Visible = false;
            ProgressBar1.Value = 100;
            // 3. Запускаем красивое появление финальной панели
            // guna2Transition1 — имя компонента, который ты перетащила на форму
            guna2Transition1.ShowSync(panel4Step);
        }



        private void ButtonFinish_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new NutriPlanDB())
                {
                    var profile = context.UserProfiles.Find(_currentUserId);

                    if (profile == null)
                    {
                        profile = new UserProfiles
                        {
                            UserId = _currentUserId
                        };
                        context.UserProfiles.Add(profile);
                    }

                    // Заполняем данные
                    profile.IdGender = SelectedGenderId;
                    profile.DateOfBirthday = DateTimePickerOfBirdthay.Value;

                    if (GoalComboBox1.SelectedValue != null)
                        profile.idGoal = (int)GoalComboBox1.SelectedValue;

                    if (ActivityLevelComboBox2.SelectedValue != null)
                        profile.IdActivityLevel = (int)ActivityLevelComboBox2.SelectedValue;

                    profile.weightCM = (int)TrackBarWeight.Value;
                    profile.heightCM = (int)TrackBarHeigh.Value;
                    profile.DailyCalories = (int)CaloriesTrackBar1.Value;
                    profile.Updatet_at = DateTime.Now;

                    context.SaveChanges();

                    MessageBox.Show("Анкета успешно сохранена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // --- ОТКРЫВАЕМ ГЛАВНУЮ ФОРМУ ---

                    // 1. Обновляем данные в сессии, чтобы в главной форме были актуальные данные
                    Session.CurrentUser = context.Users
                        .Include(u => u.UserProfiles)
                        .FirstOrDefault(u => u.Id == _currentUserId);

                    // 2. Создаем и показываем главную форму
                    MainForm mainForm = new MainForm();
                    mainForm.Show();

                    // 3. Закрываем форму анкеты
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                string errorMsg = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                MessageBox.Show("Ошибка сохранения: " + errorMsg);
            }
        }

        private void panel4Step_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            panel3Step.Visible = true;
            panel4Step.Visible = false;
            ProgressBar1.Value = 66;
        }
    }
}

