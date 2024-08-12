﻿namespace Study_center.Class
{
    partial class frmFindClass
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
            ctrlClassCardWithFilter1 = new User_Control.ctrlClassCardWithFilter();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            btnClose = new Guna.UI2.WinForms.Guna2GradientButton();
            guna2GradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 30.25F, FontStyle.Bold);
            lblTitle.ForeColor = SystemColors.ButtonFace;
            lblTitle.Location = new Point(67, 82);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(933, 76);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Find Class";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ctrlClassCardWithFilter1
            // 
            ctrlClassCardWithFilter1.Location = new Point(27, 111);
            ctrlClassCardWithFilter1.Name = "ctrlClassCardWithFilter1";
            ctrlClassCardWithFilter1.Size = new Size(884, 354);
            ctrlClassCardWithFilter1.TabIndex = 39;
            // 
            // guna2Separator1
            // 
            guna2Separator1.FillThickness = 5;
            guna2Separator1.Location = new Point(7, 91);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(930, 14);
            guna2Separator1.TabIndex = 42;
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
            guna2GradientPanel1.Size = new Size(1035, 158);
            guna2GradientPanel1.TabIndex = 43;
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
            btnClose.Location = new Point(746, 471);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnClose.Size = new Size(234, 50);
            btnClose.TabIndex = 69;
            btnClose.Text = "Close";
            btnClose.Click += btnClose_Click_1;
            // 
            // frmFindClass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 539);
            Controls.Add(btnClose);
            Controls.Add(guna2GradientPanel1);
            Controls.Add(guna2Separator1);
            Controls.Add(ctrlClassCardWithFilter1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmFindClass";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmFindClass";
            Load += frmFindClass_Load;
            guna2GradientPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label lblTitle;
        private User_Control.ctrlClassCardWithFilter ctrlClassCardWithFilter1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2GradientButton btnClose;
    }
}