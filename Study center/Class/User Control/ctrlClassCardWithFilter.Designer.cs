namespace Study_center.Class.User_Control
{
    partial class ctrlClassCardWithFilter
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
            ctrlClassGard1 = new ctrlClassGard();
            ctrlFilter1 = new Global_User_Controls.ctrlFilter();
            SuspendLayout();
            // 
            // ctrlClassGard1
            // 
            ctrlClassGard1.Location = new Point(0, 168);
            ctrlClassGard1.Name = "ctrlClassGard1";
            ctrlClassGard1.Size = new Size(891, 187);
            ctrlClassGard1.TabIndex = 5;
            // 
            // ctrlFilter1
            // 
            ctrlFilter1.FilterEnabled = true;
            ctrlFilter1.Location = new Point(0, 0);
            ctrlFilter1.Name = "ctrlFilter1";
            ctrlFilter1.Size = new Size(891, 150);
            ctrlFilter1.TabIndex = 6;
            ctrlFilter1.SearchClicked += ctrlFilter1_SearchClicked;
            ctrlFilter1.AddClicked += ctrlFilter1_AddClicked;
            // 
            // ctrlClassCardWithFilter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ctrlFilter1);
            Controls.Add(ctrlClassGard1);
            Name = "ctrlClassCardWithFilter";
            Size = new Size(891, 355);
            ResumeLayout(false);
        }

        #endregion
        private ctrlClassGard ctrlClassGard1;
        private Global_User_Controls.ctrlFilter ctrlFilter1;
    }
}
