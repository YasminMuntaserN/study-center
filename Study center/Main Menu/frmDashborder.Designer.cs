namespace Study_center.Main_Menu
{
    partial class frmDashborder
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblDate = new Label();
            lblTime = new Label();
            pictureBox1 = new PictureBox();
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            guna2GradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Century", 35.8F, FontStyle.Bold);
            lblDate.ForeColor = Color.DarkCyan;
            lblDate.Location = new Point(274, 692);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(270, 71);
            lblDate.TabIndex = 0;
            lblDate.Text = "00:00:00";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Century", 35.8F, FontStyle.Bold);
            lblTime.Location = new Point(345, 776);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(270, 71);
            lblTime.TabIndex = 1;
            lblTime.Text = "00:00:00";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.main_form;
            pictureBox1.Location = new Point(478, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(394, 654);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.BorderRadius = 310;
            guna2GradientPanel1.Controls.Add(label3);
            guna2GradientPanel1.Controls.Add(label2);
            guna2GradientPanel1.Controls.Add(label1);
            guna2GradientPanel1.CustomizableEdges = customizableEdges1;
            guna2GradientPanel1.FillColor = Color.MediumAquamarine;
            guna2GradientPanel1.FillColor2 = SystemColors.ActiveCaption;
            guna2GradientPanel1.Location = new Point(-175, -32);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2GradientPanel1.Size = new Size(655, 683);
            guna2GradientPanel1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkBlue;
            label3.Location = new Point(187, 267);
            label3.Name = "label3";
            label3.Size = new Size(426, 39);
            label3.TabIndex = 4;
            label3.Text = "Empower Learning with SCMS!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Rockwell", 13.2F);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(178, 354);
            label2.Name = "label2";
            label2.Size = new Size(447, 125);
            label2.TabIndex = 3;
            label2.Text = "  Experience seamless student enrollment,\r\n         efficient teacher management, \r\n         and dynamic class schedulin \r\n         all in one powerful platform.\r\n ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Comic Sans MS", 33.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(178, 165);
            label1.Name = "label1";
            label1.Size = new Size(456, 78);
            label1.TabIndex = 2;
            label1.Text = "Welcome Back !";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // frmDashborder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 924);
            Controls.Add(guna2GradientPanel1);
            Controls.Add(pictureBox1);
            Controls.Add(lblTime);
            Controls.Add(lblDate);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDashborder";
            Text = "frmDashborder";
            Load += frmDashborder_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            guna2GradientPanel1.ResumeLayout(false);
            guna2GradientPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDate;
        private Label lblTime;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}