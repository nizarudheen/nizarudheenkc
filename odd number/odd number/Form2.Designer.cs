namespace odd_number
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_male = new System.Windows.Forms.RadioButton();
            this.txt_female = new System.Windows.Forms.RadioButton();
            this.txt_date = new System.Windows.Forms.DateTimePicker();
            this.txt_standred = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_admnno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txt_standred)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Student name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Standred";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Male/female";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Date of birth";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(167, 89);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(129, 20);
            this.txt_name.TabIndex = 15;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(168, 220);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(129, 20);
            this.txt_address.TabIndex = 18;
            // 
            // txt_male
            // 
            this.txt_male.AutoSize = true;
            this.txt_male.Location = new System.Drawing.Point(168, 174);
            this.txt_male.Name = "txt_male";
            this.txt_male.Size = new System.Drawing.Size(47, 17);
            this.txt_male.TabIndex = 21;
            this.txt_male.TabStop = true;
            this.txt_male.Text = "male";
            this.txt_male.UseVisualStyleBackColor = true;
            // 
            // txt_female
            // 
            this.txt_female.AutoSize = true;
            this.txt_female.Location = new System.Drawing.Point(212, 174);
            this.txt_female.Name = "txt_female";
            this.txt_female.Size = new System.Drawing.Size(56, 17);
            this.txt_female.TabIndex = 22;
            this.txt_female.TabStop = true;
            this.txt_female.Text = "female";
            this.txt_female.UseVisualStyleBackColor = true;
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(168, 262);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(129, 20);
            this.txt_date.TabIndex = 23;
            // 
            // txt_standred
            // 
            this.txt_standred.Location = new System.Drawing.Point(168, 131);
            this.txt_standred.Name = "txt_standred";
            this.txt_standred.Size = new System.Drawing.Size(129, 20);
            this.txt_standred.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(147, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Enter the student details";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "insert";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_admnno
            // 
            this.txt_admnno.Location = new System.Drawing.Point(167, 49);
            this.txt_admnno.Name = "txt_admnno";
            this.txt_admnno.Size = new System.Drawing.Size(129, 20);
            this.txt_admnno.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Admission no";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 429);
            this.Controls.Add(this.txt_admnno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_standred);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.txt_female);
            this.Controls.Add(this.txt_male);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.txt_standred)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.RadioButton txt_male;
        private System.Windows.Forms.RadioButton txt_female;
        private System.Windows.Forms.DateTimePicker txt_date;
        private System.Windows.Forms.NumericUpDown txt_standred;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_admnno;
        private System.Windows.Forms.Label label6;

    }
}