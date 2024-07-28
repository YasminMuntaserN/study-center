namespace Study_center.Person.User_Controls
{
    partial class ctrlPersonCardWithFilter
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            gbFilter = new Guna.UI2.WinForms.Guna2GroupBox();
            btnSearch = new Guna.UI2.WinForms.Guna2ImageButton();
            btnAdd = new Guna.UI2.WinForms.Guna2ImageButton();
            cbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            txtFilterValue = new Guna.UI2.WinForms.Guna2TextBox();
            label12 = new Label();
            ctrlPersonCard1 = new ctrlPersonCard();
            errorProvider1 = new ErrorProvider(components);
            gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // gbFilter
            // 
            gbFilter.Controls.Add(btnSearch);
            gbFilter.Controls.Add(btnAdd);
            gbFilter.Controls.Add(cbFilter);
            gbFilter.Controls.Add(txtFilterValue);
            gbFilter.Controls.Add(label12);
            gbFilter.CustomBorderColor = Color.FromArgb(54, 69, 79);
            gbFilter.CustomizableEdges = customizableEdges7;
            gbFilter.Font = new Font("Segoe UI Emoji", 16.2F, FontStyle.Bold);
            gbFilter.ForeColor = Color.FromArgb(125, 137, 149);
            gbFilter.Location = new Point(0, 0);
            gbFilter.Name = "gbFilter";
            gbFilter.ShadowDecoration.CustomizableEdges = customizableEdges8;
            gbFilter.Size = new Size(887, 148);
            gbFilter.TabIndex = 1;
            gbFilter.Text = "Filter";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Transparent;
            btnSearch.CheckedState.ImageSize = new Size(64, 64);
            btnSearch.HoverState.ImageSize = new Size(64, 64);
            btnSearch.Image = Properties.Resources.user_avatar__4_;
            btnSearch.ImageOffset = new Point(0, 0);
            btnSearch.ImageRotate = 0F;
            btnSearch.ImageSize = new Size(44, 44);
            btnSearch.Location = new Point(685, 58);
            btnSearch.Name = "btnSearch";
            btnSearch.PressedState.ImageSize = new Size(64, 64);
            btnSearch.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnSearch.Size = new Size(64, 50);
            btnSearch.TabIndex = 47;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Transparent;
            btnAdd.CheckedState.ImageSize = new Size(64, 64);
            btnAdd.HoverState.ImageSize = new Size(64, 64);
            btnAdd.Image = Properties.Resources.contact;
            btnAdd.ImageOffset = new Point(0, 0);
            btnAdd.ImageRotate = 0F;
            btnAdd.ImageSize = new Size(44, 44);
            btnAdd.Location = new Point(755, 58);
            btnAdd.Name = "btnAdd";
            btnAdd.PressedState.ImageSize = new Size(64, 64);
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAdd.Size = new Size(64, 50);
            btnAdd.TabIndex = 46;
            btnAdd.Click += btnAdd_Click;
            // 
            // cbFilter
            // 
            cbFilter.BackColor = Color.Transparent;
            cbFilter.BorderColor = Color.FromArgb(7, 43, 71);
            cbFilter.BorderRadius = 17;
            cbFilter.CustomizableEdges = customizableEdges3;
            cbFilter.DrawMode = DrawMode.OwnerDrawFixed;
            cbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilter.FocusedColor = Color.CadetBlue;
            cbFilter.FocusedState.BorderColor = Color.CadetBlue;
            cbFilter.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            cbFilter.ForeColor = Color.Black;
            cbFilter.ItemHeight = 30;
            cbFilter.Items.AddRange(new object[] { "PersonID" });
            cbFilter.Location = new Point(135, 70);
            cbFilter.Name = "cbFilter";
            cbFilter.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cbFilter.Size = new Size(175, 36);
            cbFilter.TabIndex = 43;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // txtFilterValue
            // 
            txtFilterValue.BackColor = Color.White;
            txtFilterValue.BorderColor = Color.FromArgb(7, 43, 71);
            txtFilterValue.BorderRadius = 17;
            txtFilterValue.CustomizableEdges = customizableEdges5;
            txtFilterValue.DefaultText = "";
            txtFilterValue.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtFilterValue.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtFilterValue.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtFilterValue.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtFilterValue.FocusedState.BorderColor = Color.CadetBlue;
            txtFilterValue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtFilterValue.ForeColor = Color.Black;
            txtFilterValue.HoverState.BorderColor = Color.FromArgb(53, 41, 123);
            txtFilterValue.Location = new Point(333, 67);
            txtFilterValue.Margin = new Padding(4, 6, 4, 6);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.PasswordChar = '\0';
            txtFilterValue.PlaceholderForeColor = Color.Black;
            txtFilterValue.PlaceholderText = "";
            txtFilterValue.SelectedText = "";
            txtFilterValue.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtFilterValue.Size = new Size(215, 39);
            txtFilterValue.TabIndex = 42;
            txtFilterValue.Visible = false;
            txtFilterValue.KeyPress += txtFilterValue_KeyPress;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Comic Sans MS", 13F, FontStyle.Bold);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(47, 67);
            label12.Name = "label12";
            label12.Size = new Size(82, 31);
            label12.TabIndex = 41;
            label12.Text = "Filter:";
            // 
            // ctrlPersonCard1
            // 
            ctrlPersonCard1.Location = new Point(0, 164);
            ctrlPersonCard1.Name = "ctrlPersonCard1";
            ctrlPersonCard1.Size = new Size(887, 336);
            ctrlPersonCard1.TabIndex = 2;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ctrlPersonCardWithFilter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ctrlPersonCard1);
            Controls.Add(gbFilter);
            Name = "ctrlPersonCardWithFilter";
            Size = new Size(888, 500);
            gbFilter.ResumeLayout(false);
            gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gbFilter;
        private Label label12;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterValue;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilter;
        private ctrlPersonCard ctrlPersonCard1;
        private Guna.UI2.WinForms.Guna2ImageButton btnSearch;
        private Guna.UI2.WinForms.Guna2ImageButton btnAdd;
        private ErrorProvider errorProvider1;
    }
}
