namespace NutriPlan_Zdornikova.AppForms
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label fullNameLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label passwordHashLabel;
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PictureBoxEye = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonRegistration = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonLogin = new Guna.UI2.WinForms.Guna2Button();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nutriPlan_ZdornikovaDataSet = new NutriPlan_Zdornikova.NutriPlan_ZdornikovaDataSet();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passwordHashTextBox = new System.Windows.Forms.TextBox();
            this.timerwriterTimer = new System.Windows.Forms.Timer(this.components);
            this.usersTableAdapter = new NutriPlan_Zdornikova.NutriPlan_ZdornikovaDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new NutriPlan_Zdornikova.NutriPlan_ZdornikovaDataSetTableAdapters.TableAdapterManager();
            fullNameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            passwordHashLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nutriPlan_ZdornikovaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            fullNameLabel.Location = new System.Drawing.Point(52, 45);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(197, 19);
            fullNameLabel.TabIndex = 0;
            fullNameLabel.Text = "Введите имя пользователя:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            emailLabel.Location = new System.Drawing.Point(44, 100);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(205, 19);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Введите электронную почту:";
            // 
            // passwordHashLabel
            // 
            passwordHashLabel.AutoSize = true;
            passwordHashLabel.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            passwordHashLabel.Location = new System.Drawing.Point(89, 162);
            passwordHashLabel.Name = "passwordHashLabel";
            passwordHashLabel.Size = new System.Drawing.Size(122, 19);
            passwordHashLabel.TabIndex = 4;
            passwordHashLabel.Text = "Введите пароль:";
            passwordHashLabel.Click += new System.EventHandler(this.passwordHashLabel_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.MistyRose;
            this.splitContainer1.Panel1.Controls.Add(this.guna2Button2);
            this.splitContainer1.Panel1.Controls.Add(this.labelWelcome);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.guna2PictureBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.splitContainer1.Panel2.Controls.Add(this.PictureBoxEye);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.ButtonRegistration);
            this.splitContainer1.Panel2.Controls.Add(this.ButtonLogin);
            this.splitContainer1.Panel2.Controls.Add(fullNameLabel);
            this.splitContainer1.Panel2.Controls.Add(this.fullNameTextBox);
            this.splitContainer1.Panel2.Controls.Add(emailLabel);
            this.splitContainer1.Panel2.Controls.Add(this.emailTextBox);
            this.splitContainer1.Panel2.Controls.Add(passwordHashLabel);
            this.splitContainer1.Panel2.Controls.Add(this.passwordHashTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(305, 466);
            this.splitContainer1.SplitterDistance = 101;
            this.splitContainer1.TabIndex = 0;
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.AnimatedGIF = true;
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 10;
            this.guna2Button2.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2Button2.Font = new System.Drawing.Font("Candara Light", 12F);
            this.guna2Button2.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.Location = new System.Drawing.Point(222, 3);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(80, 28);
            this.guna2Button2.TabIndex = 7;
            this.guna2Button2.Text = "Выход";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWelcome.Location = new System.Drawing.Point(40, 70);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(25, 19);
            this.labelWelcome.TabIndex = 3;
            this.labelWelcome.Text = "aa";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(102, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Регистрация ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(111, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "NutriPlan";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2PictureBox
            // 
            this.guna2PictureBox.BorderRadius = 20;
            this.guna2PictureBox.Image = global::NutriPlan_Zdornikova.Properties.Resources.free_icon_logo_187869;
            this.guna2PictureBox.ImageRotate = 0F;
            this.guna2PictureBox.Location = new System.Drawing.Point(12, 12);
            this.guna2PictureBox.Name = "guna2PictureBox";
            this.guna2PictureBox.Size = new System.Drawing.Size(50, 50);
            this.guna2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox.TabIndex = 0;
            this.guna2PictureBox.TabStop = false;
            // 
            // PictureBoxEye
            // 
            this.PictureBoxEye.BorderRadius = 5;
            this.PictureBoxEye.Image = global::NutriPlan_Zdornikova.Properties.Resources.images;
            this.PictureBoxEye.ImageRotate = 0F;
            this.PictureBoxEye.Location = new System.Drawing.Point(255, 184);
            this.PictureBoxEye.Name = "PictureBoxEye";
            this.PictureBoxEye.Size = new System.Drawing.Size(23, 20);
            this.PictureBoxEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxEye.TabIndex = 7;
            this.PictureBoxEye.TabStop = false;
            this.PictureBoxEye.Click += new System.EventHandler(this.PictureBoxEye_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(75, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Не создали еще аккаунт?\r\nТогда зарегиструйтесь \r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonRegistration
            // 
            this.ButtonRegistration.Animated = true;
            this.ButtonRegistration.AnimatedGIF = true;
            this.ButtonRegistration.BackColor = System.Drawing.Color.Transparent;
            this.ButtonRegistration.BorderRadius = 10;
            this.ButtonRegistration.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.ButtonRegistration.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonRegistration.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonRegistration.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonRegistration.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonRegistration.FillColor = System.Drawing.Color.MistyRose;
            this.ButtonRegistration.Font = new System.Drawing.Font("Candara Light", 12F);
            this.ButtonRegistration.ForeColor = System.Drawing.Color.Black;
            this.ButtonRegistration.Location = new System.Drawing.Point(44, 309);
            this.ButtonRegistration.Name = "ButtonRegistration";
            this.ButtonRegistration.Size = new System.Drawing.Size(210, 31);
            this.ButtonRegistration.TabIndex = 5;
            this.ButtonRegistration.Text = "Зарегистрироваться";
            this.ButtonRegistration.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Animated = true;
            this.ButtonLogin.AnimatedGIF = true;
            this.ButtonLogin.BackColor = System.Drawing.Color.Transparent;
            this.ButtonLogin.BorderRadius = 10;
            this.ButtonLogin.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.ButtonLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonLogin.FillColor = System.Drawing.Color.MistyRose;
            this.ButtonLogin.Font = new System.Drawing.Font("Candara Light", 12F);
            this.ButtonLogin.ForeColor = System.Drawing.Color.Black;
            this.ButtonLogin.Location = new System.Drawing.Point(44, 224);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(205, 31);
            this.ButtonLogin.TabIndex = 4;
            this.ButtonLogin.Text = "Войти";
            this.ButtonLogin.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "FullName", true));
            this.fullNameTextBox.Location = new System.Drawing.Point(48, 67);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(201, 20);
            this.fullNameTextBox.TabIndex = 1;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.nutriPlan_ZdornikovaDataSet;
            // 
            // nutriPlan_ZdornikovaDataSet
            // 
            this.nutriPlan_ZdornikovaDataSet.DataSetName = "NutriPlan_ZdornikovaDataSet";
            this.nutriPlan_ZdornikovaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(48, 122);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(201, 20);
            this.emailTextBox.TabIndex = 2;
            // 
            // passwordHashTextBox
            // 
            this.passwordHashTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "PasswordHash", true));
            this.passwordHashTextBox.Location = new System.Drawing.Point(48, 184);
            this.passwordHashTextBox.Name = "passwordHashTextBox";
            this.passwordHashTextBox.Size = new System.Drawing.Size(201, 20);
            this.passwordHashTextBox.TabIndex = 3;
            this.passwordHashTextBox.UseSystemPasswordChar = true;
            // 
            // timerwriterTimer
            // 
            this.timerwriterTimer.Tick += new System.EventHandler(this.timerwriterTimer_Tick);
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActivityLevelTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.dishesTableAdapter = null;
            this.tableAdapterManager.FoodLogsTableAdapter = null;
            this.tableAdapterManager.GenderTableAdapter = null;
            this.tableAdapterManager.GoalTableAdapter = null;
            this.tableAdapterManager.RoleTableAdapter = null;
            this.tableAdapterManager.TypesMealTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NutriPlan_Zdornikova.NutriPlan_ZdornikovaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserProfilesTableAdapter = null;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            this.tableAdapterManager.ViewDishesTableAdapter = null;
            this.tableAdapterManager.WeightHistoryTableAdapter = null;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 466);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nutriPlan_ZdornikovaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private NutriPlan_ZdornikovaDataSet nutriPlan_ZdornikovaDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private NutriPlan_ZdornikovaDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private NutriPlan_ZdornikovaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox passwordHashTextBox;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Timer timerwriterTimer;
        private Guna.UI2.WinForms.Guna2Button ButtonLogin;
        private Guna.UI2.WinForms.Guna2Button ButtonRegistration;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBoxEye;
    }
}