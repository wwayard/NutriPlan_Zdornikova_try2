using NutriPlan_Zdornikova.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NutriPlan_Zdornikova.Program;

namespace NutriPlan_Zdornikova.AppForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadUserProfile();
        }

        private void label3_Click(object sender, EventArgs e)
        {


        }

        private void LoadUserProfile()
        {
            if (Session.CurrentUser?.UserProfiles?.PhotoPath == null ||
        string.IsNullOrEmpty(Session.CurrentUser.UserProfiles.PhotoPath))
            {
                return; // Нет фото — выходим
            }

            try
            {
                // Собираем полный путь к файлу
                string photosFolder = Path.Combine(Application.StartupPath, "UserPhotos");
                string fullPath = Path.Combine(photosFolder, Session.CurrentUser.UserProfiles.PhotoPath);

                // Проверяем, существует ли файл
                if (!File.Exists(fullPath))
                {
                    MessageBox.Show($"Файл не найден: {fullPath}", "Предупреждение");
                    return;
                }

                // Загружаем изображение из файла
                PictureBoxAVATAR.Image = Image.FromFile(fullPath);
                PictureBoxAVATAR.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки фото: {ex.Message}", "Ошибка");
            }

        }

        private void CalculateIMT(int weight, int heightCm)
        {
            double heightM = heightCm / 100.0;
            double imt = weight / (heightM * heightM);

        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nutriPlan_ZdornikovaDataSet.ActivityLevel". При необходимости она может быть перемещена или удалена.
            this.activityLevelTableAdapter.Fill(this.nutriPlan_ZdornikovaDataSet.ActivityLevel);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nutriPlan_ZdornikovaDataSet.Goal". При необходимости она может быть перемещена или удалена.
            this.goalTableAdapter.Fill(this.nutriPlan_ZdornikovaDataSet.Goal);
            label2.Text = $"Добро пожаловать {Session.CurrentUser.FullName}";

            if (Session.CurrentUser == null || Session.CurrentUser.UserProfiles == null)
            {
                MessageBox.Show("Ошибка: Данные профиля не найдены. Пожалуйста, войдите снова.");
                this.Close();
                new LoginForm().Show();
                return;
            }

            var profile = Session.CurrentUser.UserProfiles;
            labelUser.Text = Session.CurrentUser.FullName;
            TextBoxWeight.Text = $"{profile.weightCM} кг";
            TextBoxHeight.Text = $"{profile.heightCM} см";
            labelGender.Text = profile.IdGender == 1 ? "Мужской" : "Женский";
            ComboBoxGoal.SelectedValue = profile.idGoal; // Метод для преобразования ID цели в текст
            ComboBoxActivity.SelectedValue = profile.IdActivityLevel; // Аналогично для активности
            labelAge.Text = $"{profile.DateOfBirthday}";

            double heightInMeters = profile.heightCM / 100.0;
            double bmi = profile.weightCM / (heightInMeters * heightInMeters);

            if (bmi < 18.5)
            {
                ProgressBarIMT.ProgressColor = Color.SkyBlue; // Дефицит
                labelIMTSTATUS.Text = "Дефицит";
                labelIMTSTATUS.ForeColor = Color.Blue;
            }
            else if (bmi < 25)
            {
                ProgressBarIMT.ProgressColor = Color.SeaGreen; // Норма
                labelIMTSTATUS.Text = "Норма";
                labelIMTSTATUS.ForeColor = Color.Green;
            }
            else
            {
                ProgressBarIMT.ProgressColor = Color.IndianRed; // Избыток
                labelIMTSTATUS.Text = "Избыток";
                labelIMTSTATUS.ForeColor = Color.Red;
            }
            ProgressBarIMT.Value = (int)bmi;
            // Можно рассчитать ИМТ, БЖУ и т.д.
            CalculateIMT((int)profile.weightCM, profile.heightCM);


            labelIMT.Text = bmi.ToString("F1");

        }


        private void PictureBoxPhotoPath_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Фильтр: показываем только картинки
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Выберите фотографию профиля";

                // Начальная папка (можно оставить пустой, тогда откроется последняя использованная)
                // openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Путь к файлу, который выбрал пользователь (где бы он ни лежал)
                        string sourceFilePath = openFileDialog.FileName;

                        // Берем только имя файла (например, "photo.png")
                        string fileName = Path.GetFileName(sourceFilePath);

                        // Создаем уникальное имя, чтобы не перезаписать чужое фото
                        // Формат: IDПользователя_ДатаВремя_ИмяФайла
                        string uniqueFileName = $"{Session.CurrentUser.Id}_{DateTime.Now:yyyyMMdd_HHmmss}_{fileName}";

                        // Определяем папку внутри проекта для хранения всех аватарок
                        string appFolder = Application.StartupPath; // Папка, где лежит .exe файл
                        string photosFolder = Path.Combine(appFolder, "UserPhotos");

                        // Если папки нет, создаем её
                        if (!Directory.Exists(photosFolder))
                        {
                            Directory.CreateDirectory(photosFolder);
                        }

                        // Полный путь, куда мы сохраним КОПИЮ файла
                        string destinationFilePath = Path.Combine(photosFolder, uniqueFileName);

                        // 2. КОПИРУЕМ файл из любой папки пользователя в нашу папку проекта
                        File.Copy(sourceFilePath, destinationFilePath, true); // true = перезаписать, если вдруг есть

                        // 3. Сохраняем ИМЯ файла в базу данных
                        SavePhotoToDatabase(uniqueFileName);

                        // 4. Показываем фото в PictureBox сразу же (берем из нашей папки)
                        PictureBoxAVATAR.Image = Image.FromFile(destinationFilePath);
                        PictureBoxAVATAR.SizeMode = PictureBoxSizeMode.StretchImage;

                        MessageBox.Show("Аватарка успешно обновлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при сохранении фото: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void SavePhotoToDatabase(string photoFileName)
        {
            using (var context = new NutriPlanDB())
            {
                var profile = context.UserProfiles.Find(Session.CurrentUser.Id);

                if (profile != null)
                {
                    // ВАЖНО: Убедитесь, что поле в БД называется PhotoPath (или как у вас)
                    // И что оно типа NVARCHAR (строка), а не VARBINARY (байты).
                    profile.PhotoPath = photoFileName;

                    context.SaveChanges();

                    // Обновляем данные в текущей сессии, чтобы они были актуальны
                    Session.CurrentUser.UserProfiles = profile;
                }
            }

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBoxChange_Click(object sender, EventArgs e)
        {
            TextBoxHeight.Enabled = true;
            TextBoxWeight.Enabled = true;
            ComboBoxGoal.Enabled = true;
            ComboBoxActivity.Enabled = true;

            PictureBoxChange.Visible = false;
            ButtonSave.Visible = true;
            MessageBox.Show("Режим редактирования активирован. Измените данные и нажмите 'Сохранить'.",
                   "Редактирование", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Простая валидация
                if (string.IsNullOrWhiteSpace(TextBoxWeight.Text) ||
                    string.IsNullOrWhiteSpace(TextBoxHeight.Text))
                {
                    MessageBox.Show("Заполните вес и рост!");
                    return;
                }

                using (var context = new NutriPlanDB())
                {
                    // Находим профиль текущего пользователя
                    var profile = context.UserProfiles.Find(Session.CurrentUser.Id);

                    if (profile != null)
                    {
                        // Обновляем данные из полей формы
                        // Парсим текст в числа
                        profile.weightCM = int.Parse(TextBoxWeight.Text.Replace(" кг", "")); // Удаляем " кг" если оно есть в тексте
                        profile.heightCM = int.Parse(TextBoxHeight.Text.Replace(" см", ""));     // Удаляем " см" если оно есть

                        // Для комбобоксов берем SelectedValue (ID)
                        if (ComboBoxGoal.SelectedValue != null)
                            profile.idGoal = (int)ComboBoxGoal.SelectedValue;

                        if (ComboBoxActivity.SelectedValue != null)
                            profile.IdActivityLevel = (int)ComboBoxActivity.SelectedValue;

                        // Сохраняем в БД
                        context.SaveChanges();

                        // Обновляем сессию, чтобы данные были актуальны везде
                        Session.CurrentUser.UserProfiles = profile;

                        MessageBox.Show("Данные успешно обновлены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // 3. Возвращаемся в режим просмотра
                        ExitEditMode();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Вспомогательный метод для выхода из режима редактирования
        private void ExitEditMode()
        {
            // Блокируем поля
            TextBoxWeight.Enabled = false;
            TextBoxHeight.Enabled = false;
            ComboBoxGoal.Enabled = false;
            ComboBoxActivity.Enabled = false;

            // Возвращаем иконки
            PictureBoxChange.Visible = true;       // Показываем карандаш
            ButtonSave.Visible = false;   // Скрываем кнопку сохранить
        }
    }
    }
    

