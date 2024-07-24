namespace Study_center.Group
{
    partial class frmAddGroup
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
            btnClose = new Guna.UI2.WinForms.Guna2GradientButton();
            btnSave = new Guna.UI2.WinForms.Guna2GradientButton();
            TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            tpClassInfo = new TabPage();
            ctrlClassCardWithFilter1 = new Class.User_Control.ctrlClassCardWithFilter();
            tpTeacherInfo = new TabPage();
            ctrlTeacherCard1 = new Teacher.ctrlTeacherCard();
            tpSubjectInfo = new TabPage();
            ctrlListInfo1 = new Global_User_Controls.ctrlListInfo();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            label1 = new Label();
            tpMeetinTimeInfo = new TabPage();
            ctrlListInfo2 = new Global_User_Controls.ctrlListInfo();
            guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            label2 = new Label();
            tpGroupInfo = new TabPage();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            lblTitle = new Label();
            TabControl1.SuspendLayout();
            tpClassInfo.SuspendLayout();
            tpTeacherInfo.SuspendLayout();
            tpSubjectInfo.SuspendLayout();
            tpMeetinTimeInfo.SuspendLayout();
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
            btnClose.Location = new Point(640, 864);
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
            btnSave.Location = new Point(410, 864);
            btnSave.Name = "btnSave";
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSave.Size = new Size(215, 50);
            btnSave.TabIndex = 56;
            btnSave.Text = "Save";
            // 
            // TabControl1
            // 
            TabControl1.Controls.Add(tpClassInfo);
            TabControl1.Controls.Add(tpTeacherInfo);
            TabControl1.Controls.Add(tpSubjectInfo);
            TabControl1.Controls.Add(tpMeetinTimeInfo);
            TabControl1.Controls.Add(tpGroupInfo);
            TabControl1.ItemSize = new Size(180, 40);
            TabControl1.Location = new Point(-1, 73);
            TabControl1.Name = "TabControl1";
            TabControl1.SelectedIndex = 0;
            TabControl1.Size = new Size(947, 776);
            TabControl1.TabButtonHoverState.BorderColor = Color.Empty;
            TabControl1.TabButtonHoverState.FillColor = Color.FromArgb(40, 52, 70);
            TabControl1.TabButtonHoverState.Font = new Font("Segoe UI Semibold", 10F);
            TabControl1.TabButtonHoverState.ForeColor = Color.White;
            TabControl1.TabButtonHoverState.InnerColor = Color.FromArgb(40, 52, 70);
            TabControl1.TabButtonIdleState.BorderColor = Color.Empty;
            TabControl1.TabButtonIdleState.FillColor = Color.FromArgb(54, 69, 79);
            TabControl1.TabButtonIdleState.Font = new Font("Segoe UI Semibold", 10F);
            TabControl1.TabButtonIdleState.ForeColor = Color.FromArgb(156, 160, 167);
            TabControl1.TabButtonIdleState.InnerColor = Color.FromArgb(54, 69, 79);
            TabControl1.TabButtonSelectedState.BorderColor = Color.Empty;
            TabControl1.TabButtonSelectedState.FillColor = Color.FromArgb(54, 69, 79);
            TabControl1.TabButtonSelectedState.Font = new Font("Segoe UI Semibold", 10F);
            TabControl1.TabButtonSelectedState.ForeColor = Color.White;
            TabControl1.TabButtonSelectedState.InnerColor = Color.DarkCyan;
            TabControl1.TabButtonSize = new Size(180, 40);
            TabControl1.TabIndex = 55;
            TabControl1.TabMenuBackColor = Color.FromArgb(54, 69, 79);
            TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            TabControl1.Selecting += TabControl1_Selecting;
            // 
            // tpClassInfo
            // 
            tpClassInfo.Controls.Add(ctrlClassCardWithFilter1);
            tpClassInfo.Location = new Point(4, 44);
            tpClassInfo.Name = "tpClassInfo";
            tpClassInfo.Size = new Size(939, 728);
            tpClassInfo.TabIndex = 2;
            tpClassInfo.Text = "Class Info";
            tpClassInfo.UseVisualStyleBackColor = true;
            // 
            // ctrlClassCardWithFilter1
            // 
            ctrlClassCardWithFilter1.Location = new Point(9, 172);
            ctrlClassCardWithFilter1.Name = "ctrlClassCardWithFilter1";
            ctrlClassCardWithFilter1.Size = new Size(904, 360);
            ctrlClassCardWithFilter1.TabIndex = 0;
            ctrlClassCardWithFilter1.ClassSelected += CtrlClassCardWithFilter1_ClassSelected;
            // 
            // tpTeacherInfo
            // 
            tpTeacherInfo.Controls.Add(ctrlTeacherCard1);
            tpTeacherInfo.Location = new Point(4, 44);
            tpTeacherInfo.Name = "tpTeacherInfo";
            tpTeacherInfo.Padding = new Padding(3);
            tpTeacherInfo.Size = new Size(939, 728);
            tpTeacherInfo.TabIndex = 0;
            tpTeacherInfo.Text = "Teacher Info";
            tpTeacherInfo.UseVisualStyleBackColor = true;
            // 
            // ctrlTeacherCard1
            // 
            ctrlTeacherCard1.Location = new Point(20, 3);
            ctrlTeacherCard1.Name = "ctrlTeacherCard1";
            ctrlTeacherCard1.Size = new Size(891, 717);
            ctrlTeacherCard1.TabIndex = 0;
            ctrlTeacherCard1.TeacherSelected += CtrlTeacherCard1_TeacherSelected;
            // 
            // tpSubjectInfo
            // 
            tpSubjectInfo.Controls.Add(ctrlListInfo1);
            tpSubjectInfo.Controls.Add(guna2Separator1);
            tpSubjectInfo.Controls.Add(label1);
            tpSubjectInfo.Location = new Point(4, 44);
            tpSubjectInfo.Name = "tpSubjectInfo";
            tpSubjectInfo.Padding = new Padding(3);
            tpSubjectInfo.Size = new Size(939, 728);
            tpSubjectInfo.TabIndex = 1;
            tpSubjectInfo.Text = "Subject Info";
            tpSubjectInfo.UseVisualStyleBackColor = true;
            // 
            // ctrlListInfo1
            // 
            ctrlListInfo1.Location = new Point(22, 132);
            ctrlListInfo1.Name = "ctrlListInfo1";
            ctrlListInfo1.Size = new Size(882, 445);
            ctrlListInfo1.TabIndex = 51;
            ctrlListInfo1.SelectedItem += CtrlListInfo1_SelectedItem;
            // 
            // guna2Separator1
            // 
            guna2Separator1.FillThickness = 5;
            guna2Separator1.Location = new Point(22, 87);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(882, 18);
            guna2Separator1.TabIndex = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 20F, FontStyle.Bold);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(22, 22);
            label1.Name = "label1";
            label1.Size = new Size(633, 48);
            label1.TabIndex = 47;
            label1.Text = "All subject that the Teacher Teach:";
            // 
            // tpMeetinTimeInfo
            // 
            tpMeetinTimeInfo.Controls.Add(ctrlListInfo2);
            tpMeetinTimeInfo.Controls.Add(guna2Separator2);
            tpMeetinTimeInfo.Controls.Add(label2);
            tpMeetinTimeInfo.Location = new Point(4, 44);
            tpMeetinTimeInfo.Name = "tpMeetinTimeInfo";
            tpMeetinTimeInfo.Padding = new Padding(3);
            tpMeetinTimeInfo.Size = new Size(939, 728);
            tpMeetinTimeInfo.TabIndex = 3;
            tpMeetinTimeInfo.Text = "MeetingTime Info";
            tpMeetinTimeInfo.UseVisualStyleBackColor = true;
            // 
            // ctrlListInfo2
            // 
            ctrlListInfo2.Location = new Point(31, 152);
            ctrlListInfo2.Name = "ctrlListInfo2";
            ctrlListInfo2.Size = new Size(882, 445);
            ctrlListInfo2.TabIndex = 54;
            ctrlListInfo2.SelectedItem += CtrlListInfo2_SelectedItem;
            // 
            // guna2Separator2
            // 
            guna2Separator2.FillThickness = 5;
            guna2Separator2.Location = new Point(31, 107);
            guna2Separator2.Name = "guna2Separator2";
            guna2Separator2.Size = new Size(882, 18);
            guna2Separator2.TabIndex = 53;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 20F, FontStyle.Bold);
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(31, 42);
            label2.Name = "label2";
            label2.Size = new Size(496, 48);
            label2.TabIndex = 52;
            label2.Text = "All Available Meeting Times:";
            // 
            // tpGroupInfo
            // 
            tpGroupInfo.Location = new Point(4, 44);
            tpGroupInfo.Name = "tpGroupInfo";
            tpGroupInfo.Padding = new Padding(3);
            tpGroupInfo.Size = new Size(939, 728);
            tpGroupInfo.TabIndex = 4;
            tpGroupInfo.Text = "Group Info";
            tpGroupInfo.UseVisualStyleBackColor = true;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.FromArgb(54, 69, 79);
            guna2Panel1.Controls.Add(lblTitle);
            guna2Panel1.CustomizableEdges = customizableEdges5;
            guna2Panel1.Location = new Point(-4, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Panel1.Size = new Size(950, 87);
            guna2Panel1.TabIndex = 54;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 23.25F, FontStyle.Bold);
            lblTitle.ForeColor = SystemColors.ButtonFace;
            lblTitle.Location = new Point(38, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(897, 76);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Appointing Teacher For The Subject";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmAddGroup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 938);
            Controls.Add(TabControl1);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(guna2Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAddGroup";
            Text = "frmAddGroup";
            Load += frmAddGroup_Load_1;
            TabControl1.ResumeLayout(false);
            tpClassInfo.ResumeLayout(false);
            tpTeacherInfo.ResumeLayout(false);
            tpSubjectInfo.ResumeLayout(false);
            tpSubjectInfo.PerformLayout();
            tpMeetinTimeInfo.ResumeLayout(false);
            tpMeetinTimeInfo.PerformLayout();
            guna2Panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btnClose;
        private Guna.UI2.WinForms.Guna2GradientButton btnSave;
        private Guna.UI2.WinForms.Guna2TabControl TabControl1;
        private TabPage tpTeacherInfo;
        private Teacher.ctrlTeacherCard ctrlTeacherCard1;
        private TabPage tpSubjectInfo;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label lblTitle;
        private TabPage tpClassInfo;
        private Class.User_Control.ctrlClassCardWithFilter ctrlClassCardWithFilter1;
        private Global_User_Controls.ctrlListInfo ctrlListInfo1;
        private TabPage tpMeetinTimeInfo;
        private Global_User_Controls.ctrlListInfo ctrlListInfo2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Label label2;
        private TabPage tpGroupInfo;
    }
}