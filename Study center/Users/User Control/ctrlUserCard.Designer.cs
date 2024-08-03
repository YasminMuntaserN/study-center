namespace Study_center.Users.User_Control
{
    partial class ctrlUserCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            llEditUserInfo = new LinkLabel();
            lblIsActive = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            lblUsername = new Label();
            lblUserID = new Label();
            pictureBox5 = new PictureBox();
            label12 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            ctrlPersonCardWithFilter1 = new Person.User_Controls.ctrlPersonCardWithFilter();
            guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            guna2GroupBox1.Controls.Add(llEditUserInfo);
            guna2GroupBox1.Controls.Add(lblIsActive);
            guna2GroupBox1.Controls.Add(pictureBox2);
            guna2GroupBox1.Controls.Add(label3);
            guna2GroupBox1.Controls.Add(lblUsername);
            guna2GroupBox1.Controls.Add(lblUserID);
            guna2GroupBox1.Controls.Add(pictureBox5);
            guna2GroupBox1.Controls.Add(label12);
            guna2GroupBox1.Controls.Add(pictureBox1);
            guna2GroupBox1.Controls.Add(label2);
            guna2GroupBox1.CustomBorderColor = Color.FromArgb(54, 69, 79);
            guna2GroupBox1.CustomizableEdges = customizableEdges1;
            guna2GroupBox1.Font = new Font("Segoe UI Emoji", 16.2F, FontStyle.Bold);
            guna2GroupBox1.ForeColor = Color.FromArgb(125, 137, 149);
            guna2GroupBox1.Location = new Point(3, 506);
            guna2GroupBox1.Name = "guna2GroupBox1";
            guna2GroupBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2GroupBox1.Size = new Size(889, 154);
            guna2GroupBox1.TabIndex = 3;
            guna2GroupBox1.Text = "User Info";
            // 
            // llEditUserInfo
            // 
            llEditUserInfo.AutoSize = true;
            llEditUserInfo.BackColor = Color.White;
            llEditUserInfo.Font = new Font("Segoe UI Semibold", 14.2F, FontStyle.Bold);
            llEditUserInfo.Location = new Point(588, 112);
            llEditUserInfo.Name = "llEditUserInfo";
            llEditUserInfo.Size = new Size(161, 32);
            llEditUserInfo.TabIndex = 68;
            llEditUserInfo.TabStop = true;
            llEditUserInfo.Text = "Edit User Info";
            llEditUserInfo.LinkClicked += llEditUserInfo_LinkClicked;
            // 
            // lblIsActive
            // 
            lblIsActive.AutoSize = true;
            lblIsActive.BackColor = Color.White;
            lblIsActive.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblIsActive.ForeColor = Color.Black;
            lblIsActive.Location = new Point(758, 60);
            lblIsActive.Name = "lblIsActive";
            lblIsActive.Size = new Size(62, 28);
            lblIsActive.TabIndex = 60;
            lblIsActive.Text = "[????]";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.check;
            pictureBox2.Location = new Point(716, 60);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 59;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Comic Sans MS", 13F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(577, 60);
            label3.Name = "label3";
            label3.Size = new Size(133, 31);
            label3.TabIndex = 58;
            label3.Text = "Is Active :";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.White;
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUsername.ForeColor = Color.Black;
            lblUsername.Location = new Point(457, 60);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(62, 28);
            lblUsername.TabIndex = 57;
            lblUsername.Text = "[????]";
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.BackColor = Color.Transparent;
            lblUserID.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblUserID.ForeColor = Color.Black;
            lblUserID.Location = new Point(151, 55);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(60, 32);
            lblUserID.TabIndex = 45;
            lblUserID.Text = "N\\A";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = Properties.Resources.id_card;
            pictureBox5.Location = new Point(109, 57);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(36, 32);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 44;
            pictureBox5.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Comic Sans MS", 13F, FontStyle.Bold);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(6, 57);
            label12.Name = "label12";
            label12.Size = new Size(112, 31);
            label12.TabIndex = 40;
            label12.Text = "User ID:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(415, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Comic Sans MS", 13F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(266, 56);
            label2.Name = "label2";
            label2.Size = new Size(153, 31);
            label2.TabIndex = 34;
            label2.Text = "User Name :";
            // 
            // ctrlPersonCardWithFilter1
            // 
            ctrlPersonCardWithFilter1.FilterEnabled = true;
            ctrlPersonCardWithFilter1.Location = new Point(0, 0);
            ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            ctrlPersonCardWithFilter1.Size = new Size(886, 510);
            ctrlPersonCardWithFilter1.TabIndex = 4;
            // 
            // ctrlUserCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ctrlPersonCardWithFilter1);
            Controls.Add(guna2GroupBox1);
            Name = "ctrlUserCard";
            Size = new Size(886, 665);
            guna2GroupBox1.ResumeLayout(false);
            guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Label lblIsActive;
        private PictureBox pictureBox2;
        private Label label3;
        private Label lblUsername;
        private Label lblUserID;
        private PictureBox pictureBox5;
        private Label label12;
        private PictureBox pictureBox1;
        private Label label2;
        private LinkLabel llEditUserInfo;
        private Person.User_Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
    }
}
