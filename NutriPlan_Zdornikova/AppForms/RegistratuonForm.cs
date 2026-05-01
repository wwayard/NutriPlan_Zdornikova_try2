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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace NutriPlan_Zdornikova.AppForms
{
    public partial class RegistratuonForm : Form
    {
        private Users _user;
        public RegistratuonForm()
        {
            InitializeComponent();
            _user = new Users();
        }
        private void completingRegistration()
        {
            _user.FullName = fullNameTextBox.Text;
            _user.email = emailTextBox.Text;
            _user.PasswordHash = passwordHashTextBox.Text;
        }

        private bool Validate()
        {
            if (string.IsNullOrEmpty(fullNameTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, введите полное имя.");
                return false;
            }

            if (string.IsNullOrEmpty(emailTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, введите email.");
                return false;
            }

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(Convert.ToString(emailTextBox.Text), emailPattern))
            {
                MessageBox.Show("Пожалуйста, введите корректный email.");
                return false;
            }

            if (string.IsNullOrEmpty(passwordHashTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, введите пароль.");
                return false;
            }

            if (passwordHashTextBox.TextLength < 6)
            {
                MessageBox.Show("Пароль должен быть не менее 6 символов.");
                return false;
            }

            return true;
        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RegistratuonForm_Load(object sender, EventArgs e)
        {

        }

        private void ButtonRegistration_Click(object sender, EventArgs e)
        {
            //if (!Validate()) return;
            completingRegistration();

            try
            {
                using (var context = new NutriPlanDB())
                {
                    bool userExists = context.Users.Any(u => u.email == emailTextBox.Text);

                    if (userExists)
                    {
                        MessageBox.Show("Пользователь с таким Email уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    var newUser = new Users
                    {

                        FullName = _user.FullName,
                        email = _user.email,              // Обратите внимание на регистр: у вас свойство 'email'
                        PasswordHash = _user.PasswordHash, // Свойство 'PasswordHash'
                        is_active = true,           // По умолчанию активен
                        created_at = DateTime.Now,  // Текущая дата создания

                        // IdRole: Если у вас есть таблица Roles, нужно указать ID роли "user".
                        // Допустим, роль "user" имеет Id = 2 (посмотрите в таблице Roles в БД)
                        IdRole = 2
                    };

                    // Добавляем объект в отслеживание контекста (состояние Added)
                    context.Users.Add(newUser);

                    // Сохраняем изменения в базу данных (генерирует INSERT запрос)
                    context.SaveChanges();
                    MessageBox.Show("Регистрация прошла успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Session.CurrentUser = newUser;

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            FormAnketa formAnketa = new FormAnketa(Session.CurrentUser.Id);
            formAnketa.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm =    new LoginForm();
            loginForm.Owner = this; // Указываем, что эта форма — "владелец"
            loginForm.Show();
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PictureBoxEye_Click(object sender, EventArgs e)
        {
            passwordHashTextBox.UseSystemPasswordChar = !passwordHashTextBox.UseSystemPasswordChar;

            // 2. Меняем картинку на кнопке
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


