namespace exe
{
    partial class Form1
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
            this.txt_number = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.txt_mobilee = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_adress = new System.Windows.Forms.RichTextBox();
            this.ptrbox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.fd = new System.Windows.Forms.OpenFileDialog();
            this.btn_upload = new System.Windows.Forms.Button();
            this.btn_view = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptrbox)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_number
            // 
            this.txt_number.Location = new System.Drawing.Point(83, 45);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(167, 20);
            this.txt_number.TabIndex = 0;
            this.txt_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_number_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mobile";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Address";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(12, 96);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(35, 13);
            this.Name.TabIndex = 4;
            this.Name.Text = "Name";
            // 
            // txt_mobilee
            // 
            this.txt_mobilee.Location = new System.Drawing.Point(83, 215);
            this.txt_mobilee.Name = "txt_mobilee";
            this.txt_mobilee.Size = new System.Drawing.Size(167, 20);
            this.txt_mobilee.TabIndex = 7;
            this.txt_mobilee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_mobilee_KeyPress);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(83, 89);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(167, 20);
            this.txt_name.TabIndex = 8;
            // 
            // txt_adress
            // 
            this.txt_adress.Location = new System.Drawing.Point(83, 136);
            this.txt_adress.Name = "txt_adress";
            this.txt_adress.Size = new System.Drawing.Size(167, 52);
            this.txt_adress.TabIndex = 9;
            this.txt_adress.Text = "";
            // 
            // ptrbox
            // 
            this.ptrbox.Location = new System.Drawing.Point(449, 74);
            this.ptrbox.Name = "ptrbox";
            this.ptrbox.Size = new System.Drawing.Size(168, 114);
            this.ptrbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrbox.TabIndex = 11;
            this.ptrbox.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(446, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Upload image";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(339, 74);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 13;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.button1_Click);
            // 
            // fd
            // 
            this.fd.FileName = "openFileDialog1";
            // 
            // btn_upload
            // 
            this.btn_upload.Location = new System.Drawing.Point(339, 222);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(75, 23);
            this.btn_upload.TabIndex = 14;
            this.btn_upload.Text = "upload";
            this.btn_upload.UseVisualStyleBackColor = true;
            this.btn_upload.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_view
            // 
            this.btn_view.Location = new System.Drawing.Point(431, 222);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(75, 23);
            this.btn_view.TabIndex = 15;
            this.btn_view.Text = "view";
            this.btn_view.UseVisualStyleBackColor = true;
            this.btn_view.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 348);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.btn_upload);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ptrbox);
            this.Controls.Add(this.txt_adress);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_mobilee);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_number);
           // this.Name = "exe";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptrbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.TextBox txt_mobilee;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.RichTextBox txt_adress;
        private System.Windows.Forms.PictureBox ptrbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.OpenFileDialog fd;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.Button btn_view;
    }
}

