namespace ProjectOOP_Fit_to_work
{
    partial class Register
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            FnameTextBox = new TextBox();
            MnameTextBox = new TextBox();
            LnameTextBox = new TextBox();
            FnameLbl = new Label();
            MnameLbl = new Label();
            LnameLbl = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            HeightLbl = new Label();
            label2 = new Label();
            AgeLbl = new Label();
            SexLbl = new Label();
            RMale = new RadioButton();
            Rfmale = new RadioButton();
            Age = new NumericUpDown();
            WeightKg = new NumericUpDown();
            CmHeight = new NumericUpDown();
            SabeBtn = new Button();
            UserRegistrationTxtOnly = new Label();
            ((System.ComponentModel.ISupportInitialize)Age).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WeightKg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CmHeight).BeginInit();
            SuspendLayout();
            // 
            // FnameTextBox
            // 
            FnameTextBox.Location = new Point(265, 85);
            FnameTextBox.Name = "FnameTextBox";
            FnameTextBox.Size = new Size(123, 23);
            FnameTextBox.TabIndex = 0;
            // 
            // MnameTextBox
            // 
            MnameTextBox.Location = new Point(265, 114);
            MnameTextBox.Name = "MnameTextBox";
            MnameTextBox.Size = new Size(123, 23);
            MnameTextBox.TabIndex = 1;
            // 
            // LnameTextBox
            // 
            LnameTextBox.Location = new Point(265, 143);
            LnameTextBox.Name = "LnameTextBox";
            LnameTextBox.Size = new Size(123, 23);
            LnameTextBox.TabIndex = 2;
            // 
            // FnameLbl
            // 
            FnameLbl.AutoSize = true;
            FnameLbl.Location = new Point(165, 93);
            FnameLbl.Name = "FnameLbl";
            FnameLbl.Size = new Size(67, 15);
            FnameLbl.TabIndex = 3;
            FnameLbl.Text = "First Name:";
            FnameLbl.Click += label1_Click;
            // 
            // MnameLbl
            // 
            MnameLbl.AutoSize = true;
            MnameLbl.Location = new Point(165, 122);
            MnameLbl.Name = "MnameLbl";
            MnameLbl.Size = new Size(82, 15);
            MnameLbl.TabIndex = 4;
            MnameLbl.Text = "Middle Name:";
            // 
            // LnameLbl
            // 
            LnameLbl.AutoSize = true;
            LnameLbl.Location = new Point(166, 151);
            LnameLbl.Name = "LnameLbl";
            LnameLbl.Size = new Size(66, 15);
            LnameLbl.TabIndex = 5;
            LnameLbl.Text = "Last Name:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // HeightLbl
            // 
            HeightLbl.AutoSize = true;
            HeightLbl.Location = new Point(165, 277);
            HeightLbl.Name = "HeightLbl";
            HeightLbl.Size = new Size(90, 15);
            HeightLbl.TabIndex = 9;
            HeightLbl.Text = "Height (meters)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(166, 242);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 10;
            label2.Text = "Weight: (Kg)";
            // 
            // AgeLbl
            // 
            AgeLbl.AutoSize = true;
            AgeLbl.Location = new Point(183, 180);
            AgeLbl.Name = "AgeLbl";
            AgeLbl.Size = new Size(31, 15);
            AgeLbl.TabIndex = 12;
            AgeLbl.Text = "Age:";
            // 
            // SexLbl
            // 
            SexLbl.AutoSize = true;
            SexLbl.Location = new Point(183, 211);
            SexLbl.Name = "SexLbl";
            SexLbl.Size = new Size(28, 15);
            SexLbl.TabIndex = 13;
            SexLbl.Text = "Sex:";
            // 
            // RMale
            // 
            RMale.AutoSize = true;
            RMale.Location = new Point(265, 209);
            RMale.Name = "RMale";
            RMale.Size = new Size(51, 19);
            RMale.TabIndex = 14;
            RMale.TabStop = true;
            RMale.Text = "Male";
            RMale.UseVisualStyleBackColor = true;
            RMale.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // Rfmale
            // 
            Rfmale.AutoSize = true;
            Rfmale.Location = new Point(325, 209);
            Rfmale.Name = "Rfmale";
            Rfmale.Size = new Size(63, 19);
            Rfmale.TabIndex = 15;
            Rfmale.TabStop = true;
            Rfmale.Text = "Female";
            Rfmale.UseVisualStyleBackColor = true;
            // 
            // Age
            // 
            Age.Location = new Point(268, 178);
            Age.Name = "Age";
            Age.Size = new Size(120, 23);
            Age.TabIndex = 16;
            // 
            // WeightKg
            // 
            WeightKg.Location = new Point(265, 234);
            WeightKg.Name = "WeightKg";
            WeightKg.Size = new Size(120, 23);
            WeightKg.TabIndex = 17;
            WeightKg.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // CmHeight
            // 
            CmHeight.Location = new Point(265, 269);
            CmHeight.Name = "CmHeight";
            CmHeight.Size = new Size(120, 23);
            CmHeight.TabIndex = 18;
            // 
            // SabeBtn
            // 
            SabeBtn.BackColor = SystemColors.Highlight;
            SabeBtn.FlatStyle = FlatStyle.Flat;
            SabeBtn.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SabeBtn.ForeColor = SystemColors.ButtonHighlight;
            SabeBtn.Location = new Point(265, 311);
            SabeBtn.Name = "SabeBtn";
            SabeBtn.Size = new Size(120, 36);
            SabeBtn.TabIndex = 19;
            SabeBtn.Text = "Register";
            SabeBtn.UseVisualStyleBackColor = false;
            // 
            // UserRegistrationTxtOnly
            // 
            UserRegistrationTxtOnly.AutoSize = true;
            UserRegistrationTxtOnly.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            UserRegistrationTxtOnly.Location = new Point(3, 9);
            UserRegistrationTxtOnly.Name = "UserRegistrationTxtOnly";
            UserRegistrationTxtOnly.Size = new Size(211, 32);
            UserRegistrationTxtOnly.TabIndex = 20;
            UserRegistrationTxtOnly.Text = "User Registration";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(641, 398);
            Controls.Add(UserRegistrationTxtOnly);
            Controls.Add(SabeBtn);
            Controls.Add(CmHeight);
            Controls.Add(WeightKg);
            Controls.Add(Age);
            Controls.Add(Rfmale);
            Controls.Add(RMale);
            Controls.Add(SexLbl);
            Controls.Add(AgeLbl);
            Controls.Add(label2);
            Controls.Add(HeightLbl);
            Controls.Add(LnameLbl);
            Controls.Add(MnameLbl);
            Controls.Add(FnameLbl);
            Controls.Add(LnameTextBox);
            Controls.Add(MnameTextBox);
            Controls.Add(FnameTextBox);
            Name = "Register";
            Text = "Form1";
            Load += this.Register_Load;
            ((System.ComponentModel.ISupportInitialize)Age).EndInit();
            ((System.ComponentModel.ISupportInitialize)WeightKg).EndInit();
            ((System.ComponentModel.ISupportInitialize)CmHeight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox FnameTextBox;
        private TextBox MnameTextBox;
        private TextBox LnameTextBox;
        private Label FnameLbl;
        private Label MnameLbl;
        private Label LnameLbl;
        private ContextMenuStrip contextMenuStrip1;
        private Label HeightLbl;
        private Label label2;
        private Label AgeLbl;
        private Label SexLbl;
        private RadioButton RMale;
        private RadioButton Rfmale;
        private NumericUpDown Age;
        private NumericUpDown WeightKg;
        private NumericUpDown CmHeight;
        private Button SabeBtn;
        private Label UserRegistrationTxtOnly;
    }
}
