namespace Study_center.Payments
{
    partial class frmListPayments
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            txtFilterBy = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            NUMPageNumber = new Guna.UI2.WinForms.Guna2NumericUpDown();
            cmsList = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            miShowGroupsDetails = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            miShowStudentDetails = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            miShowSubjectGradeLevelDetails = new ToolStripMenuItem();
            label2 = new Label();
            lblRecordsNum = new Label();
            cbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            dgvList = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)NUMPageNumber).BeginInit();
            cmsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            SuspendLayout();
            // 
            // txtFilterBy
            // 
            txtFilterBy.BorderColor = Color.FromArgb(68, 88, 112);
            txtFilterBy.BorderRadius = 17;
            txtFilterBy.BorderThickness = 2;
            txtFilterBy.CustomizableEdges = customizableEdges1;
            txtFilterBy.DefaultText = "";
            txtFilterBy.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtFilterBy.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtFilterBy.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtFilterBy.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtFilterBy.FocusedState.BorderColor = Color.CadetBlue;
            txtFilterBy.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtFilterBy.ForeColor = Color.Black;
            txtFilterBy.HoverState.BorderColor = Color.FromArgb(53, 41, 123);
            txtFilterBy.Location = new Point(271, 317);
            txtFilterBy.Margin = new Padding(4, 6, 4, 6);
            txtFilterBy.Name = "txtFilterBy";
            txtFilterBy.PasswordChar = '\0';
            txtFilterBy.PlaceholderText = "";
            txtFilterBy.SelectedText = "";
            txtFilterBy.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtFilterBy.Size = new Size(174, 36);
            txtFilterBy.TabIndex = 102;
            txtFilterBy.Visible = false;
            txtFilterBy.TextChanged += txtFilterBy_TextChanged;
            txtFilterBy.KeyPress += txtFilterBy_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Comic Sans MS", 13F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(716, 315);
            label1.Name = "label1";
            label1.Size = new Size(82, 31);
            label1.TabIndex = 100;
            label1.Text = "Page :";
            // 
            // NUMPageNumber
            // 
            NUMPageNumber.BackColor = Color.Transparent;
            NUMPageNumber.BorderRadius = 15;
            NUMPageNumber.CustomizableEdges = customizableEdges3;
            NUMPageNumber.Font = new Font("Segoe UI", 9F);
            NUMPageNumber.Location = new Point(804, 315);
            NUMPageNumber.Margin = new Padding(3, 4, 3, 4);
            NUMPageNumber.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NUMPageNumber.Name = "NUMPageNumber";
            NUMPageNumber.ShadowDecoration.CustomizableEdges = customizableEdges4;
            NUMPageNumber.Size = new Size(101, 36);
            NUMPageNumber.TabIndex = 99;
            NUMPageNumber.UpDownButtonFillColor = Color.SteelBlue;
            NUMPageNumber.Value = new decimal(new int[] { 1, 0, 0, 0 });
            NUMPageNumber.ValueChanged += NUMPageNumber_ValueChanged;
            // 
            // cmsList
            // 
            cmsList.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmsList.ImageScalingSize = new Size(25, 25);
            cmsList.Items.AddRange(new ToolStripItem[] { miShowGroupsDetails, toolStripSeparator1, miShowStudentDetails, toolStripSeparator2, miShowSubjectGradeLevelDetails });
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
            cmsList.Size = new Size(396, 140);
            // 
            // miShowGroupsDetails
            // 
            miShowGroupsDetails.Image = Properties.Resources.meeting__1_;
            miShowGroupsDetails.ImageAlign = ContentAlignment.MiddleLeft;
            miShowGroupsDetails.Name = "miShowGroupsDetails";
            miShowGroupsDetails.Size = new Size(395, 32);
            miShowGroupsDetails.Text = "     Show Group Details";
            miShowGroupsDetails.Click += miShowGroupsDetails_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(392, 6);
            // 
            // miShowStudentDetails
            // 
            miShowStudentDetails.Image = Properties.Resources.id_card;
            miShowStudentDetails.Name = "miShowStudentDetails";
            miShowStudentDetails.Size = new Size(395, 32);
            miShowStudentDetails.Text = "     Show Student Details";
            miShowStudentDetails.Click += miShowStudentDetails_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(392, 6);
            // 
            // miShowSubjectGradeLevelDetails
            // 
            miShowSubjectGradeLevelDetails.Image = Properties.Resources.grade_level;
            miShowSubjectGradeLevelDetails.Name = "miShowSubjectGradeLevelDetails";
            miShowSubjectGradeLevelDetails.Size = new Size(395, 32);
            miShowSubjectGradeLevelDetails.Text = "     Show Subject Grade Level Details";
            miShowSubjectGradeLevelDetails.Click += miShowSubjectGradeLevelDetails_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 13F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 797);
            label2.Name = "label2";
            label2.Size = new Size(157, 31);
            label2.TabIndex = 93;
            label2.Text = "# Records  :";
            // 
            // lblRecordsNum
            // 
            lblRecordsNum.AutoSize = true;
            lblRecordsNum.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold);
            lblRecordsNum.ForeColor = Color.SteelBlue;
            lblRecordsNum.Location = new Point(175, 797);
            lblRecordsNum.Name = "lblRecordsNum";
            lblRecordsNum.Size = new Size(89, 35);
            lblRecordsNum.TabIndex = 92;
            lblRecordsNum.Text = "[????]";
            // 
            // cbFilter
            // 
            cbFilter.BackColor = Color.Transparent;
            cbFilter.BorderColor = Color.FromArgb(7, 43, 71);
            cbFilter.BorderRadius = 17;
            cbFilter.BorderThickness = 2;
            cbFilter.CustomizableEdges = customizableEdges5;
            cbFilter.DrawMode = DrawMode.OwnerDrawFixed;
            cbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilter.FocusedColor = Color.FromArgb(94, 148, 255);
            cbFilter.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbFilter.Font = new Font("Segoe UI", 10F);
            cbFilter.ForeColor = Color.FromArgb(68, 88, 112);
            cbFilter.ItemHeight = 30;
            cbFilter.Items.AddRange(new object[] { "None", "PaymentID", "StudentID", "GroupID" });
            cbFilter.Location = new Point(93, 317);
            cbFilter.Name = "cbFilter";
            cbFilter.ShadowDecoration.CustomizableEdges = customizableEdges6;
            cbFilter.Size = new Size(171, 36);
            cbFilter.TabIndex = 91;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Comic Sans MS", 13F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(5, 315);
            label3.Name = "label3";
            label3.Size = new Size(82, 31);
            label3.TabIndex = 90;
            label3.Text = "Filter:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.wallet__1_;
            pictureBox1.Location = new Point(283, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(322, 183);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 88;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 30.25F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(54, 69, 79);
            lblTitle.Location = new Point(0, 183);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(884, 76);
            lblTitle.TabIndex = 87;
            lblTitle.Text = "Manage Payments";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // guna2Separator1
            // 
            guna2Separator1.FillColor = Color.SteelBlue;
            guna2Separator1.FillThickness = 5;
            guna2Separator1.Location = new Point(12, 260);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(925, 19);
            guna2Separator1.TabIndex = 86;
            // 
            // dgvList
            // 
            dgvList.AllowUserToAddRows = false;
            dgvList.AllowUserToDeleteRows = false;
            dgvList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvList.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dgvList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumAquamarine;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvList.ColumnHeadersHeight = 30;
            dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvList.ContextMenuStrip = cmsList;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvList.DefaultCellStyle = dataGridViewCellStyle3;
            dgvList.GridColor = Color.FromArgb(231, 229, 255);
            dgvList.Location = new Point(12, 380);
            dgvList.Name = "dgvList";
            dgvList.RowHeadersVisible = false;
            dgvList.RowHeadersWidth = 30;
            dgvList.Size = new Size(893, 396);
            dgvList.TabIndex = 111;
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
            dgvList.ThemeStyle.HeaderStyle.Height = 30;
            dgvList.ThemeStyle.ReadOnly = false;
            dgvList.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvList.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvList.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvList.ThemeStyle.RowsStyle.Height = 29;
            dgvList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvList.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // frmListPayments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 963);
            Controls.Add(dgvList);
            Controls.Add(txtFilterBy);
            Controls.Add(label1);
            Controls.Add(NUMPageNumber);
            Controls.Add(label2);
            Controls.Add(lblRecordsNum);
            Controls.Add(cbFilter);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(lblTitle);
            Controls.Add(guna2Separator1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmListPayments";
            Text = "frmListPayments";
            Load += frmListPayments_Load;
            ((System.ComponentModel.ISupportInitialize)NUMPageNumber).EndInit();
            cmsList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtFilterBy;
        private Label label1;
        private Guna.UI2.WinForms.Guna2NumericUpDown NUMPageNumber;
        private Label label2;
        private Label lblRecordsNum;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilter;
        private Label label3;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsList;
        private ToolStripMenuItem miShowGroupsDetails;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem miShowStudentDetails;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem miShowSubjectGradeLevelDetails;
        private Guna.UI2.WinForms.Guna2DataGridView dgvList;
    }
}