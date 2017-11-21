namespace Inventory
{
    partial class sales_man
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
            this.btn_clr = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_mob = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_nmbr = new System.Windows.Forms.TextBox();
            this.gd_salesman = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gd_salesman)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_clr
            // 
            this.btn_clr.Location = new System.Drawing.Point(261, 136);
            this.btn_clr.Name = "btn_clr";
            this.btn_clr.Size = new System.Drawing.Size(75, 23);
            this.btn_clr.TabIndex = 0;
            this.btn_clr.Text = "clear";
            this.btn_clr.UseVisualStyleBackColor = true;
            this.btn_clr.Click += new System.EventHandler(this.btn_clr_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(261, 86);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 23);
            this.btn_insert.TabIndex = 1;
            this.btn_insert.Text = "insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(261, 36);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(90, 178);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(140, 20);
            this.txt_date.TabIndex = 3;
            this.txt_date.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_date_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "SUPPLIERS  DETAILS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "MOB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "DOB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "number";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(90, 130);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(140, 20);
            this.txt_address.TabIndex = 10;
            this.txt_address.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_address_KeyDown);
            // 
            // txt_mob
            // 
            this.txt_mob.Location = new System.Drawing.Point(90, 224);
            this.txt_mob.Name = "txt_mob";
            this.txt_mob.Size = new System.Drawing.Size(140, 20);
            this.txt_mob.TabIndex = 13;
            this.txt_mob.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_mob_KeyDown);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(90, 83);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(140, 20);
            this.txt_name.TabIndex = 14;
            this.txt_name.Enter += new System.EventHandler(this.txt_name_Enter);
            this.txt_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_name_KeyDown);
            this.txt_name.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txt_name_MouseDown);
            // 
            // txt_nmbr
            // 
            this.txt_nmbr.Location = new System.Drawing.Point(90, 36);
            this.txt_nmbr.Name = "txt_nmbr";
            this.txt_nmbr.ReadOnly = true;
            this.txt_nmbr.Size = new System.Drawing.Size(140, 20);
            this.txt_nmbr.TabIndex = 15;
            this.txt_nmbr.TextChanged += new System.EventHandler(this.txt_nmbr_TextChanged);
            // 
            // gd_salesman
            // 
            this.gd_salesman.AllowUserToAddRows = false;
            this.gd_salesman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_salesman.Location = new System.Drawing.Point(-1, 250);
            this.gd_salesman.Name = "gd_salesman";
            this.gd_salesman.Size = new System.Drawing.Size(567, 94);
            this.gd_salesman.TabIndex = 16;
            // 
            // sales_man
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 342);
            this.Controls.Add(this.gd_salesman);
            this.Controls.Add(this.txt_nmbr);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_mob);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.btn_clr);
            this.Name = "sales_man";
            this.Text = "sales_man";
            this.Load += new System.EventHandler(this.sales_man_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gd_salesman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_clr;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DateTimePicker txt_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_mob;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_nmbr;
        private System.Windows.Forms.DataGridView gd_salesman;
    }
}