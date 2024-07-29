namespace Study_center.Teacher_and_Subject
{
    partial class frmAllTeachersWhoTeachSubject
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            guna2Panel1.CustomizableEdges = customizableEdges5;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges6;
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
            lblTitle.Text = "All Teachers Who Teach The Subject";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ctrlListInfo1
            // 
            ctrlListInfo1.Location = new Point(25, 110);
            ctrlListInfo1.Name = "ctrlListInfo1";
            ctrlListInfo1.Size = new Size(896, 411);
            ctrlListInfo1.TabIndex = 39;
            // 
            // btnClose
            // 
            btnClose.BorderRadius = 15;
            btnClose.CustomizableEdges = customizableEdges7;
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
            btnClose.Location = new Point(686, 531);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnClose.Size = new Size(215, 50);
            btnClose.TabIndex = 54;
            btnClose.Text = "Close";
            btnClose.Click += btnClose_Click;
            // 
            // frmAllTeachersWhoTeachSubject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 593);
            Controls.Add(btnClose);
            Controls.Add(ctrlListInfo1);
            Controls.Add(guna2Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAllTeachersWhoTeachSubject";
            Text = "frmAllTeachersWhoTeachSubject";
            FormClosed += frmAllTeachersWhoTeachSubject_FormClosed;
            Load += frmAllTeachersWhoTeachSubject_Load;
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