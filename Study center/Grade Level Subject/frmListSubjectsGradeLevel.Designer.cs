namespace Study_center.Grade_Level_Subject
{
    partial class frmListSubjectsGradeLevel
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtFilterBy = new Guna.UI2.WinForms.Guna2TextBox();
            cbGradeLevels = new Guna.UI2.WinForms.Guna2ComboBox();
            label1 = new Label();
            NUMPageNumber = new Guna.UI2.WinForms.Guna2NumericUpDown();
            dgvList = new Guna.UI2.WinForms.Guna2DataGridView();
            cmsList = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            miShowSubjectsDetails = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            miEdit = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            miWhoTeachesIt = new ToolStripMenuItem();
            label2 = new Label();
            lblRecordsNum = new Label();
            cbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            label3 = new Label();
            btnAdd = new Guna.UI2.WinForms.Guna2ImageButton();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            cbSubjects = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)NUMPageNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            cmsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            txtFilterBy.Location = new Point(348, 312);
            txtFilterBy.Margin = new Padding(4, 6, 4, 6);
            txtFilterBy.Name = "txtFilterBy";
            txtFilterBy.PasswordChar = '\0';
            txtFilterBy.PlaceholderText = "";
            txtFilterBy.SelectedText = "";
            txtFilterBy.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtFilterBy.Size = new Size(235, 36);
            txtFilterBy.TabIndex = 115;
            txtFilterBy.Visible = false;
            txtFilterBy.TextChanged += txtFilterBy_TextChanged;
            txtFilterBy.KeyPress += txtFilterBy_KeyPress;
            // 
            // cbGradeLevels
            // 
            cbGradeLevels.BackColor = Color.Transparent;
            cbGradeLevels.BorderColor = Color.FromArgb(7, 43, 71);
            cbGradeLevels.BorderRadius = 17;
            cbGradeLevels.BorderThickness = 2;
            cbGradeLevels.CustomizableEdges = customizableEdges3;
            cbGradeLevels.DrawMode = DrawMode.OwnerDrawFixed;
            cbGradeLevels.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGradeLevels.FocusedColor = Color.DarkCyan;
            cbGradeLevels.FocusedState.BorderColor = Color.DarkCyan;
            cbGradeLevels.Font = new Font("Segoe UI", 10F);
            cbGradeLevels.ForeColor = Color.FromArgb(68, 88, 112);
            cbGradeLevels.ItemHeight = 30;
            cbGradeLevels.Items.AddRange(new object[] { "Male", "Female" });
            cbGradeLevels.Location = new Point(348, 312);
            cbGradeLevels.Name = "cbGradeLevels";
            cbGradeLevels.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cbGradeLevels.Size = new Size(235, 36);
            cbGradeLevels.TabIndex = 114;
            cbGradeLevels.Visible = false;
            cbGradeLevels.SelectedIndexChanged += cbGradeLevels_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Comic Sans MS", 13F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(636, 312);
            label1.Name = "label1";
            label1.Size = new Size(82, 31);
            label1.TabIndex = 113;
            label1.Text = "Page :";
            // 
            // NUMPageNumber
            // 
            NUMPageNumber.BackColor = Color.Transparent;
            NUMPageNumber.BorderRadius = 15;
            NUMPageNumber.CustomizableEdges = customizableEdges5;
            NUMPageNumber.Font = new Font("Segoe UI", 9F);
            NUMPageNumber.Location = new Point(724, 312);
            NUMPageNumber.Margin = new Padding(3, 4, 3, 4);
            NUMPageNumber.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NUMPageNumber.Name = "NUMPageNumber";
            NUMPageNumber.ShadowDecoration.CustomizableEdges = customizableEdges6;
            NUMPageNumber.Size = new Size(101, 36);
            NUMPageNumber.TabIndex = 112;
            NUMPageNumber.UpDownButtonFillColor = Color.SteelBlue;
            NUMPageNumber.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // dgvList
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvList.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dgvList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvList.ColumnHeadersHeight = 4;
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
            dgvList.Location = new Point(26, 369);
            dgvList.Name = "dgvList";
            dgvList.RowHeadersVisible = false;
            dgvList.RowHeadersWidth = 51;
            dgvList.Size = new Size(892, 396);
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
            // cmsList
            // 
            cmsList.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmsList.ImageScalingSize = new Size(25, 25);
            cmsList.Items.AddRange(new ToolStripItem[] { miShowSubjectsDetails, toolStripSeparator1, miEdit, toolStripSeparator2, miWhoTeachesIt });
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
            cmsList.Size = new Size(301, 112);
            // 
            // miShowSubjectsDetails
            // 
            miShowSubjectsDetails.Image = Properties.Resources.id_card;
            miShowSubjectsDetails.ImageAlign = ContentAlignment.MiddleLeft;
            miShowSubjectsDetails.Name = "miShowSubjectsDetails";
            miShowSubjectsDetails.Size = new Size(300, 32);
            miShowSubjectsDetails.Text = "     Show Subjects Details";
            miShowSubjectsDetails.Click += miShowSubjectsDetails_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(297, 6);
            // 
            // miEdit
            // 
            miEdit.Image = Properties.Resources.capacity;
            miEdit.Name = "miEdit";
            miEdit.Size = new Size(300, 32);
            miEdit.Text = "     Edit";
            miEdit.Click += miEdit_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(297, 6);
            // 
            // miWhoTeachesIt
            // 
            miWhoTeachesIt.Image = Properties.Resources.grade_level;
            miWhoTeachesIt.Name = "miWhoTeachesIt";
            miWhoTeachesIt.Size = new Size(300, 32);
            miWhoTeachesIt.Text = "     Who Teaches it?";
            miWhoTeachesIt.Click += miWhoTeachesIt_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 13F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(26, 787);
            label2.Name = "label2";
            label2.Size = new Size(157, 31);
            label2.TabIndex = 110;
            label2.Text = "# Records  :";
            // 
            // lblRecordsNum
            // 
            lblRecordsNum.AutoSize = true;
            lblRecordsNum.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold);
            lblRecordsNum.ForeColor = Color.SteelBlue;
            lblRecordsNum.Location = new Point(189, 787);
            lblRecordsNum.Name = "lblRecordsNum";
            lblRecordsNum.Size = new Size(89, 35);
            lblRecordsNum.TabIndex = 109;
            lblRecordsNum.Text = "[????]";
            // 
            // cbFilter
            // 
            cbFilter.BackColor = Color.Transparent;
            cbFilter.BorderColor = Color.FromArgb(7, 43, 71);
            cbFilter.BorderRadius = 17;
            cbFilter.BorderThickness = 2;
            cbFilter.CustomizableEdges = customizableEdges7;
            cbFilter.DrawMode = DrawMode.OwnerDrawFixed;
            cbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilter.FocusedColor = Color.FromArgb(94, 148, 255);
            cbFilter.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbFilter.Font = new Font("Segoe UI", 10F);
            cbFilter.ForeColor = Color.FromArgb(68, 88, 112);
            cbFilter.ItemHeight = 30;
            cbFilter.Items.AddRange(new object[] { "None", "Subject Grade Level ID", "Subject Name", "Grade Level" });
            cbFilter.Location = new Point(107, 307);
            cbFilter.Name = "cbFilter";
            cbFilter.ShadowDecoration.CustomizableEdges = customizableEdges8;
            cbFilter.Size = new Size(235, 36);
            cbFilter.TabIndex = 108;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Comic Sans MS", 13F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(19, 305);
            label3.Name = "label3";
            label3.Size = new Size(82, 31);
            label3.TabIndex = 107;
            label3.Text = "Filter:";
            // 
            // btnAdd
            // 
            btnAdd.CheckedState.ImageSize = new Size(64, 64);
            btnAdd.HoverState.ImageSize = new Size(64, 64);
            btnAdd.Image = Properties.Resources.add_subject1;
            btnAdd.ImageOffset = new Point(0, 0);
            btnAdd.ImageRotate = 0F;
            btnAdd.ImageSize = new Size(44, 44);
            btnAdd.Location = new Point(837, 295);
            btnAdd.Name = "btnAdd";
            btnAdd.PressedState.ImageSize = new Size(64, 64);
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges9;
            btnAdd.Size = new Size(77, 66);
            btnAdd.TabIndex = 106;
            btnAdd.Click += btnAdd_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.subjects;
            pictureBox1.Location = new Point(307, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(322, 183);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 105;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 30.25F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(54, 69, 79);
            lblTitle.Location = new Point(26, 171);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(884, 76);
            lblTitle.TabIndex = 104;
            lblTitle.Text = "Manage Subjects";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // guna2Separator1
            // 
            guna2Separator1.FillColor = Color.SteelBlue;
            guna2Separator1.FillThickness = 5;
            guna2Separator1.Location = new Point(26, 250);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(892, 18);
            guna2Separator1.TabIndex = 103;
            // 
            // cbSubjects
            // 
            cbSubjects.BackColor = Color.Transparent;
            cbSubjects.BorderColor = Color.FromArgb(7, 43, 71);
            cbSubjects.BorderRadius = 17;
            cbSubjects.BorderThickness = 2;
            cbSubjects.CustomizableEdges = customizableEdges10;
            cbSubjects.DrawMode = DrawMode.OwnerDrawFixed;
            cbSubjects.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSubjects.FocusedColor = Color.DarkCyan;
            cbSubjects.FocusedState.BorderColor = Color.DarkCyan;
            cbSubjects.Font = new Font("Segoe UI", 10F);
            cbSubjects.ForeColor = Color.FromArgb(68, 88, 112);
            cbSubjects.ItemHeight = 30;
            cbSubjects.Items.AddRange(new object[] { "Male", "Female" });
            cbSubjects.Location = new Point(348, 312);
            cbSubjects.Name = "cbSubjects";
            cbSubjects.ShadowDecoration.CustomizableEdges = customizableEdges11;
            cbSubjects.Size = new Size(235, 36);
            cbSubjects.TabIndex = 116;
            cbSubjects.Visible = false;
            cbSubjects.SelectedIndexChanged += cbSubjects_SelectedIndexChanged;
            // 
            // frmListSubjectsGradeLevel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 837);
            Controls.Add(cbSubjects);
            Controls.Add(txtFilterBy);
            Controls.Add(cbGradeLevels);
            Controls.Add(label1);
            Controls.Add(NUMPageNumber);
            Controls.Add(dgvList);
            Controls.Add(label2);
            Controls.Add(lblRecordsNum);
            Controls.Add(cbFilter);
            Controls.Add(label3);
            Controls.Add(btnAdd);
            Controls.Add(pictureBox1);
            Controls.Add(lblTitle);
            Controls.Add(guna2Separator1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmListSubjectsGradeLevel";
            Text = "frmListSubjectsGradeLevel";
            Load += frmListSubjectsGradeLevel_Load;
            ((System.ComponentModel.ISupportInitialize)NUMPageNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            cmsList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtFilterBy;
        private Guna.UI2.WinForms.Guna2ComboBox cbGradeLevels;
        private Label label1;
        private Guna.UI2.WinForms.Guna2NumericUpDown NUMPageNumber;
        private Guna.UI2.WinForms.Guna2DataGridView dgvList;
        private Label label2;
        private Label lblRecordsNum;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilter;
        private Label label3;
        private Guna.UI2.WinForms.Guna2ImageButton btnAdd;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2ComboBox cbSubjects;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsList;
        private ToolStripMenuItem miShowSubjectsDetails;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem miEdit;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem miWhoTeachesIt;
    }
}