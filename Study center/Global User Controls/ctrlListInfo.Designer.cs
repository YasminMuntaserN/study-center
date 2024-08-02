namespace Study_center.Global_User_Controls
{
    partial class ctrlListInfo
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            dgvList = new Guna.UI2.WinForms.Guna2DataGridView();
            lblListName = new Label();
            label2 = new Label();
            lblRecordsNum = new Label();
            btnaAdd = new Guna.UI2.WinForms.Guna2ImageButton();
            guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            guna2GroupBox1.Controls.Add(dgvList);
            guna2GroupBox1.Controls.Add(lblListName);
            guna2GroupBox1.CustomizableEdges = customizableEdges1;
            guna2GroupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2GroupBox1.ForeColor = Color.Black;
            guna2GroupBox1.Location = new Point(0, 71);
            guna2GroupBox1.Name = "guna2GroupBox1";
            guna2GroupBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2GroupBox1.Size = new Size(924, 337);
            guna2GroupBox1.TabIndex = 54;
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvList.DefaultCellStyle = dataGridViewCellStyle3;
            dgvList.GridColor = Color.FromArgb(231, 229, 255);
            dgvList.Location = new Point(3, 43);
            dgvList.Name = "dgvList";
            dgvList.RowHeadersVisible = false;
            dgvList.RowHeadersWidth = 30;
            dgvList.Size = new Size(918, 291);
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
            dgvList.CellContentClick += dgvList_CellContentClick_1;
            // 
            // lblListName
            // 
            lblListName.BackColor = Color.Transparent;
            lblListName.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            lblListName.Location = new Point(0, 0);
            lblListName.Name = "lblListName";
            lblListName.Size = new Size(650, 40);
            lblListName.TabIndex = 52;
            lblListName.Text = "List Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 13F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(3, 411);
            label2.Name = "label2";
            label2.Size = new Size(157, 31);
            label2.TabIndex = 61;
            label2.Text = "# Records  :";
            // 
            // lblRecordsNum
            // 
            lblRecordsNum.AutoSize = true;
            lblRecordsNum.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold);
            lblRecordsNum.ForeColor = Color.DarkCyan;
            lblRecordsNum.Location = new Point(166, 411);
            lblRecordsNum.Name = "lblRecordsNum";
            lblRecordsNum.Size = new Size(89, 35);
            lblRecordsNum.TabIndex = 60;
            lblRecordsNum.Text = "[????]";
            // 
            // btnaAdd
            // 
            btnaAdd.CheckedState.ImageSize = new Size(64, 64);
            btnaAdd.HoverState.ImageSize = new Size(64, 64);
            btnaAdd.Image = Properties.Resources.add;
            btnaAdd.ImageOffset = new Point(0, 0);
            btnaAdd.ImageRotate = 0F;
            btnaAdd.Location = new Point(812, 0);
            btnaAdd.Name = "btnaAdd";
            btnaAdd.PressedState.ImageSize = new Size(64, 64);
            btnaAdd.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnaAdd.Size = new Size(80, 68);
            btnaAdd.TabIndex = 62;
            btnaAdd.Click += btnaAdd_Click;
            // 
            // ctrlListInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnaAdd);
            Controls.Add(label2);
            Controls.Add(lblRecordsNum);
            Controls.Add(guna2GroupBox1);
            Name = "ctrlListInfo";
            Size = new Size(924, 469);
            guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Label lblListName;
        private Label label2;
        private Label lblRecordsNum;
        private Guna.UI2.WinForms.Guna2ImageButton btnaAdd;
        private Guna.UI2.WinForms.Guna2DataGridView dgvList;
    }
}
