namespace Study_center.Class
{
    partial class frmClassInfo
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
            lblTitle = new Label();
            ctrlClassGard1 = new User_Control.ctrlClassGard();
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            label1 = new Label();
            btnClose = new Guna.UI2.WinForms.Guna2GradientButton();
            guna2GradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Separator1
            // 
            guna2Separator1.FillThickness = 5;
            guna2Separator1.Location = new Point(28, 88);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(852, 30);
            guna2Separator1.TabIndex = 32;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 30.25F, FontStyle.Bold);
            lblTitle.ForeColor = SystemColors.ButtonFace;
            lblTitle.Location = new Point(52, 82);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(948, 76);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Class Info";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ctrlClassGard1
            // 
            ctrlClassGard1.Location = new Point(28, 124);
            ctrlClassGard1.Name = "ctrlClassGard1";
            ctrlClassGard1.Size = new Size(852, 190);
            ctrlClassGard1.TabIndex = 33;
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.BorderRadius = 200;
            guna2GradientPanel1.Controls.Add(label1);
            guna2GradientPanel1.Controls.Add(lblTitle);
            guna2GradientPanel1.CustomizableEdges = customizableEdges1;
            guna2GradientPanel1.FillColor = Color.FromArgb(54, 69, 79);
            guna2GradientPanel1.FillColor2 = Color.MediumAquamarine;
            guna2GradientPanel1.Location = new Point(-40, -80);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2GradientPanel1.Size = new Size(1029, 158);
            guna2GradientPanel1.TabIndex = 67;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 30.25F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(-40, -80);
            label1.Name = "label1";
            label1.Size = new Size(858, 76);
            label1.TabIndex = 0;
            label1.Text = "Add Teacher";
            label1.TextAlign = ContentAlignment.MiddleCenter;
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
            btnClose.Location = new Point(747, 320);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnClose.Size = new Size(227, 50);
            btnClose.TabIndex = 68;
            btnClose.Text = "Close";
            btnClose.Click += btnClose_Click_1;
            // 
            // frmClassInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 393);
            Controls.Add(btnClose);
            Controls.Add(guna2GradientPanel1);
            Controls.Add(ctrlClassGard1);
            Controls.Add(guna2Separator1);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(67, 22);
            Name = "frmClassInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmClassInfo";
            FormClosed += frmClassInfo_FormClosed;
            Load += frmClassInfo_Load;
            guna2GradientPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Label lblTitle;
        private User_Control.ctrlClassGard ctrlClassGard1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton btnClose;
    }
}