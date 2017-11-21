namespace exe
{
    partial class install_db
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.combo_local_servers = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbServers1 = new System.Windows.Forms.ComboBox();
            this.combo_nw_servers = new System.Windows.Forms.RadioButton();
            this.cmbInstance1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_pasword = new System.Windows.Forms.TextBox();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.cmbPath = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(602, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 22);
            this.button2.TabIndex = 1;
            this.button2.Text = "connect";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(51, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 22);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(32, 35);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // combo_local_servers
            // 
            this.combo_local_servers.AutoSize = true;
            this.combo_local_servers.Location = new System.Drawing.Point(216, 74);
            this.combo_local_servers.Name = "combo_local_servers";
            this.combo_local_servers.Size = new System.Drawing.Size(88, 17);
            this.combo_local_servers.TabIndex = 4;
            this.combo_local_servers.TabStop = true;
            this.combo_local_servers.Text = "Local servers";
            this.combo_local_servers.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(73, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(83, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(73, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(43, 85);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(73, 20);
            this.textBox3.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Database configuration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "System name";
            // 
            // cmbServers1
            // 
            this.cmbServers1.FormattingEnabled = true;
            this.cmbServers1.Location = new System.Drawing.Point(22, 175);
            this.cmbServers1.Name = "cmbServers1";
            this.cmbServers1.Size = new System.Drawing.Size(314, 21);
            this.cmbServers1.TabIndex = 10;
            this.cmbServers1.SelectedValueChanged += new System.EventHandler(this.cmbServers1_SelectedValueChanged);
            this.cmbServers1.BindingContextChanged += new System.EventHandler(this.cmbServers1_BindingContextChanged);
            // 
            // combo_nw_servers
            // 
            this.combo_nw_servers.AutoSize = true;
            this.combo_nw_servers.Location = new System.Drawing.Point(310, 74);
            this.combo_nw_servers.Name = "combo_nw_servers";
            this.combo_nw_servers.Size = new System.Drawing.Size(100, 17);
            this.combo_nw_servers.TabIndex = 11;
            this.combo_nw_servers.TabStop = true;
            this.combo_nw_servers.Text = "network servers";
            this.combo_nw_servers.UseVisualStyleBackColor = true;
            // 
            // cmbInstance1
            // 
            this.cmbInstance1.FormattingEnabled = true;
            this.cmbInstance1.Location = new System.Drawing.Point(355, 175);
            this.cmbInstance1.Name = "cmbInstance1";
            this.cmbInstance1.Size = new System.Drawing.Size(333, 21);
            this.cmbInstance1.TabIndex = 12;
            this.cmbInstance1.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.txt_username);
            this.groupBox1.Controls.Add(this.txt_pasword);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(22, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(666, 136);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Authentication";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Server_instance";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(87, 49);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(195, 19);
            this.radioButton3.TabIndex = 60;
            this.radioButton3.Text = "Use SQL Server Authentication.";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(87, 28);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(184, 19);
            this.radioButton4.TabIndex = 59;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Use Windows Authentication.";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // txt_username
            // 
            this.txt_username.Enabled = false;
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(85, 90);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(253, 21);
            this.txt_username.TabIndex = 57;
            // 
            // txt_pasword
            // 
            this.txt_pasword.Enabled = false;
            this.txt_pasword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pasword.Location = new System.Drawing.Point(346, 90);
            this.txt_pasword.Name = "txt_pasword";
            this.txt_pasword.PasswordChar = '*';
            this.txt_pasword.Size = new System.Drawing.Size(308, 21);
            this.txt_pasword.TabIndex = 58;
            // 
            // cmbPath
            // 
            this.cmbPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPath.FormattingEnabled = true;
            this.cmbPath.Location = new System.Drawing.Point(22, 399);
            this.cmbPath.Name = "cmbPath";
            this.cmbPath.Size = new System.Drawing.Size(666, 23);
            this.cmbPath.TabIndex = 63;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Location = new System.Drawing.Point(602, 445);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 22);
            this.button4.TabIndex = 64;
            this.button4.Text = "Attach";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // install_db
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(729, 479);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.cmbPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbInstance1);
            this.Controls.Add(this.combo_nw_servers);
            this.Controls.Add(this.cmbServers1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.combo_local_servers);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "install_db";
            this.Text = "install_db";
            this.Load += new System.EventHandler(this.install_db_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton combo_local_servers;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbServers1;
        private System.Windows.Forms.RadioButton combo_nw_servers;
        private System.Windows.Forms.ComboBox cmbInstance1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_pasword;
        private System.Windows.Forms.Label label3;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.ComboBox cmbPath;
        private System.Windows.Forms.Button button4;
    }
}