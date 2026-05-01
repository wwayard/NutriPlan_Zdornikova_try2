using NutriPlan_Zdornikova.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NutriPlan_Zdornikova.Program;
using System.Data.Entity;

namespace NutriPlan_Zdornikova.AppForms
{
    public partial class LoginForm : Form
    {
        private string targetText = "Добро пожаловать в NutriPlan"; // Текст, который будем печатать
        private string currentText = "";         // Текущий напечатанный текст
        private int charIndex = 0;
        private Users _user;
        public LoginForm()
        {
            InitializeComponent();
            labelWelcome.Text = "";
            this.Load += RegistrationForm_Load; 
            timerwriterTimer.Tick += timerwriterTimer_Tick;

            _user = new Users();
        }



        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nutriPlan_ZdornikovaDataSet.Users". При необходимости она может быть перемещена или удалена.
         
            timerwriterTimer.Start();

        }

        private void passwordHashLabel_Click(object sender, EventArgs e)
        {

        }

        private void timerwriterTimer_Tick(object sender, EventArgs e)
        {

            if (charIndex < targetText.Length)
            {
                // Добавляем следующий символ
                currentText += targetText[charIndex];
                labelWelcome.Text = currentText;

                charIndex++;
            }
            else
            {
                // Текст напечатан полностью, останавливаем таймер
                timerwriterTimer.Stop();
            }
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text.Trim();
            string password = passwordHashTextBox.Text.Trim();

            // 1. Валидация Email
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Пожалуйста, введите корректный email.");
                return;
            }

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Заполните все поля!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var context = new NutriPlanDB())
                {
                    // Ищем пользовател
                        // ВАЖНО: Используем Include, чтобы сразу загрузить данные анкеты (UserProfile)
                        // Замените "UserProfile" на название вашего свойства навигации в классе Users
                        var user = context.Users
                            .Include(u => u.UserProfiles)
                            .FirstOrDefault(u => u.email == email && u.PasswordHash == password);

                        if (user != null)
                        {
                            // Сохраняем пользователя в сессию
                            Session.CurrentUser = user;

                            // ПРОВЕРКА: Существует ли анкета?
                            // Если UserProfile равен null, значит записи в отдельной таблице нет
                            bool hasSurvey = user.UserProfiles != null;

                            this.Hide();

                            if (!hasSurvey)
                            {
                                // --- АНКЕТЫ НЕТ ---

                                // Передаем ID пользователя в форму анкеты
                               FormAnketa formAnketa = new FormAnketa(Session.CurrentUser.Id);

                                DialogResult result = formAnketa.ShowDialog();

                                if (result == DialogResult.OK)
                                {
                                    // После успешного сохранения анкеты, обновляем данные в сессии,
                                    // чтобы в главном окне сразу видеть новые данные
                                    RefreshUserDataFromDB();
                                    OpenMainForm();
                                }
                                else
                                {
                                    this.Show();
                                    Session.CurrentUser = null;
                                }
                            }
                            else
                            {
                                // --- АНКЕТА ЕСТЬ ---
                                OpenMainForm();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Неверный Email или пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
    catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения: " + ex.Message);
            }
        }

        // Метод для обновления данных пользователя из БД (чтобы подтянуть созданную анкету)
        private void RefreshUserDataFromDB()
        {
            if (Session.CurrentUser == null) return;

            using (var context = new NutriPlanDB())
            {
                var updatedUser = context.Users
                    .Include(u => u.UserProfiles)
                    .FirstOrDefault(u => u.Id == Session.CurrentUser.Id);

                if (updatedUser != null)
                {
                    Session.CurrentUser = updatedUser;
                }
            }
        }

        private void OpenMainForm()
        {
            MainForm userProfiles = new MainForm();
            userProfiles.FormClosed += (s, args) => this.Close();
            userProfiles.Show();
        }
        

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {

            this.Hide();
                 RegistratuonForm registratuonForm   = new RegistratuonForm();
                 registratuonForm.Show();
       


            

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PictureBoxEye_Click(object sender, EventArgs e)
        {
            passwordHashTextBox.UseSystemPasswordChar = !passwordHashTextBox.UseSystemPasswordChar;

       
            if (passwordHashTextBox.UseSystemPasswordChar)
            {
                // Пароль скрыт — ставим закрытый глаз
                PictureBoxEye.Image = Properties.Resources.images;
            }
            else
            {
                // Пароль виден — ставим открытый глаз
                PictureBoxEye.Image = Properties.Resources.images__1_;
            }
        }
    }
}
