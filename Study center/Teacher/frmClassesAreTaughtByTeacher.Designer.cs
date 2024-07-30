namespace Study_center.Teacher
{
    partial class frmClassesAreTaughtByTeacher
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
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            lblTitle = new Label();
            ctrlListInfo1 = new Global_User_Controls.ctrlListInfo();
            btnClose = new Guna.UI2.WinForms.Guna2GradientButton();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.FromArgb(54, 69, 79);
            guna2Panel1.Controls.Add(lblTitle);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Location = new Point(-1, -3);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(934, 89);
            guna2Panel1.TabIndex = 39;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 23.25F, FontStyle.Bold);
            lblTitle.ForeColor = SystemColors.ButtonFace;
            lblTitle.Location = new Point(3, 6);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(918, 76);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Classes Are Taught By Teacher";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ctrlListInfo1
            // 
            ctrlListInfo1.Location = new Point(7, 103);
            ctrlListInfo1.Name = "ctrlListInfo1";
            ctrlListInfo1.Size = new Size(913, 466);
            ctrlListInfo1.TabIndex = 55;
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
            btnClose.Location = new Point(636, 519);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnClose.Size = new Size(215, 50);
            btnClose.TabIndex = 56;
            btnClose.Text = "Close";
            btnClose.Click += btnClose_Click;
            // 
            // frmClassesAreTaughtByTeacher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 603);
            Controls.Add(btnClose);
            Controls.Add(ctrlListInfo1);
            Controls.Add(guna2Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmClassesAreTaughtByTeacher";
            Text = "frmClassesAreTaughtByTeacher";
            FormClosed += frmClassesAreTaughtByTeacher_FormClosed;
            Load += frmClassesAreTaughtByTeacher_Load;
            guna2Panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label lblTitle;
        private Global_User_Controls.ctrlListInfo ctrlListInfo1;
        private Guna.UI2.WinForms.Guna2GradientButton btnClose;
    }
}