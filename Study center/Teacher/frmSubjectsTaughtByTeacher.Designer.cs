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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            lblTitle = new Label();
            guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            tpTeacherInfo = new TabPage();
            ctrlTeacherCard1 = new ctrlTeacherCard();
            tpSubjectInfo = new TabPage();
            pictureBox1 = new PictureBox();
            guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            lblTeacherName = new Label();
            dgvGradeLevelSubjects = new Guna.UI2.WinForms.Guna2DataGridView();
            btnClose = new Guna.UI2.WinForms.Guna2GradientButton();
            guna2Panel1.SuspendLayout();
            guna2TabControl1.SuspendLayout();
            tpTeacherInfo.SuspendLayout();
            tpSubjectInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGradeLevelSubjects).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.FromArgb(54, 69, 79);
            guna2Panel1.Controls.Add(lblTitle);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(933, 85);
            guna2Panel1.TabIndex = 38;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 23.25F, FontStyle.Bold);
            lblTitle.ForeColor = SystemColors.ButtonFace;
            lblTitle.Location = new Point(3, 6);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(918, 76);
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
            tpSubjectInfo.Controls.Add(pictureBox1);
            tpSubjectInfo.Controls.Add(guna2GroupBox1);
            tpSubjectInfo.Location = new Point(4, 44);
            tpSubjectInfo.Name = "tpSubjectInfo";
            tpSubjectInfo.Padding = new Padding(3);
            tpSubjectInfo.Size = new Size(925, 735);
            tpSubjectInfo.TabIndex = 1;
            tpSubjectInfo.Text = "Subjects List";
            tpSubjectInfo.UseVisualStyleBackColor = true;
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
            // guna2GroupBox1
            // 
            guna2GroupBox1.Controls.Add(lblTeacherName);
            guna2GroupBox1.Controls.Add(dgvGradeLevelSubjects);
            guna2GroupBox1.CustomizableEdges = customizableEdges3;
            guna2GroupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2GroupBox1.ForeColor = Color.Black;
            guna2GroupBox1.Location = new Point(9, 252);
            guna2GroupBox1.Name = "guna2GroupBox1";
            guna2GroupBox1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2GroupBox1.Size = new Size(916, 377);
            guna2GroupBox1.TabIndex = 52;
            guna2GroupBox1.Text = "Subjects Taught By Teacher";
            // 
            // lblTeacherName
            // 
            lblTeacherName.Location = new Point(267, 6);
            lblTeacherName.Name = "lblTeacherName";
            lblTeacherName.Size = new Size(227, 34);
            lblTeacherName.TabIndex = 52;
            lblTeacherName.Text = "(Teacher Name)";
            // 
            // dgvGradeLevelSubjects
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvGradeLevelSubjects.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DarkCyan;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumAquamarine;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvGradeLevelSubjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvGradeLevelSubjects.ColumnHeadersHeight = 4;
            dgvGradeLevelSubjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvGradeLevelSubjects.DefaultCellStyle = dataGridViewCellStyle3;
            dgvGradeLevelSubjects.GridColor = Color.FromArgb(231, 229, 255);
            dgvGradeLevelSubjects.Location = new Point(3, 43);
            dgvGradeLevelSubjects.Name = "dgvGradeLevelSubjects";
            dgvGradeLevelSubjects.RowHeadersVisible = false;
            dgvGradeLevelSubjects.RowHeadersWidth = 51;
            dgvGradeLevelSubjects.Size = new Size(916, 334);
            dgvGradeLevelSubjects.TabIndex = 51;
            dgvGradeLevelSubjects.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvGradeLevelSubjects.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvGradeLevelSubjects.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvGradeLevelSubjects.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvGradeLevelSubjects.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvGradeLevelSubjects.ThemeStyle.BackColor = Color.White;
            dgvGradeLevelSubjects.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvGradeLevelSubjects.ThemeStyle.HeaderStyle.BackColor = Color.DarkCyan;
            dgvGradeLevelSubjects.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvGradeLevelSubjects.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvGradeLevelSubjects.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvGradeLevelSubjects.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvGradeLevelSubjects.ThemeStyle.HeaderStyle.Height = 4;
            dgvGradeLevelSubjects.ThemeStyle.ReadOnly = false;
            dgvGradeLevelSubjects.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvGradeLevelSubjects.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvGradeLevelSubjects.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvGradeLevelSubjects.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvGradeLevelSubjects.ThemeStyle.RowsStyle.Height = 29;
            dgvGradeLevelSubjects.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvGradeLevelSubjects.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // btnClose
            // 
            btnClose.BorderRadius = 15;
            btnClose.CustomizableEdges = customizableEdges5;
            btnClose.DisabledState.BorderColor = Color.DarkGray;
            btnClose.DisabledState.CustomBorderColor = Color.DarkGray;
            btnClose.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnClose.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnClose.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnClose.FillColor = Color.FromArgb(54, 69, 79);
            btnClose.FillColor2 = SystemColors.HotTrack;
            btnClose.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Image = Properties.Resources.close__3_;
            btnClose.ImageAlign = HorizontalAlignment.Left;
            btnClose.Location = new Point(665, 879);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnClose.Size = new Size(215, 50);
            btnClose.TabIndex = 54;
            btnClose.Text = "Close";
            btnClose.Click += btnClose_Click;
            // 
            // frmSubjectsTaughtByTeacher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 941);
            Controls.Add(btnClose);
            Controls.Add(guna2TabControl1);
            Controls.Add(guna2Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSubjectsTaughtByTeacher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSubjectsTaughtByTeacher";
            Load += frmSubjectsTaughtByTeacher_Load;
            guna2Panel1.ResumeLayout(false);
            guna2TabControl1.ResumeLayout(false);
            tpTeacherInfo.ResumeLayout(false);
            tpSubjectInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGradeLevelSubjects).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label lblTitle;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private TabPage tpTeacherInfo;
        private ctrlTeacherCard ctrlTeacherCard1;
        private TabPage tpSubjectInfo;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvGradeLevelSubjects;
        private PictureBox pictureBox1;
        private Label lblTeacherName;
        private Guna.UI2.WinForms.Guna2GradientButton btnClose;
    }
}