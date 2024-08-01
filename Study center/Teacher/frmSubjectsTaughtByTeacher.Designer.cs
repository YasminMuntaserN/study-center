namespace Study_center.Teacher
{
    partial class frmSubjectsTaughtByTeacher
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblTitle = new Label();
            guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            tpTeacherInfo = new TabPage();
            ctrlTeacherCard1 = new ctrlTeacherCardWithFilter();
            tpSubjectInfo = new TabPage();
            ctrlListInfo1 = new Global_User_Controls.ctrlListInfo();
            pictureBox1 = new PictureBox();
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            btnClose = new Guna.UI2.WinForms.Guna2GradientButton();
            guna2TabControl1.SuspendLayout();
            tpTeacherInfo.SuspendLayout();
            tpSubjectInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            guna2GradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 23.25F, FontStyle.Bold);
            lblTitle.ForeColor = SystemColors.ButtonFace;
            lblTitle.Location = new Point(44, 69);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(929, 89);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Subjects Taught By Teacher";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // guna2TabControl1
            // 
            guna2TabControl1.Controls.Add(tpTeacherInfo);
            guna2TabControl1.Controls.Add(tpSubjectInfo);
            guna2TabControl1.ItemSize = new Size(180, 40);
            guna2TabControl1.Location = new Point(0, 85);
            guna2TabControl1.Name = "guna2TabControl1";
            guna2TabControl1.SelectedIndex = 0;
            guna2TabControl1.Size = new Size(933, 783);
            guna2TabControl1.TabButtonHoverState.BorderColor = Color.Empty;
            guna2TabControl1.TabButtonHoverState.FillColor = Color.FromArgb(40, 52, 70);
            guna2TabControl1.TabButtonHoverState.Font = new Font("Segoe UI Semibold", 10F);
            guna2TabControl1.TabButtonHoverState.ForeColor = Color.White;
            guna2TabControl1.TabButtonHoverState.InnerColor = Color.FromArgb(40, 52, 70);
            guna2TabControl1.TabButtonIdleState.BorderColor = Color.Empty;
            guna2TabControl1.TabButtonIdleState.FillColor = Color.FromArgb(54, 69, 79);
            guna2TabControl1.TabButtonIdleState.Font = new Font("Segoe UI Semibold", 10F);
            guna2TabControl1.TabButtonIdleState.ForeColor = Color.FromArgb(156, 160, 167);
            guna2TabControl1.TabButtonIdleState.InnerColor = Color.FromArgb(54, 69, 79);
            guna2TabControl1.TabButtonSelectedState.BorderColor = Color.Empty;
            guna2TabControl1.TabButtonSelectedState.FillColor = Color.FromArgb(54, 69, 79);
            guna2TabControl1.TabButtonSelectedState.Font = new Font("Segoe UI Semibold", 10F);
            guna2TabControl1.TabButtonSelectedState.ForeColor = Color.White;
            guna2TabControl1.TabButtonSelectedState.InnerColor = Color.DarkCyan;
            guna2TabControl1.TabButtonSize = new Size(180, 40);
            guna2TabControl1.TabIndex = 39;
            guna2TabControl1.TabMenuBackColor = Color.FromArgb(54, 69, 79);
            guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tpTeacherInfo
            // 
            tpTeacherInfo.Controls.Add(ctrlTeacherCard1);
            tpTeacherInfo.Location = new Point(4, 44);
            tpTeacherInfo.Name = "tpTeacherInfo";
            tpTeacherInfo.Padding = new Padding(3);
            tpTeacherInfo.Size = new Size(925, 735);
            tpTeacherInfo.TabIndex = 0;
            tpTeacherInfo.Text = "Teacher Info";
            tpTeacherInfo.UseVisualStyleBackColor = true;
            // 
            // ctrlTeacherCard1
            // 
            ctrlTeacherCard1.Location = new Point(20, 6);
            ctrlTeacherCard1.Name = "ctrlTeacherCard1";
            ctrlTeacherCard1.Size = new Size(887, 723);
            ctrlTeacherCard1.TabIndex = 0;
            // 
            // tpSubjectInfo
            // 
            tpSubjectInfo.Controls.Add(ctrlListInfo1);
            tpSubjectInfo.Controls.Add(pictureBox1);
            tpSubjectInfo.Location = new Point(4, 44);
            tpSubjectInfo.Name = "tpSubjectInfo";
            tpSubjectInfo.Padding = new Padding(3);
            tpSubjectInfo.Size = new Size(925, 735);
            tpSubjectInfo.TabIndex = 1;
            tpSubjectInfo.Text = "Subjects List";
            tpSubjectInfo.UseVisualStyleBackColor = true;
            // 
            // ctrlListInfo1
            // 
            ctrlListInfo1.Location = new Point(6, 237);
            ctrlListInfo1.Name = "ctrlListInfo1";
            ctrlListInfo1.Size = new Size(913, 479);
            ctrlListInfo1.TabIndex = 54;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.teacher;
            pictureBox1.Location = new Point(270, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(338, 213);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 53;
            pictureBox1.TabStop = false;
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.BorderRadius = 200;
            guna2GradientPanel1.Controls.Add(lblTitle);
            guna2GradientPanel1.CustomizableEdges = customizableEdges1;
            guna2GradientPanel1.FillColor = Color.FromArgb(54, 69, 79);
            guna2GradientPanel1.FillColor2 = Color.MediumAquamarine;
            guna2GradientPanel1.Location = new Point(-40, -80);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2GradientPanel1.Size = new Size(1017, 158);
            guna2GradientPanel1.TabIndex = 55;
            // 
            // btnClose
            // 
            btnClose.BorderRadius = 30;
            btnClose.CustomizableEdges = customizableEdges3;
            btnClose.DisabledState.BorderColor = Color.DarkGray;
            btnClose.DisabledState.CustomBorderColor = Color.DarkGray;
            btnClose.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnClose.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnClose.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnClose.FillColor = Color.FromArgb(54, 69, 79);
            btnClose.FillColor2 = Color.MediumAquamarine;
            btnClose.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Image = Properties.Resources.close__3_;
            btnClose.ImageAlign = HorizontalAlignment.Left;
            btnClose.Location = new Point(750, 879);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnClose.Size = new Size(227, 50);
            btnClose.TabIndex = 39;
            btnClose.Text = "Close";
            btnClose.Click += btnClose_Click_1;
            // 
            // frmSubjectsTaughtByTeacher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 941);
            Controls.Add(btnClose);
            Controls.Add(guna2GradientPanel1);
            Controls.Add(guna2TabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSubjectsTaughtByTeacher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSubjectsTaughtByTeacher";
            FormClosed += frmSubjectsTaughtByTeacher_FormClosed;
            Load += frmSubjectsTaughtByTeacher_Load;
            guna2TabControl1.ResumeLayout(false);
            tpTeacherInfo.ResumeLayout(false);
            tpSubjectInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            guna2GradientPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label lblTitle;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private TabPage tpTeacherInfo;
        private ctrlTeacherCardWithFilter ctrlTeacherCard1;
        private TabPage tpSubjectInfo;
        private PictureBox pictureBox1;
        private Global_User_Controls.ctrlListInfo ctrlListInfo1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2GradientButton btnClose;
    }
}