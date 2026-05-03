namespace NutriPlan_Zdornikova.AppForms
{
    partial class MainForm
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
            this.usersTableAdapter = new NutriPlan_Zdornikova.NutriPlan_ZdornikovaDataSetTableAdapters.UsersTableAdapter();
            this.timerwriterTimer = new System.Windows.Forms.Timer(this.components);
            this.nutriPlan_ZdornikovaDataSet = new NutriPlan_Zdornikova.NutriPlan_ZdornikovaDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new NutriPlan_Zdornikova.NutriPlan_ZdornikovaDataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.PictureBoxPhotoPath = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PictureBoxAVATAR = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.PictureBoxChange = new Guna.UI2.WinForms.Guna2PictureBox();
            this.labelIMTSTATUS = new System.Windows.Forms.Label();
            this.labelIMT = new System.Windows.Forms.Label();
            this.ComboBoxActivity = new Guna.UI2.WinForms.Guna2ComboBox();
            this.activityLevelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProgressBarIMT = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.ComboBoxGoal = new Guna.UI2.WinForms.Guna2ComboBox();
            this.goalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TextBoxHeight = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxWeight = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Panel9 = new Guna.UI2.WinForms.Guna2Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.guna2Panel7 = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Panel8 = new Guna.UI2.WinForms.Guna2Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.PanelGlobalInfo = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.goalTableAdapter = new NutriPlan_Zdornikova.NutriPlan_ZdornikovaDataSetTableAdapters.GoalTableAdapter();
            this.activityLevelTableAdapter = new NutriPlan_Zdornikova.NutriPlan_ZdornikovaDataSetTableAdapters.ActivityLevelTableAdapter();
            this.ButtonSave = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonAddEat = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonCalculate = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.nutriPlan_ZdornikovaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPhotoPath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAVATAR)).BeginInit();
            this.guna2Panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityLevelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalBindingSource)).BeginInit();
            this.guna2Panel6.SuspendLayout();
            this.guna2Panel9.SuspendLayout();
            this.guna2Panel7.SuspendLayout();
            this.guna2Panel8.SuspendLayout();
            this.PanelGlobalInfo.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // nutriPlan_ZdornikovaDataSet
            // 
            this.nutriPlan_ZdornikovaDataSet.DataSetName = "NutriPlan_ZdornikovaDataSet";
            this.nutriPlan_ZdornikovaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.nutriPlan_ZdornikovaDataSet;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(636, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "NutriPlan";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.splitContainer1.Panel2.Controls.Add(this.ButtonCalculate);
            this.splitContainer1.Panel2.Controls.Add(this.ButtonAddEat);
            this.splitContainer1.Panel2.Controls.Add(this.PictureBoxPhotoPath);
            this.splitContainer1.Panel2.Controls.Add(this.PictureBoxAVATAR);
            this.splitContainer1.Panel2.Controls.Add(this.guna2Panel5);
            this.splitContainer1.Panel2.Controls.Add(this.PanelGlobalInfo);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1339, 593);
            this.splitContainer1.SplitterDistance = 76;
            this.splitContainer1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(570, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // PictureBoxPhotoPath
            // 
            this.PictureBoxPhotoPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxPhotoPath.Image = global::NutriPlan_Zdornikova.Properties.Resources._85423;
            this.PictureBoxPhotoPath.ImageRotate = 0F;
            this.PictureBoxPhotoPath.Location = new System.Drawing.Point(90, 7);
            this.PictureBoxPhotoPath.Name = "PictureBoxPhotoPath";
            this.PictureBoxPhotoPath.Size = new System.Drawing.Size(40, 40);
            this.PictureBoxPhotoPath.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxPhotoPath.TabIndex = 12;
            this.PictureBoxPhotoPath.TabStop = false;
            this.PictureBoxPhotoPath.Click += new System.EventHandler(this.PictureBoxPhotoPath_Click);
            // 
            // PictureBoxAVATAR
            // 
            this.PictureBoxAVATAR.ImageRotate = 0F;
            this.PictureBoxAVATAR.Location = new System.Drawing.Point(40, 47);
            this.PictureBoxAVATAR.Name = "PictureBoxAVATAR";
            this.PictureBoxAVATAR.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PictureBoxAVATAR.Size = new System.Drawing.Size(136, 134);
            this.PictureBoxAVATAR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxAVATAR.TabIndex = 13;
            this.PictureBoxAVATAR.TabStop = false;
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel5.BorderRadius = 20;
            this.guna2Panel5.Controls.Add(this.ButtonSave);
            this.guna2Panel5.Controls.Add(this.PictureBoxChange);
            this.guna2Panel5.Controls.Add(this.labelIMTSTATUS);
            this.guna2Panel5.Controls.Add(this.labelIMT);
            this.guna2Panel5.Controls.Add(this.ComboBoxActivity);
            this.guna2Panel5.Controls.Add(this.ProgressBarIMT);
            this.guna2Panel5.Controls.Add(this.ComboBoxGoal);
            this.guna2Panel5.Controls.Add(this.TextBoxHeight);
            this.guna2Panel5.Controls.Add(this.TextBoxWeight);
            this.guna2Panel5.Controls.Add(this.guna2Panel6);
            this.guna2Panel5.Controls.Add(this.guna2Panel9);
            this.guna2Panel5.Controls.Add(this.guna2Panel7);
            this.guna2Panel5.Controls.Add(this.guna2Panel8);
            this.guna2Panel5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2Panel5.Location = new System.Drawing.Point(312, 84);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(773, 399);
            this.guna2Panel5.TabIndex = 9;
            // 
            // PictureBoxChange
            // 
            this.PictureBoxChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxChange.Image = global::NutriPlan_Zdornikova.Properties.Resources._4277132;
            this.PictureBoxChange.ImageRotate = 0F;
            this.PictureBoxChange.Location = new System.Drawing.Point(721, 362);
            this.PictureBoxChange.Name = "PictureBoxChange";
            this.PictureBoxChange.Size = new System.Drawing.Size(30, 30);
            this.PictureBoxChange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxChange.TabIndex = 13;
            this.PictureBoxChange.TabStop = false;
            this.PictureBoxChange.Click += new System.EventHandler(this.PictureBoxChange_Click);
            // 
            // labelIMTSTATUS
            // 
            this.labelIMTSTATUS.AutoSize = true;
            this.labelIMTSTATUS.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIMTSTATUS.Location = new System.Drawing.Point(221, 299);
            this.labelIMTSTATUS.Name = "labelIMTSTATUS";
            this.labelIMTSTATUS.Size = new System.Drawing.Size(51, 19);
            this.labelIMTSTATUS.TabIndex = 12;
            this.labelIMTSTATUS.Text = "label6";
            // 
            // labelIMT
            // 
            this.labelIMT.AutoSize = true;
            this.labelIMT.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIMT.Location = new System.Drawing.Point(221, 264);
            this.labelIMT.Name = "labelIMT";
            this.labelIMT.Size = new System.Drawing.Size(51, 19);
            this.labelIMT.TabIndex = 12;
            this.labelIMT.Text = "label6";
            // 
            // ComboBoxActivity
            // 
            this.ComboBoxActivity.AutoRoundedCorners = true;
            this.ComboBoxActivity.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxActivity.BorderRadius = 17;
            this.ComboBoxActivity.DataSource = this.activityLevelBindingSource;
            this.ComboBoxActivity.DisplayMember = "nameActivity";
            this.ComboBoxActivity.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxActivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxActivity.Enabled = false;
            this.ComboBoxActivity.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxActivity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxActivity.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxActivity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBoxActivity.ItemHeight = 30;
            this.ComboBoxActivity.Location = new System.Drawing.Point(178, 178);
            this.ComboBoxActivity.Name = "ComboBoxActivity";
            this.ComboBoxActivity.Size = new System.Drawing.Size(325, 36);
            this.ComboBoxActivity.TabIndex = 11;
            this.ComboBoxActivity.ValueMember = "idActivity";
            // 
            // activityLevelBindingSource
            // 
            this.activityLevelBindingSource.DataMember = "ActivityLevel";
            this.activityLevelBindingSource.DataSource = this.nutriPlan_ZdornikovaDataSet;
            // 
            // ProgressBarIMT
            // 
            this.ProgressBarIMT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.ProgressBarIMT.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ProgressBarIMT.ForeColor = System.Drawing.Color.White;
            this.ProgressBarIMT.Location = new System.Drawing.Point(12, 220);
            this.ProgressBarIMT.Maximum = 50;
            this.ProgressBarIMT.Minimum = 0;
            this.ProgressBarIMT.Name = "ProgressBarIMT";
            this.ProgressBarIMT.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ProgressBarIMT.Size = new System.Drawing.Size(172, 172);
            this.ProgressBarIMT.TabIndex = 10;
            // 
            // ComboBoxGoal
            // 
            this.ComboBoxGoal.AutoRoundedCorners = true;
            this.ComboBoxGoal.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxGoal.BorderRadius = 17;
            this.ComboBoxGoal.DataSource = this.goalBindingSource;
            this.ComboBoxGoal.DisplayMember = "NameGoal";
            this.ComboBoxGoal.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxGoal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxGoal.Enabled = false;
            this.ComboBoxGoal.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxGoal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxGoal.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxGoal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBoxGoal.ItemHeight = 30;
            this.ComboBoxGoal.Location = new System.Drawing.Point(178, 126);
            this.ComboBoxGoal.Name = "ComboBoxGoal";
            this.ComboBoxGoal.Size = new System.Drawing.Size(376, 36);
            this.ComboBoxGoal.TabIndex = 11;
            this.ComboBoxGoal.ValueMember = "IdGoal";
            // 
            // goalBindingSource
            // 
            this.goalBindingSource.DataMember = "Goal";
            this.goalBindingSource.DataSource = this.nutriPlan_ZdornikovaDataSet;
            // 
            // TextBoxHeight
            // 
            this.TextBoxHeight.Animated = true;
            this.TextBoxHeight.AutoRoundedCorners = true;
            this.TextBoxHeight.BorderRadius = 13;
            this.TextBoxHeight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxHeight.DefaultText = "";
            this.TextBoxHeight.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxHeight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxHeight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxHeight.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxHeight.Enabled = false;
            this.TextBoxHeight.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxHeight.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxHeight.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxHeight.Location = new System.Drawing.Point(178, 72);
            this.TextBoxHeight.Name = "TextBoxHeight";
            this.TextBoxHeight.PlaceholderForeColor = System.Drawing.Color.White;
            this.TextBoxHeight.PlaceholderText = "";
            this.TextBoxHeight.SelectedText = "";
            this.TextBoxHeight.Size = new System.Drawing.Size(376, 28);
            this.TextBoxHeight.TabIndex = 10;
            // 
            // TextBoxWeight
            // 
            this.TextBoxWeight.Animated = true;
            this.TextBoxWeight.AutoRoundedCorners = true;
            this.TextBoxWeight.BorderRadius = 13;
            this.TextBoxWeight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxWeight.DefaultText = "";
            this.TextBoxWeight.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxWeight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxWeight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxWeight.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxWeight.Enabled = false;
            this.TextBoxWeight.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxWeight.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxWeight.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxWeight.Location = new System.Drawing.Point(178, 18);
            this.TextBoxWeight.Name = "TextBoxWeight";
            this.TextBoxWeight.PlaceholderForeColor = System.Drawing.Color.White;
            this.TextBoxWeight.PlaceholderText = "";
            this.TextBoxWeight.SelectedText = "";
            this.TextBoxWeight.Size = new System.Drawing.Size(379, 28);
            this.TextBoxWeight.TabIndex = 9;
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel6.BorderRadius = 15;
            this.guna2Panel6.Controls.Add(this.label4);
            this.guna2Panel6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2Panel6.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2Panel6.Location = new System.Drawing.Point(12, 181);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.Size = new System.Drawing.Size(147, 33);
            this.guna2Panel6.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(20, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Активность:";
            // 
            // guna2Panel9
            // 
            this.guna2Panel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel9.BorderRadius = 15;
            this.guna2Panel9.Controls.Add(this.label16);
            this.guna2Panel9.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2Panel9.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2Panel9.Location = new System.Drawing.Point(12, 126);
            this.guna2Panel9.Name = "guna2Panel9";
            this.guna2Panel9.Size = new System.Drawing.Size(91, 43);
            this.guna2Panel9.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(18, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 23);
            this.label16.TabIndex = 0;
            this.label16.Text = "Цель:";
            // 
            // guna2Panel7
            // 
            this.guna2Panel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel7.BorderRadius = 15;
            this.guna2Panel7.Controls.Add(this.label5);
            this.guna2Panel7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2Panel7.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2Panel7.Location = new System.Drawing.Point(12, 67);
            this.guna2Panel7.Name = "guna2Panel7";
            this.guna2Panel7.Size = new System.Drawing.Size(73, 42);
            this.guna2Panel7.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Рост:";
            // 
            // guna2Panel8
            // 
            this.guna2Panel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel8.BorderRadius = 15;
            this.guna2Panel8.Controls.Add(this.label15);
            this.guna2Panel8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2Panel8.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2Panel8.Location = new System.Drawing.Point(12, 13);
            this.guna2Panel8.Name = "guna2Panel8";
            this.guna2Panel8.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(7);
            this.guna2Panel8.Size = new System.Drawing.Size(66, 33);
            this.guna2Panel8.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(12, 5);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 23);
            this.label15.TabIndex = 0;
            this.label15.Text = "Вес:";
            // 
            // PanelGlobalInfo
            // 
            this.PanelGlobalInfo.BackColor = System.Drawing.Color.Transparent;
            this.PanelGlobalInfo.BorderRadius = 20;
            this.PanelGlobalInfo.Controls.Add(this.guna2Panel4);
            this.PanelGlobalInfo.Controls.Add(this.guna2Panel3);
            this.PanelGlobalInfo.Controls.Add(this.guna2Panel1);
            this.PanelGlobalInfo.Controls.Add(this.labelUser);
            this.PanelGlobalInfo.Controls.Add(this.labelAge);
            this.PanelGlobalInfo.Controls.Add(this.labelGender);
            this.PanelGlobalInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PanelGlobalInfo.Location = new System.Drawing.Point(12, 191);
            this.PanelGlobalInfo.Name = "PanelGlobalInfo";
            this.PanelGlobalInfo.Size = new System.Drawing.Size(210, 244);
            this.PanelGlobalInfo.TabIndex = 0;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel4.BorderRadius = 15;
            this.guna2Panel4.Controls.Add(this.label14);
            this.guna2Panel4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2Panel4.Location = new System.Drawing.Point(10, 162);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(97, 29);
            this.guna2Panel4.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(12, 5);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 19);
            this.label14.TabIndex = 0;
            this.label14.Text = "Возраст:";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.BorderRadius = 15;
            this.guna2Panel3.Controls.Add(this.label13);
            this.guna2Panel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2Panel3.Location = new System.Drawing.Point(10, 88);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(62, 29);
            this.guna2Panel3.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(12, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 19);
            this.label13.TabIndex = 0;
            this.label13.Text = "Пол:";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 15;
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2Panel1.Location = new System.Drawing.Point(7, 13);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(7);
            this.guna2Panel1.Size = new System.Drawing.Size(167, 29);
            this.guna2Panel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Имя пользователя:";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUser.Location = new System.Drawing.Point(6, 48);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(141, 19);
            this.labelUser.TabIndex = 3;
            this.labelUser.Text = "Имя пользователя:";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAge.Location = new System.Drawing.Point(15, 208);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(69, 19);
            this.labelAge.TabIndex = 5;
            this.labelAge.Text = "Возраст:";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGender.Location = new System.Drawing.Point(15, 126);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(40, 19);
            this.labelGender.TabIndex = 4;
            this.labelGender.Text = "Пол:";
            // 
            // goalTableAdapter
            // 
            this.goalTableAdapter.ClearBeforeFill = true;
            // 
            // activityLevelTableAdapter
            // 
            this.activityLevelTableAdapter.ClearBeforeFill = true;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Animated = true;
            this.ButtonSave.AutoRoundedCorners = true;
            this.ButtonSave.DefaultAutoSize = true;
            this.ButtonSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ButtonSave.Font = new System.Drawing.Font("Candara", 12F);
            this.ButtonSave.ForeColor = System.Drawing.Color.White;
            this.ButtonSave.IndicateFocus = true;
            this.ButtonSave.Location = new System.Drawing.Point(581, 361);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(107, 31);
            this.ButtonSave.TabIndex = 14;
            this.ButtonSave.Text = "Сохранить ";
            this.ButtonSave.Visible = false;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonAddEat
            // 
            this.ButtonAddEat.Animated = true;
            this.ButtonAddEat.AnimatedGIF = true;
            this.ButtonAddEat.AutoRoundedCorners = true;
            this.ButtonAddEat.BackColor = System.Drawing.Color.Transparent;
            this.ButtonAddEat.BorderRadius = 22;
            this.ButtonAddEat.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.ButtonAddEat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAddEat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonAddEat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonAddEat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonAddEat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonAddEat.FillColor = System.Drawing.Color.MistyRose;
            this.ButtonAddEat.Font = new System.Drawing.Font("Candara Light", 12F);
            this.ButtonAddEat.ForeColor = System.Drawing.Color.Black;
            this.ButtonAddEat.Location = new System.Drawing.Point(1132, 102);
            this.ButtonAddEat.Name = "ButtonAddEat";
            this.ButtonAddEat.Size = new System.Drawing.Size(173, 46);
            this.ButtonAddEat.TabIndex = 16;
            this.ButtonAddEat.Text = "Добавление приема пищи на сегодня ";
            // 
            // ButtonCalculate
            // 
            this.ButtonCalculate.Animated = true;
            this.ButtonCalculate.AnimatedGIF = true;
            this.ButtonCalculate.AutoRoundedCorners = true;
            this.ButtonCalculate.BackColor = System.Drawing.Color.Transparent;
            this.ButtonCalculate.BorderRadius = 22;
            this.ButtonCalculate.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.ButtonCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCalculate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonCalculate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonCalculate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonCalculate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonCalculate.FillColor = System.Drawing.Color.MistyRose;
            this.ButtonCalculate.Font = new System.Drawing.Font("Candara Light", 12F);
            this.ButtonCalculate.ForeColor = System.Drawing.Color.Black;
            this.ButtonCalculate.Location = new System.Drawing.Point(1132, 191);
            this.ButtonCalculate.Name = "ButtonCalculate";
            this.ButtonCalculate.Size = new System.Drawing.Size(173, 46);
            this.ButtonCalculate.TabIndex = 16;
            this.ButtonCalculate.Text = "Калькулятор калорий ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 593);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserProfiles";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nutriPlan_ZdornikovaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPhotoPath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAVATAR)).EndInit();
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityLevelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalBindingSource)).EndInit();
            this.guna2Panel6.ResumeLayout(false);
            this.guna2Panel6.PerformLayout();
            this.guna2Panel9.ResumeLayout(false);
            this.guna2Panel9.PerformLayout();
            this.guna2Panel7.ResumeLayout(false);
            this.guna2Panel7.PerformLayout();
            this.guna2Panel8.ResumeLayout(false);
            this.guna2Panel8.PerformLayout();
            this.PanelGlobalInfo.ResumeLayout(false);
            this.PanelGlobalInfo.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private NutriPlan_ZdornikovaDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Timer timerwriterTimer;
        private NutriPlan_ZdornikovaDataSet nutriPlan_ZdornikovaDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private NutriPlan_ZdornikovaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel PanelGlobalInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelUser;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel7;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel8;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxWeight;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxHeight;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel9;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxGoal;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxActivity;
        private Guna.UI2.WinForms.Guna2CircleProgressBar ProgressBarIMT;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBoxPhotoPath;
        private Guna.UI2.WinForms.Guna2CirclePictureBox PictureBoxAVATAR;
        private System.Windows.Forms.BindingSource goalBindingSource;
        private NutriPlan_ZdornikovaDataSetTableAdapters.GoalTableAdapter goalTableAdapter;
        private System.Windows.Forms.BindingSource activityLevelBindingSource;
        private NutriPlan_ZdornikovaDataSetTableAdapters.ActivityLevelTableAdapter activityLevelTableAdapter;
        private System.Windows.Forms.Label labelIMTSTATUS;
        private System.Windows.Forms.Label labelIMT;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBoxChange;
        private Guna.UI2.WinForms.Guna2Button ButtonSave;
        private Guna.UI2.WinForms.Guna2Button ButtonAddEat;
        private Guna.UI2.WinForms.Guna2Button ButtonCalculate;
    }
}