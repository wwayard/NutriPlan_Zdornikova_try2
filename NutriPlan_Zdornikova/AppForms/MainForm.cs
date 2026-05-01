using NutriPlan_Zdornikova.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void label3_Click(object sender, EventArgs e)
        {


        }

        private void LoadUserProfile()
        {
           
        }
        private string GetGoalName(int goalId)
        {
            switch (goalId)
            {
                case 1: return "Снижение веса";
                case 2: return "Поддержание веса";
                case 3: return "Набор массы";
                default: return "Не указано";
            }
        }

        private string GetActivityName(int activityId)
        {
            switch (activityId)
            {
                case 1: return "Сидячий образ жизни";
                case 2: return "Легкая активность";
                case 3: return "Умеренная активность";
                case 4: return "Высокая активность";
                case 5: return "Очень высокая активность";
                default: return "Не указано";
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
            guna2TextBoxWeight.Text = $"{profile.weightCM} кг";
            TextBoxHeight.Text = $"{profile.heightCM} см";
            labelGender.Text = profile.IdGender == 1 ? "Мужской" : "Женский";
            ComboBoxGoal.SelectedValue = profile.idGoal; // Метод для преобразования ID цели в текст
            ComboBoxActivity.SelectedValue = profile.IdActivityLevel; // Аналогично для активности
            labelAge.Text = $"{profile.DateOfBirthday}";

            double heightInMeters = profile.heightCM/ 100.0;
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

        private void labelUser_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void ComboBoxGoal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
