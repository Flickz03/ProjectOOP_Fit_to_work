namespace ProjectOOP_Fit_to_work
{
    partial class Form1
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            Fname = new Label();
            Mname = new Label();
            Lname = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            Weight = new TextBox();
            Height = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox6 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            RMale = new RadioButton();
            Rfmale = new RadioButton();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(216, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(216, 115);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(216, 144);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 2;
            // 
            // Fname
            // 
            Fname.AutoSize = true;
            Fname.Location = new Point(116, 94);
            Fname.Name = "Fname";
            Fname.Size = new Size(64, 15);
            Fname.TabIndex = 3;
            Fname.Text = "First Name";
            Fname.Click += label1_Click;
            // 
            // Mname
            // 
            Mname.AutoSize = true;
            Mname.Location = new Point(116, 123);
            Mname.Name = "Mname";
            Mname.Size = new Size(79, 15);
            Mname.TabIndex = 4;
            Mname.Text = "Middle Name";
            // 
            // Lname
            // 
            Lname.AutoSize = true;
            Lname.Location = new Point(117, 152);
            Lname.Name = "Lname";
            Lname.Size = new Size(63, 15);
            Lname.TabIndex = 5;
            Lname.Text = "Last Name";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Weight
            // 
            Weight.Location = new Point(216, 241);
            Weight.Name = "Weight";
            Weight.Size = new Size(100, 23);
            Weight.TabIndex = 7;
            // 
            // Height
            // 
            Height.Location = new Point(216, 270);
            Height.Name = "Height";
            Height.Size = new Size(100, 23);
            Height.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 273);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 9;
            label1.Text = "Height in cm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(117, 249);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 10;
            label2.Text = "Weight";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(216, 173);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(134, 181);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 12;
            label3.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(134, 208);
            label4.Name = "label4";
            label4.Size = new Size(25, 15);
            label4.TabIndex = 13;
            label4.Text = "Sex";
            // 
            // RMale
            // 
            RMale.AutoSize = true;
            RMale.Location = new Point(201, 208);
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
            Rfmale.Location = new Point(258, 208);
            Rfmale.Name = "Rfmale";
            Rfmale.Size = new Size(63, 19);
            Rfmale.TabIndex = 15;
            Rfmale.TabStop = true;
            Rfmale.Text = "Female";
            Rfmale.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Rfmale);
            Controls.Add(RMale);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox6);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Height);
            Controls.Add(Weight);
            Controls.Add(Lname);
            Controls.Add(Mname);
            Controls.Add(Fname);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label Fname;
        private Label Mname;
        private Label Lname;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox Weight;
        private TextBox Height;
        private Label label1;
        private Label label2;
        private TextBox textBox6;
        private Label label3;
        private Label label4;
        private RadioButton RMale;
        private RadioButton Rfmale;
    }
}
