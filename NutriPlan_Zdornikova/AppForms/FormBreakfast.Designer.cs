namespace NutriPlan_Zdornikova.AppForms
{
    partial class FormAddEat
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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddEat));
            this.activityLevelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nutriPlan_ZdornikovaDataSet = new NutriPlan_Zdornikova.NutriPlan_ZdornikovaDataSet();
            this.goalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CaloriesToolTip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.activityLevelTableAdapter = new NutriPlan_Zdornikova.NutriPlan_ZdornikovaDataSetTableAdapters.ActivityLevelTableAdapter();
            this.goalTableAdapter = new NutriPlan_Zdornikova.NutriPlan_ZdornikovaDataSetTableAdapters.GoalTableAdapter();
            this.userProfilesTableAdapter = new NutriPlan_Zdornikova.NutriPlan_ZdornikovaDataSetTableAdapters.UserProfilesTableAdapter();
            this.userProfilesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guna2PictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.timerwriterTimer = new System.Windows.Forms.Timer(this.components);
            this.usersTableAdapter = new NutriPlan_Zdornikova.NutriPlan_ZdornikovaDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new NutriPlan_Zdornikova.NutriPlan_ZdornikovaDataSetTableAdapters.TableAdapterManager();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.activityLevelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nutriPlan_ZdornikovaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userProfilesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // activityLevelBindingSource
            // 
            this.activityLevelBindingSource.DataMember = "ActivityLevel";
            this.activityLevelBindingSource.DataSource = this.nutriPlan_ZdornikovaDataSet;
            // 
            // nutriPlan_ZdornikovaDataSet
            // 
            this.nutriPlan_ZdornikovaDataSet.DataSetName = "NutriPlan_ZdornikovaDataSet";
            this.nutriPlan_ZdornikovaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // goalBindingSource
            // 
            this.goalBindingSource.DataMember = "Goal";
            this.goalBindingSource.DataSource = this.nutriPlan_ZdornikovaDataSet;
            // 
            // CaloriesToolTip
            // 
            this.CaloriesToolTip.AllowLinksHandling = true;
            this.CaloriesToolTip.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CaloriesToolTip.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CaloriesToolTip.ForeColor = System.Drawing.Color.Black;
            this.CaloriesToolTip.IsBalloon = true;
            this.CaloriesToolTip.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // activityLevelTableAdapter
            // 
            this.activityLevelTableAdapter.ClearBeforeFill = true;
            // 
            // goalTableAdapter
            // 
            this.goalTableAdapter.ClearBeforeFill = true;
            // 
            // userProfilesTableAdapter
            // 
            this.userProfilesTableAdapter.ClearBeforeFill = true;
            // 
            // userProfilesBindingSource
            // 
            this.userProfilesBindingSource.DataMember = "UserProfiles";
            this.userProfilesBindingSource.DataSource = this.nutriPlan_ZdornikovaDataSet;
            // 
            // guna2PictureBox
            // 
            this.guna2PictureBox.BorderRadius = 20;
            this.guna2Transition1.SetDecoration(this.guna2PictureBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox.Image = global::NutriPlan_Zdornikova.Properties.Resources.free_icon_logo_187869;
            this.guna2PictureBox.ImageRotate = 0F;
            this.guna2PictureBox.Location = new System.Drawing.Point(12, 12);
            this.guna2PictureBox.Name = "guna2PictureBox";
            this.guna2PictureBox.Size = new System.Drawing.Size(50, 50);
            this.guna2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox.TabIndex = 0;
            this.guna2PictureBox.TabStop = false;
            // 
            // splitContainer1
            // 
            this.guna2Transition1.SetDecoration(this.splitContainer1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.MistyRose;
            this.splitContainer1.Panel1.Controls.Add(this.guna2PictureBox);
            this.guna2Transition1.SetDecoration(this.splitContainer1.Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.guna2Transition1.SetDecoration(this.splitContainer1.Panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.splitContainer1.Size = new System.Drawing.Size(1119, 491);
            this.splitContainer1.SplitterDistance = 67;
            this.splitContainer1.TabIndex = 3;
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
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.nutriPlan_ZdornikovaDataSet;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent;
            this.guna2Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.guna2Transition1.DefaultAnimation = animation1;
            // 
            // flowLayoutPanel1
            // 
            this.guna2Transition1.SetDecoration(this.flowLayoutPanel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1119, 420);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // FormAddEat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 491);
            this.Controls.Add(this.splitContainer1);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Name = "FormAddEat";
            this.Text = "FormAddEat";
            ((System.ComponentModel.ISupportInitialize)(this.activityLevelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nutriPlan_ZdornikovaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userProfilesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource activityLevelBindingSource;
        private NutriPlan_ZdornikovaDataSet nutriPlan_ZdornikovaDataSet;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private System.Windows.Forms.BindingSource goalBindingSource;
        private Guna.UI2.WinForms.Guna2HtmlToolTip CaloriesToolTip;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private NutriPlan_ZdornikovaDataSetTableAdapters.ActivityLevelTableAdapter activityLevelTableAdapter;
        private NutriPlan_ZdornikovaDataSetTableAdapters.GoalTableAdapter goalTableAdapter;
        private NutriPlan_ZdornikovaDataSetTableAdapters.UserProfilesTableAdapter userProfilesTableAdapter;
        private System.Windows.Forms.BindingSource userProfilesBindingSource;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Timer timerwriterTimer;
        private NutriPlan_ZdornikovaDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private NutriPlan_ZdornikovaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}