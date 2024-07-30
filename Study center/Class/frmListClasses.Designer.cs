namespace Study_center.Class
{
    partial class frmListClasses
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
            txtFilterBy = new Guna.UI2.WinForms.Guna2TextBox();
            cbClasses = new Guna.UI2.WinForms.Guna2ComboBox();
            label1 = new Label();
            NUMPageNumber = new Guna.UI2.WinForms.Guna2NumericUpDown();
            dgvList = new Guna.UI2.WinForms.Guna2DataGridView();
            label2 = new Label();
            lblRecordsNum = new Label();
            cbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            label3 = new Label();
            btnAdd = new Guna.UI2.WinForms.Guna2ImageButton();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            cmsList = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            miShowClassDetails = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            miEdit = new ToolStripMenuItem();
            miAddGroup = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            miWhoTeachesIt = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)NUMPageNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            cmsList.SuspendLayout();
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
            txtFilterBy.Location = new Point(337, 304);
            txtFilterBy.Margin = new Padding(4, 6, 4, 6);
            txtFilterBy.Name = "txtFilterBy";
            txtFilterBy.PasswordChar = '\0';
            txtFilterBy.PlaceholderText = "";
            txtFilterBy.SelectedText = "";
            txtFilterBy.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtFilterBy.Size = new Size(235, 36);
            txtFilterBy.TabIndex = 129;
            txtFilterBy.Visible = false;
            txtFilterBy.TextChanged += txtFilterBy_TextChanged;
            txtFilterBy.KeyPress += txtFilterBy_KeyPress;
            // 
            // cbClasses
            // 
            cbClasses.BackColor = Color.Transparent;
            cbClasses.BorderColor = Color.FromArgb(7, 43, 71);
            cbClasses.BorderRadius = 17;
            cbClasses.BorderThickness = 2;
            cbClasses.CustomizableEdges = customizableEdges3;
            cbClasses.DrawMode = DrawMode.OwnerDrawFixed;
            cbClasses.DropDownStyle = ComboBoxStyle.DropDownList;
            cbClasses.FocusedColor = Color.DarkCyan;
            cbClasses.FocusedState.BorderColor = Color.DarkCyan;
            cbClasses.Font = new Font("Segoe UI", 10F);
            cbClasses.ForeColor = Color.FromArgb(68, 88, 112);
            cbClasses.ItemHeight = 30;
            cbClasses.Items.AddRange(new object[] { "Male", "Female" });
            cbClasses.Location = new Point(336, 304);
            cbClasses.Name = "cbClasses";
            cbClasses.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cbClasses.Size = new Size(235, 36);
            cbClasses.TabIndex = 128;
            cbClasses.Visible = false;
            cbClasses.SelectedIndexChanged += cbClasses_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Comic Sans MS", 13F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(630, 306);
            label1.Name = "label1";
            label1.Size = new Size(82, 31);
            label1.TabIndex = 127;
            label1.Text = "Page :";
            // 
            // NUMPageNumber
            // 
            NUMPageNumber.BackColor = Color.Transparent;
            NUMPageNumber.BorderRadius = 15;
            NUMPageNumber.CustomizableEdges = customizableEdges5;
            NUMPageNumber.Font = new Font("Segoe UI", 9F);
            NUMPageNumber.Location = new Point(718, 306);
            NUMPageNumber.Margin = new Padding(3, 4, 3, 4);
            NUMPageNumber.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NUMPageNumber.Name = "NUMPageNumber";
            NUMPageNumber.ShadowDecoration.CustomizableEdges = customizableEdges6;
            NUMPageNumber.Size = new Size(101, 36);
            NUMPageNumber.TabIndex = 126;
            NUMPageNumber.UpDownButtonFillColor = Color.SteelBlue;
            NUMPageNumber.Value = new decimal(new int[] { 1, 0, 0, 0 });
            NUMPageNumber.ValueChanged += NUMPageNumber_ValueChanged;
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
            dgvList.Location = new Point(14, 368);
            dgvList.Name = "dgvList";
            dgvList.RowHeadersVisible = false;
            dgvList.RowHeadersWidth = 51;
            dgvList.Size = new Size(892, 396);
            dgvList.TabIndex = 125;
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
            label2.Location = new Point(14, 786);
            label2.Name = "label2";
            label2.Size = new Size(157, 31);
            label2.TabIndex = 124;
            label2.Text = "# Records  :";
            // 
            // lblRecordsNum
            // 
            lblRecordsNum.AutoSize = true;
            lblRecordsNum.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold);
            lblRecordsNum.ForeColor = Color.SteelBlue;
            lblRecordsNum.Location = new Point(177, 786);
            lblRecordsNum.Name = "lblRecordsNum";
            lblRecordsNum.Size = new Size(89, 35);
            lblRecordsNum.TabIndex = 123;
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
            cbFilter.Items.AddRange(new object[] { "None", "Class ID", "Class Name" });
            cbFilter.Location = new Point(95, 306);
            cbFilter.Name = "cbFilter";
            cbFilter.ShadowDecoration.CustomizableEdges = customizableEdges8;
            cbFilter.Size = new Size(235, 36);
            cbFilter.TabIndex = 122;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Comic Sans MS", 13F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(7, 304);
            label3.Name = "label3";
            label3.Size = new Size(82, 31);
            label3.TabIndex = 121;
            label3.Text = "Filter:";
            // 
            // btnAdd
            // 
            btnAdd.CheckedState.ImageSize = new Size(64, 64);
            btnAdd.HoverState.ImageSize = new Size(64, 64);
            btnAdd.Image = Properties.Resources.classes_blue_64;
            btnAdd.ImageOffset = new Point(0, 0);
            btnAdd.ImageRotate = 0F;
            btnAdd.ImageSize = new Size(54, 54);
            btnAdd.Location = new Point(825, 273);
            btnAdd.Name = "btnAdd";
            btnAdd.PressedState.ImageSize = new Size(64, 64);
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges9;
            btnAdd.Size = new Size(77, 87);
            btnAdd.TabIndex = 120;
            btnAdd.Click += btnAdd_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.teacher__1_;
            pictureBox1.Location = new Point(295, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(322, 183);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 119;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 30.25F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(54, 69, 79);
            lblTitle.Location = new Point(14, 170);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(884, 76);
            lblTitle.TabIndex = 118;
            lblTitle.Text = "Manage Classes";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Click += lblTitle_Click;
            // 
            // guna2Separator1
            // 
            guna2Separator1.FillColor = Color.SteelBlue;
            guna2Separator1.FillThickness = 5;
            guna2Separator1.Location = new Point(14, 249);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(892, 18);
            guna2Separator1.TabIndex = 117;
            // 
            // cmsList
            // 
            cmsList.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmsList.ImageScalingSize = new Size(25, 25);
            cmsList.Items.AddRange(new ToolStripItem[] { miShowClassDetails, toolStripSeparator1, miEdit, miAddGroup, toolStripSeparator2, miWhoTeachesIt });
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
            cmsList.Size = new Size(399, 144);
            // 
            // miShowClassDetails
            // 
            miShowClassDetails.Image = Properties.Resources.id_card;
            miShowClassDetails.ImageAlign = ContentAlignment.MiddleLeft;
            miShowClassDetails.Name = "miShowClassDetails";
            miShowClassDetails.Size = new Size(398, 32);
            miShowClassDetails.Text = "     Show Class Details";
            miShowClassDetails.Click += miShowClassDetails_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(395, 6);
            // 
            // miEdit
            // 
            miEdit.Image = Properties.Resources.capacity;
            miEdit.Name = "miEdit";
            miEdit.Size = new Size(398, 32);
            miEdit.Text = "     Edit";
            miEdit.Click += miEdit_Click;
            // 
            // miAddGroup
            // 
            miAddGroup.Image = Properties.Resources.add_user;
            miAddGroup.Name = "miAddGroup";
            miAddGroup.Size = new Size(398, 32);
            miAddGroup.Text = "     Add Group";
            miAddGroup.Click += miAddGroup_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(395, 6);
            // 
            // miWhoTeachesIt
            // 
            miWhoTeachesIt.Image = Properties.Resources.classes_blue_64;
            miWhoTeachesIt.Name = "miWhoTeachesIt";
            miWhoTeachesIt.Size = new Size(398, 32);
            miWhoTeachesIt.Text = "     show Groups and Who Teaches it?";
            miWhoTeachesIt.Click += miWhoTeachesIt_Click;
            // 
            // frmListClasses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 826);
            Controls.Add(txtFilterBy);
            Controls.Add(cbClasses);
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
            Name = "frmListClasses";
            Text = "frmListClasses";
            Load += frmListClasses_Load;
            ((System.ComponentModel.ISupportInitialize)NUMPageNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            cmsList.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cbSubjects;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterBy;
        private Guna.UI2.WinForms.Guna2ComboBox cbClasses;
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
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsList;
        private ToolStripMenuItem miShowClassDetails;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem miEdit;
        private ToolStripMenuItem miAddGroup;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem miWhoTeachesIt;
    }
}