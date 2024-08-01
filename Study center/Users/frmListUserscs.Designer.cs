namespace Study_center.Users
{
    partial class frmListUserscs
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtFilterBy = new Guna.UI2.WinForms.Guna2TextBox();
            cbGender = new Guna.UI2.WinForms.Guna2ComboBox();
            label1 = new Label();
            dgvList = new Guna.UI2.WinForms.Guna2DataGridView();
            label2 = new Label();
            lblRecordsNum = new Label();
            cbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            NUMPageNumber = new Guna.UI2.WinForms.Guna2NumericUpDown();
            btnAdd = new Guna.UI2.WinForms.Guna2ImageButton();
            cmsList = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            miShowUserDetails = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            miEdit = new ToolStripMenuItem();
            miDelete = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            miChangePassword = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUMPageNumber).BeginInit();
            cmsList.SuspendLayout();
            SuspendLayout();
            // 
            // txtFilterBy
            // 
            txtFilterBy.BorderColor = Color.FromArgb(68, 88, 112);
            txtFilterBy.BorderRadius = 17;
            txtFilterBy.BorderThickness = 2;
            txtFilterBy.CustomizableEdges = customizableEdges10;
            txtFilterBy.DefaultText = "";
            txtFilterBy.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtFilterBy.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtFilterBy.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtFilterBy.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtFilterBy.FocusedState.BorderColor = Color.CadetBlue;
            txtFilterBy.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtFilterBy.ForeColor = Color.Black;
            txtFilterBy.HoverState.BorderColor = Color.FromArgb(53, 41, 123);
            txtFilterBy.Location = new Point(274, 303);
            txtFilterBy.Margin = new Padding(4, 6, 4, 6);
            txtFilterBy.Name = "txtFilterBy";
            txtFilterBy.PasswordChar = '\0';
            txtFilterBy.PlaceholderText = "";
            txtFilterBy.SelectedText = "";
            txtFilterBy.ShadowDecoration.CustomizableEdges = customizableEdges11;
            txtFilterBy.Size = new Size(174, 36);
            txtFilterBy.TabIndex = 113;
            txtFilterBy.Visible = false;
            txtFilterBy.TextChanged += txtFilterBy_TextChanged;
            txtFilterBy.KeyPress += txtFilterBy_KeyPress;
            // 
            // cbGender
            // 
            cbGender.BackColor = Color.Transparent;
            cbGender.BorderColor = Color.FromArgb(7, 43, 71);
            cbGender.BorderRadius = 17;
            cbGender.BorderThickness = 2;
            cbGender.CustomizableEdges = customizableEdges12;
            cbGender.DrawMode = DrawMode.OwnerDrawFixed;
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGender.FocusedColor = Color.DarkCyan;
            cbGender.FocusedState.BorderColor = Color.DarkCyan;
            cbGender.Font = new Font("Segoe UI", 10F);
            cbGender.ForeColor = Color.FromArgb(68, 88, 112);
            cbGender.ItemHeight = 30;
            cbGender.Items.AddRange(new object[] { "Male", "Female" });
            cbGender.Location = new Point(274, 303);
            cbGender.Name = "cbGender";
            cbGender.ShadowDecoration.CustomizableEdges = customizableEdges13;
            cbGender.Size = new Size(174, 36);
            cbGender.TabIndex = 112;
            cbGender.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Comic Sans MS", 13F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(620, 308);
            label1.Name = "label1";
            label1.Size = new Size(82, 31);
            label1.TabIndex = 111;
            label1.Text = "Page :";
            // 
            // dgvList
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            dgvList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvList.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dgvList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvList.ColumnHeadersHeight = 4;
            dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvList.DefaultCellStyle = dataGridViewCellStyle6;
            dgvList.GridColor = Color.FromArgb(231, 229, 255);
            dgvList.Location = new Point(10, 365);
            dgvList.Name = "dgvList";
            dgvList.RowHeadersVisible = false;
            dgvList.RowHeadersWidth = 51;
            dgvList.Size = new Size(884, 396);
            dgvList.TabIndex = 110;
            dgvList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvList.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvList.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvList.ThemeStyle.BackColor = Color.White;
            dgvList.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvList.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvList.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvList.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvList.ThemeStyle.HeaderStyle.Height = 4;
            dgvList.ThemeStyle.ReadOnly = false;
            dgvList.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvList.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvList.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvList.ThemeStyle.RowsStyle.Height = 29;
            dgvList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvList.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 13F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(10, 764);
            label2.Name = "label2";
            label2.Size = new Size(157, 31);
            label2.TabIndex = 109;
            label2.Text = "# Records  :";
            // 
            // lblRecordsNum
            // 
            lblRecordsNum.AutoSize = true;
            lblRecordsNum.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold);
            lblRecordsNum.ForeColor = Color.SteelBlue;
            lblRecordsNum.Location = new Point(173, 764);
            lblRecordsNum.Name = "lblRecordsNum";
            lblRecordsNum.Size = new Size(89, 35);
            lblRecordsNum.TabIndex = 108;
            lblRecordsNum.Text = "[????]";
            // 
            // cbFilter
            // 
            cbFilter.BackColor = Color.Transparent;
            cbFilter.BorderColor = Color.FromArgb(7, 43, 71);
            cbFilter.BorderRadius = 17;
            cbFilter.BorderThickness = 2;
            cbFilter.CustomizableEdges = customizableEdges14;
            cbFilter.DrawMode = DrawMode.OwnerDrawFixed;
            cbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilter.FocusedColor = Color.FromArgb(94, 148, 255);
            cbFilter.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbFilter.Font = new Font("Segoe UI", 10F);
            cbFilter.ForeColor = Color.FromArgb(68, 88, 112);
            cbFilter.ItemHeight = 30;
            cbFilter.Items.AddRange(new object[] { "None", "UserID", "UserName" });
            cbFilter.Location = new Point(91, 303);
            cbFilter.Name = "cbFilter";
            cbFilter.ShadowDecoration.CustomizableEdges = customizableEdges15;
            cbFilter.Size = new Size(171, 36);
            cbFilter.TabIndex = 107;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Comic Sans MS", 13F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(3, 301);
            label3.Name = "label3";
            label3.Size = new Size(82, 31);
            label3.TabIndex = 106;
            label3.Text = "Filter:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.capacity;
            pictureBox1.Location = new Point(291, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(322, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 105;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 30.25F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(54, 69, 79);
            lblTitle.Location = new Point(14, 167);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(884, 76);
            lblTitle.TabIndex = 104;
            lblTitle.Text = "Manage Users";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // guna2Separator1
            // 
            guna2Separator1.FillColor = Color.SteelBlue;
            guna2Separator1.FillThickness = 5;
            guna2Separator1.Location = new Point(10, 246);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(892, 18);
            guna2Separator1.TabIndex = 103;
            // 
            // NUMPageNumber
            // 
            NUMPageNumber.BackColor = Color.Transparent;
            NUMPageNumber.BorderRadius = 15;
            NUMPageNumber.CustomizableEdges = customizableEdges16;
            NUMPageNumber.Font = new Font("Segoe UI", 9F);
            NUMPageNumber.Location = new Point(708, 308);
            NUMPageNumber.Margin = new Padding(3, 4, 3, 4);
            NUMPageNumber.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NUMPageNumber.Name = "NUMPageNumber";
            NUMPageNumber.ShadowDecoration.CustomizableEdges = customizableEdges17;
            NUMPageNumber.Size = new Size(101, 36);
            NUMPageNumber.TabIndex = 115;
            NUMPageNumber.UpDownButtonFillColor = Color.SteelBlue;
            NUMPageNumber.Value = new decimal(new int[] { 1, 0, 0, 0 });
            NUMPageNumber.ValueChanged += NUMPageNumber_ValueChanged;
            // 
            // btnAdd
            // 
            btnAdd.CheckedState.ImageSize = new Size(64, 64);
            btnAdd.HoverState.ImageSize = new Size(64, 64);
            btnAdd.Image = Properties.Resources.contact;
            btnAdd.ImageOffset = new Point(0, 0);
            btnAdd.ImageRotate = 0F;
            btnAdd.ImageSize = new Size(44, 44);
            btnAdd.Location = new Point(821, 291);
            btnAdd.Name = "btnAdd";
            btnAdd.PressedState.ImageSize = new Size(64, 64);
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btnAdd.Size = new Size(77, 66);
            btnAdd.TabIndex = 114;
            btnAdd.Click += btnAdd_Click;
            // 
            // cmsList
            // 
            cmsList.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmsList.ImageScalingSize = new Size(25, 25);
            cmsList.Items.AddRange(new ToolStripItem[] { miShowUserDetails, toolStripSeparator1, miEdit, miDelete, toolStripSeparator2, miChangePassword });
            cmsList.Name = "cmsList";
            cmsList.RenderStyle.ArrowColor = Color.FromArgb(151, 143, 255);
            cmsList.RenderStyle.BorderColor = Color.Gainsboro;
            cmsList.RenderStyle.ColorTable = null;
            cmsList.RenderStyle.RoundedEdges = true;
            cmsList.RenderStyle.SelectionArrowColor = Color.White;
            cmsList.RenderStyle.SelectionBackColor = Color.FromArgb(100, 88, 255);
            cmsList.RenderStyle.SelectionForeColor = Color.White;
            cmsList.RenderStyle.SeparatorColor = Color.Gainsboro;
            cmsList.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            cmsList.Size = new Size(269, 144);
            // 
            // miShowUserDetails
            // 
            miShowUserDetails.Image = Properties.Resources.id_card;
            miShowUserDetails.ImageAlign = ContentAlignment.MiddleLeft;
            miShowUserDetails.Name = "miShowUserDetails";
            miShowUserDetails.Size = new Size(268, 32);
            miShowUserDetails.Text = "     Show User Details";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(265, 6);
            // 
            // miEdit
            // 
            miEdit.Image = Properties.Resources.capacity;
            miEdit.Name = "miEdit";
            miEdit.Size = new Size(268, 32);
            miEdit.Text = "     Edit";
            miEdit.Click += miEdit_Click;
            // 
            // miDelete
            // 
            miDelete.Image = Properties.Resources.bin;
            miDelete.Name = "miDelete";
            miDelete.Size = new Size(268, 32);
            miDelete.Text = "     Delete";
            miDelete.Click += miDelete_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(265, 6);
            // 
            // miChangePassword
            // 
            miChangePassword.Image = Properties.Resources.reset_password;
            miChangePassword.Name = "miChangePassword";
            miChangePassword.Size = new Size(268, 32);
            miChangePassword.Text = "     Change Password";
            miChangePassword.Click += miChangePassword_Click;
            // 
            // frmListUserscs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 819);
            Controls.Add(NUMPageNumber);
            Controls.Add(btnAdd);
            Controls.Add(txtFilterBy);
            Controls.Add(cbGender);
            Controls.Add(label1);
            Controls.Add(dgvList);
            Controls.Add(label2);
            Controls.Add(lblRecordsNum);
            Controls.Add(cbFilter);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(lblTitle);
            Controls.Add(guna2Separator1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmListUserscs";
            Text = "frmListUserscs";
            Load += frmListUserscs_Load;
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUMPageNumber).EndInit();
            cmsList.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtFilterBy;
        private Guna.UI2.WinForms.Guna2ComboBox cbGender;
        private Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvList;
        private Label label2;
        private Label lblRecordsNum;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilter;
        private Label label3;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2NumericUpDown NUMPageNumber;
        private Guna.UI2.WinForms.Guna2ImageButton btnAdd;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsList;
        private ToolStripMenuItem miShowUserDetails;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem miEdit;
        private ToolStripMenuItem miDelete;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem miChangePassword;
    }
}