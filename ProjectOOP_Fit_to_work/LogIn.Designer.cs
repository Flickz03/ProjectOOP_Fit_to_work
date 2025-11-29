namespace ProjectOOP_Fit_to_work
{
    partial class LogIn
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
            EmailTextBox = new TextBox();
            UserNameBox = new TextBox();
            PassNameBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            LogInBtn = new Button();
            CreateAccBtn = new Button();
            UserCreationtTxtOnly = new Label();
            SuspendLayout();
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(266, 65);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(100, 23);
            EmailTextBox.TabIndex = 0;
            // 
            // UserNameBox
            // 
            UserNameBox.Location = new Point(266, 109);
            UserNameBox.Name = "UserNameBox";
            UserNameBox.Size = new Size(100, 23);
            UserNameBox.TabIndex = 1;
            // 
            // PassNameBox
            // 
            PassNameBox.Location = new Point(266, 154);
            PassNameBox.Name = "PassNameBox";
            PassNameBox.Size = new Size(100, 23);
            PassNameBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(163, 117);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 3;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(163, 73);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 4;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(163, 162);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 5;
            label3.Text = "Password:";
            // 
            // LogInBtn
            // 
            LogInBtn.BackColor = SystemColors.Highlight;
            LogInBtn.BackgroundImageLayout = ImageLayout.Center;
            LogInBtn.FlatStyle = FlatStyle.Flat;
            LogInBtn.ForeColor = SystemColors.ButtonFace;
            LogInBtn.Location = new Point(266, 183);
            LogInBtn.Name = "LogInBtn";
            LogInBtn.Size = new Size(100, 37);
            LogInBtn.TabIndex = 6;
            LogInBtn.Text = "Log In";
            LogInBtn.UseVisualStyleBackColor = false;
            // 
            // CreateAccBtn
            // 
            CreateAccBtn.FlatAppearance.BorderSize = 5;
            CreateAccBtn.ForeColor = Color.Green;
            CreateAccBtn.Location = new Point(266, 235);
            CreateAccBtn.Name = "CreateAccBtn";
            CreateAccBtn.Size = new Size(100, 23);
            CreateAccBtn.TabIndex = 7;
            CreateAccBtn.Text = "Create Account";
            CreateAccBtn.UseVisualStyleBackColor = true;
            // 
            // UserCreationtTxtOnly
            // 
            UserCreationtTxtOnly.AutoSize = true;
            UserCreationtTxtOnly.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserCreationtTxtOnly.ForeColor = SystemColors.ActiveCaptionText;
            UserCreationtTxtOnly.Location = new Point(1, 9);
            UserCreationtTxtOnly.Name = "UserCreationtTxtOnly";
            UserCreationtTxtOnly.Size = new Size(169, 32);
            UserCreationtTxtOnly.TabIndex = 8;
            UserCreationtTxtOnly.Text = "User Creation";
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 298);
            Controls.Add(UserCreationtTxtOnly);
            Controls.Add(CreateAccBtn);
            Controls.Add(LogInBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PassNameBox);
            Controls.Add(UserNameBox);
            Controls.Add(EmailTextBox);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "LogIn";
            Text = "LogIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox EmailTextBox;
        private TextBox UserNameBox;
        private TextBox PassNameBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button LogInBtn;
        private Button CreateAccBtn;
        private Label UserCreationtTxtOnly;
    }
}