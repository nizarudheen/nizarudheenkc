namespace Inventory
{
    partial class Customer
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
            this.txt_cstmr_id = new System.Windows.Forms.TextBox();
            this.txt_cstmr_name = new System.Windows.Forms.TextBox();
            this.txt_cstmr_address = new System.Windows.Forms.TextBox();
            this.txt_mobile = new System.Windows.Forms.TextBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cstmr_mob = new System.Windows.Forms.Label();
            this.txt_date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.gd_customer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gd_customer)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_cstmr_id
            // 
            this.txt_cstmr_id.Location = new System.Drawing.Point(87, 40);
            this.txt_cstmr_id.Name = "txt_cstmr_id";
            this.txt_cstmr_id.Size = new System.Drawing.Size(100, 20);
            this.txt_cstmr_id.TabIndex = 0;
            // 
            // txt_cstmr_name
            // 
            this.txt_cstmr_name.Location = new System.Drawing.Point(87, 91);
            this.txt_cstmr_name.Name = "txt_cstmr_name";
            this.txt_cstmr_name.Size = new System.Drawing.Size(100, 20);
            this.txt_cstmr_name.TabIndex = 1;
            this.txt_cstmr_name.TextChanged += new System.EventHandler(this.txt_cstmr_name_TextChanged);
            this.txt_cstmr_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_cstmr_name_KeyDown);
            // 
            // txt_cstmr_address
            // 
            this.txt_cstmr_address.Location = new System.Drawing.Point(87, 142);
            this.txt_cstmr_address.Name = "txt_cstmr_address";
            this.txt_cstmr_address.Size = new System.Drawing.Size(100, 20);
            this.txt_cstmr_address.TabIndex = 2;
            this.txt_cstmr_address.TextChanged += new System.EventHandler(this.txt_cstmr_address_TextChanged);
            this.txt_cstmr_address.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_cstmr_address_KeyDown);
            // 
            // txt_mobile
            // 
            this.txt_mobile.Location = new System.Drawing.Point(87, 193);
            this.txt_mobile.Name = "txt_mobile";
            this.txt_mobile.Size = new System.Drawing.Size(100, 20);
            this.txt_mobile.TabIndex = 3;
            this.txt_mobile.TextChanged += new System.EventHandler(this.txt_mobile_TextChanged);
            this.txt_mobile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_mobile_KeyDown);
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(87, 300);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 23);
            this.btn_insert.TabIndex = 4;
            this.btn_insert.Text = "insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "customer id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "address";
            // 
            // txt_cstmr_mob
            // 
            this.txt_cstmr_mob.AutoSize = true;
            this.txt_cstmr_mob.Location = new System.Drawing.Point(5, 200);
            this.txt_cstmr_mob.Name = "txt_cstmr_mob";
            this.txt_cstmr_mob.Size = new System.Drawing.Size(37, 13);
            this.txt_cstmr_mob.TabIndex = 8;
            this.txt_cstmr_mob.Text = "mobile";
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(87, 227);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(133, 20);
            this.txt_date.TabIndex = 9;
            this.txt_date.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_date_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "date";
            // 
            // gd_customer
            // 
            this.gd_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_customer.Location = new System.Drawing.Point(235, 23);
            this.gd_customer.Name = "gd_customer";
            this.gd_customer.Size = new System.Drawing.Size(398, 203);
            this.gd_customer.TabIndex = 11;
            this.gd_customer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gd_customer_CellContentClick);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 440);
            this.Controls.Add(this.gd_customer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.txt_cstmr_mob);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.txt_mobile);
            this.Controls.Add(this.txt_cstmr_address);
            this.Controls.Add(this.txt_cstmr_name);
            this.Controls.Add(this.txt_cstmr_id);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gd_customer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_cstmr_id;
        private System.Windows.Forms.TextBox txt_cstmr_name;
        private System.Windows.Forms.TextBox txt_cstmr_address;
        private System.Windows.Forms.TextBox txt_mobile;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txt_cstmr_mob;
        private System.Windows.Forms.DateTimePicker txt_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gd_customer;
    }
}