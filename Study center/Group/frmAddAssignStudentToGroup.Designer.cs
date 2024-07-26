namespace Study_center.Group
{
    partial class frmAddAssignStudentToGroup
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnClose = new Guna.UI2.WinForms.Guna2GradientButton();
            btnSave = new Guna.UI2.WinForms.Guna2GradientButton();
            guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            tpTeacherInfo = new TabPage();
            ctrlTeacherCard1 = new Teacher.ctrlTeacherCardWithFilter();
            tpSubjectInfo = new TabPage();
            cbSubjects = new Guna.UI2.WinForms.Guna2ComboBox();
            cbGradeLevels = new Guna.UI2.WinForms.Guna2ComboBox();
            cbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            label12 = new Label();
            dgvGradeLevelSubjects = new Guna.UI2.WinForms.Guna2DataGridView();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            label1 = new Label();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            lblTitle = new Label();
            guna2TabControl1.SuspendLayout();
            tpTeacherInfo.SuspendLayout();
            tpSubjectInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGradeLevelSubjects).BeginInit();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.BorderRadius = 15;
            btnClose.CustomizableEdges = customizableEdges1;
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
            btnClose.Location = new Point(571, 879);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnClose.Size = new Size(215, 50);
            btnClose.TabIndex = 57;
            btnClose.Text = "Close";
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.BorderRadius = 15;
            btnSave.CustomizableEdges = customizableEdges3;
            btnSave.DisabledState.BorderColor = Color.DarkGray;
            btnSave.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSave.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnSave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSave.FillColor = Color.FromArgb(54, 69, 79);
            btnSave.FillColor2 = SystemColors.HotTrack;
            btnSave.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Image = Properties.Resources.bookmark;
            btnSave.ImageAlign = HorizontalAlignment.Left;
            btnSave.Location = new Point(341, 879);
            btnSave.Name = "btnSave";
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSave.Size = new Size(215, 50);
            btnSave.TabIndex = 56;
            btnSave.Text = "Save";
            // 
            // guna2TabControl1
            // 
            guna2TabControl1.Controls.Add(tpTeacherInfo);
            guna2TabControl1.Controls.Add(tpSubjectInfo);
            guna2TabControl1.ItemSize = new Size(180, 40);
            guna2TabControl1.Location = new Point(0, 84);
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
            guna2TabControl1.TabIndex = 55;
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
            tpTeacherInfo.Text = "Student Info";
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
            tpSubjectInfo.Controls.Add(cbSubjects);
            tpSubjectInfo.Controls.Add(cbGradeLevels);
            tpSubjectInfo.Controls.Add(cbFilter);
            tpSubjectInfo.Controls.Add(label12);
            tpSubjectInfo.Controls.Add(dgvGradeLevelSubjects);
            tpSubjectInfo.Controls.Add(guna2Separator1);
            tpSubjectInfo.Controls.Add(label1);
            tpSubjectInfo.Location = new Point(4, 44);
            tpSubjectInfo.Name = "tpSubjectInfo";
            tpSubjectInfo.Padding = new Padding(3);
            tpSubjectInfo.Size = new Size(925, 735);
            tpSubjectInfo.TabIndex = 1;
            tpSubjectInfo.Text = "Group Info";
            tpSubjectInfo.UseVisualStyleBackColor = true;
            // 
            // cbSubjects
            // 
            cbSubjects.BackColor = Color.Transparent;
            cbSubjects.BorderColor = Color.FromArgb(7, 43, 71);
            cbSubjects.BorderRadius = 17;
            cbSubjects.BorderThickness = 2;
            cbSubjects.CustomizableEdges = customizableEdges5;
            cbSubjects.DrawMode = DrawMode.OwnerDrawFixed;
            cbSubjects.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSubjects.FocusedColor = Color.DarkCyan;
            cbSubjects.FocusedState.BorderColor = Color.DarkCyan;
            cbSubjects.Font = new Font("Segoe UI", 10F);
            cbSubjects.ForeColor = Color.FromArgb(68, 88, 112);
            cbSubjects.ItemHeight = 30;
            cbSubjects.Location = new Point(384, 107);
            cbSubjects.Name = "cbSubjects";
            cbSubjects.ShadowDecoration.CustomizableEdges = customizableEdges6;
            cbSubjects.Size = new Size(223, 36);
            cbSubjects.TabIndex = 64;
            cbSubjects.Visible = false;
            // 
            // cbGradeLevels
            // 
            cbGradeLevels.BackColor = Color.Transparent;
            cbGradeLevels.BorderColor = Color.FromArgb(7, 43, 71);
            cbGradeLevels.BorderRadius = 17;
            cbGradeLevels.BorderThickness = 2;
            cbGradeLevels.CustomizableEdges = customizableEdges7;
            cbGradeLevels.DrawMode = DrawMode.OwnerDrawFixed;
            cbGradeLevels.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGradeLevels.FocusedColor = Color.DarkCyan;
            cbGradeLevels.FocusedState.BorderColor = Color.DarkCyan;
            cbGradeLevels.Font = new Font("Segoe UI", 10F);
            cbGradeLevels.ForeColor = Color.FromArgb(68, 88, 112);
            cbGradeLevels.ItemHeight = 30;
            cbGradeLevels.Location = new Point(384, 107);
            cbGradeLevels.Name = "cbGradeLevels";
            cbGradeLevels.ShadowDecoration.CustomizableEdges = customizableEdges8;
            cbGradeLevels.Size = new Size(223, 36);
            cbGradeLevels.TabIndex = 63;
            cbGradeLevels.Visible = false;
            // 
            // cbFilter
            // 
            cbFilter.BackColor = Color.Transparent;
            cbFilter.BorderColor = Color.FromArgb(7, 43, 71);
            cbFilter.BorderRadius = 17;
            cbFilter.CustomizableEdges = customizableEdges9;
            cbFilter.DrawMode = DrawMode.OwnerDrawFixed;
            cbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilter.FocusedColor = Color.CadetBlue;
            cbFilter.FocusedState.BorderColor = Color.CadetBlue;
            cbFilter.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            cbFilter.ForeColor = Color.Black;
            cbFilter.ItemHeight = 30;
            cbFilter.Items.AddRange(new object[] { "None", "Subject", "Grade Level" });
            cbFilter.Location = new Point(136, 107);
            cbFilter.Name = "cbFilter";
            cbFilter.ShadowDecoration.CustomizableEdges = customizableEdges10;
            cbFilter.Size = new Size(223, 36);
            cbFilter.TabIndex = 54;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Comic Sans MS", 13F, FontStyle.Bold);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(51, 110);
            label12.Name = "label12";
            label12.Size = new Size(82, 31);
            label12.TabIndex = 52;
            label12.Text = "Filter:";
            // 
            // dgvGradeLevelSubjects
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvGradeLevelSubjects.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DarkCyan;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumAquamarine;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvGradeLevelSubjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvGradeLevelSubjects.ColumnHeadersHeight = 4;
            dgvGradeLevelSubjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvGradeLevelSubjects.DefaultCellStyle = dataGridViewCellStyle3;
            dgvGradeLevelSubjects.GridColor = Color.FromArgb(231, 229, 255);
            dgvGradeLevelSubjects.Location = new Point(22, 174);
            dgvGradeLevelSubjects.Name = "dgvGradeLevelSubjects";
            dgvGradeLevelSubjects.RowHeadersVisible = false;
            dgvGradeLevelSubjects.RowHeadersWidth = 51;
            dgvGradeLevelSubjects.Size = new Size(882, 523);
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
            // guna2Separator1
            // 
            guna2Separator1.FillThickness = 5;
            guna2Separator1.Location = new Point(22, 73);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(882, 18);
            guna2Separator1.TabIndex = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 20F, FontStyle.Bold);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(68, 25);
            label1.Name = "label1";
            label1.Size = new Size(332, 48);
            label1.TabIndex = 47;
            label1.Text = "Select the Group :";
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.FromArgb(54, 69, 79);
            guna2Panel1.Controls.Add(lblTitle);
            guna2Panel1.CustomizableEdges = customizableEdges11;
            guna2Panel1.Location = new Point(0, -1);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2Panel1.Size = new Size(933, 85);
            guna2Panel1.TabIndex = 54;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 23.25F, FontStyle.Bold);
            lblTitle.ForeColor = SystemColors.ButtonFace;
            lblTitle.Location = new Point(3, 6);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(918, 76);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Appointing Teacher For The Subject";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmAddAssignStudentToGroup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 933);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(guna2TabControl1);
            Controls.Add(guna2Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAddAssignStudentToGroup";
            Text = "frmAddAssignStudentToGroup";
            guna2TabControl1.ResumeLayout(false);
            tpTeacherInfo.ResumeLayout(false);
            tpSubjectInfo.ResumeLayout(false);
            tpSubjectInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGradeLevelSubjects).EndInit();
            guna2Panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btnClose;
        private Guna.UI2.WinForms.Guna2GradientButton btnSave;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private TabPage tpTeacherInfo;
        private Teacher.ctrlTeacherCardWithFilter ctrlTeacherCard1;
        private TabPage tpSubjectInfo;
        private Guna.UI2.WinForms.Guna2ComboBox cbSubjects;
        private Guna.UI2.WinForms.Guna2ComboBox cbGradeLevels;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilter;
        private Label label12;
        private Guna.UI2.WinForms.Guna2DataGridView dgvGradeLevelSubjects;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label lblTitle;
    }
}