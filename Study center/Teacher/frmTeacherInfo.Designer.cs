namespace Study_center.Teacher
{
    partial class frmTeacherInfo
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
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            lblTitle = new Label();
            ctrlTeacherCardWithFilter1 = new ctrlTeacherCardWithFilter();
            btnClose = new Guna.UI2.WinForms.Guna2GradientButton();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Separator1
            // 
            guna2Separator1.FillThickness = 5;
            guna2Separator1.Location = new Point(23, 98);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(882, 20);
            guna2Separator1.TabIndex = 30;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.FromArgb(54, 69, 79);
            guna2Panel1.Controls.Add(lblTitle);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Location = new Point(-2, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(954, 82);
            guna2Panel1.TabIndex = 29;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 30.25F, FontStyle.Bold);
            lblTitle.ForeColor = SystemColors.ButtonFace;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(942, 76);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Teacher Info";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ctrlTeacherCardWithFilter1
            // 
            ctrlTeacherCardWithFilter1.Location = new Point(34, 133);
            ctrlTeacherCardWithFilter1.Name = "ctrlTeacherCardWithFilter1";
            ctrlTeacherCardWithFilter1.Size = new Size(893, 735);
            ctrlTeacherCardWithFilter1.TabIndex = 31;
            // 
            // btnClose
            // 
            btnClose.BorderRadius = 15;
            btnClose.CustomizableEdges = customizableEdges3;
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
            btnClose.Location = new Point(366, 874);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnClose.Size = new Size(214, 50);
            btnClose.TabIndex = 65;
            btnClose.Text = "Close";
            btnClose.Click += btnClose_Click;
            // 
            // frmTeacherInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 932);
            Controls.Add(btnClose);
            Controls.Add(ctrlTeacherCardWithFilter1);
            Controls.Add(guna2Separator1);
            Controls.Add(guna2Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(67, 22);
            Name = "frmTeacherInfo";
            Text = "frmTeacherInfo";
            FormClosed += frmTeacherInfo_FormClosed;
            Load += frmTeacherInfo_Load;
            guna2Panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label lblTitle;
        private ctrlTeacherCardWithFilter ctrlTeacherCardWithFilter1;
        private Guna.UI2.WinForms.Guna2GradientButton btnClose;
    }
}