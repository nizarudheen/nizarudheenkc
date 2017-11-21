namespace odd_number
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.Label();
            this.txtstandred = new System.Windows.Forms.Label();
            this.txtmalefemale = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.Label();
            this.txtdateofbirth = new System.Windows.Forms.Label();
            this.txtaddno = new System.Windows.Forms.Label();
            this.gd_details = new System.Windows.Forms.DataGridView();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gd_details)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student details";
            // 
            // txtname
            // 
            this.txtname.AutoSize = true;
            this.txtname.Location = new System.Drawing.Point(77, 69);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(35, 13);
            this.txtname.TabIndex = 1;
            this.txtname.Text = "label2";
            this.txtname.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtstandred
            // 
            this.txtstandred.AutoSize = true;
            this.txtstandred.Location = new System.Drawing.Point(77, 109);
            this.txtstandred.Name = "txtstandred";
            this.txtstandred.Size = new System.Drawing.Size(35, 13);
            this.txtstandred.TabIndex = 2;
            this.txtstandred.Text = "label3";
            // 
            // txtmalefemale
            // 
            this.txtmalefemale.AutoSize = true;
            this.txtmalefemale.Location = new System.Drawing.Point(77, 136);
            this.txtmalefemale.Name = "txtmalefemale";
            this.txtmalefemale.Size = new System.Drawing.Size(35, 13);
            this.txtmalefemale.TabIndex = 3;
            this.txtmalefemale.Text = "label4";
            // 
            // txtaddress
            // 
            this.txtaddress.AutoSize = true;
            this.txtaddress.Location = new System.Drawing.Point(77, 169);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(35, 13);
            this.txtaddress.TabIndex = 4;
            this.txtaddress.Text = "label5";
            // 
            // txtdateofbirth
            // 
            this.txtdateofbirth.AutoSize = true;
            this.txtdateofbirth.Location = new System.Drawing.Point(77, 201);
            this.txtdateofbirth.Name = "txtdateofbirth";
            this.txtdateofbirth.Size = new System.Drawing.Size(35, 13);
            this.txtdateofbirth.TabIndex = 5;
            this.txtdateofbirth.Text = "label6";
            // 
            // txtaddno
            // 
            this.txtaddno.AutoSize = true;
            this.txtaddno.Location = new System.Drawing.Point(77, 240);
            this.txtaddno.Name = "txtaddno";
            this.txtaddno.Size = new System.Drawing.Size(35, 13);
            this.txtaddno.TabIndex = 6;
            this.txtaddno.Text = "label7";
            // 
            // gd_details
            // 
            this.gd_details.AllowUserToAddRows = false;
            this.gd_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_details.Location = new System.Drawing.Point(379, 46);
            this.gd_details.Name = "gd_details";
            this.gd_details.Size = new System.Drawing.Size(406, 322);
            this.gd_details.TabIndex = 8;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(185, 321);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 9;
            this.btn_back.Text = "back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 469);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.gd_details);
            this.Controls.Add(this.txtaddno);
            this.Controls.Add(this.txtdateofbirth);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtmalefemale);
            this.Controls.Add(this.txtstandred);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gd_details)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label txtname;
        public System.Windows.Forms.Label txtstandred;
        public System.Windows.Forms.Label txtmalefemale;
        public System.Windows.Forms.Label txtaddress;
        public System.Windows.Forms.Label txtdateofbirth;
        public System.Windows.Forms.Label txtaddno;
        public System.Windows.Forms.DataGridView gd_details;
        public System.Windows.Forms.Button btn_back;

    }
}