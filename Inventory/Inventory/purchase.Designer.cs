namespace Inventory
{
    partial class purchase
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_voucher_no = new System.Windows.Forms.TextBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.txt_gross_total = new System.Windows.Forms.TextBox();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.txt_net_amount = new System.Windows.Forms.TextBox();
            this.txt_supplier = new System.Windows.Forms.ComboBox();
            this.txt_date = new System.Windows.Forms.DateTimePicker();
            this.gd_purchase = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_item_search = new System.Windows.Forms.ComboBox();
            this.txt_payment_id = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gd_purchase)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "voucturer no ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "supplier";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(558, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(454, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(334, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "item search";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(395, 437);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "gross total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(395, 503);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "net amount";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(395, 470);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "discount";
            // 
            // txt_voucher_no
            // 
            this.txt_voucher_no.Location = new System.Drawing.Point(115, 19);
            this.txt_voucher_no.Name = "txt_voucher_no";
            this.txt_voucher_no.Size = new System.Drawing.Size(133, 20);
            this.txt_voucher_no.TabIndex = 10;
            this.txt_voucher_no.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_voucher_no_KeyDown);
            this.txt_voucher_no.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_voucher_no_KeyPress);
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(590, 59);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(100, 20);
            this.txt_total.TabIndex = 13;
            this.txt_total.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(484, 58);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(71, 20);
            this.txt_price.TabIndex = 14;
            this.txt_price.Text = "0";
            this.txt_price.TextChanged += new System.EventHandler(this.txt_price_TextChanged);
            this.txt_price.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_price_KeyDown);
            this.txt_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_quantity_KeyPress);
            this.txt_price.Leave += new System.EventHandler(this.txt_price_Leave);
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(384, 59);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(71, 20);
            this.txt_quantity.TabIndex = 15;
            this.txt_quantity.Text = "0";
            this.txt_quantity.TextChanged += new System.EventHandler(this.txt_quantity_TextChanged);
            this.txt_quantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_quantity_KeyDown);
            this.txt_quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_quantity_KeyPress);
            this.txt_quantity.Leave += new System.EventHandler(this.txt_quantity_Leave);
            // 
            // txt_gross_total
            // 
            this.txt_gross_total.Location = new System.Drawing.Point(480, 430);
            this.txt_gross_total.Name = "txt_gross_total";
            this.txt_gross_total.Size = new System.Drawing.Size(100, 20);
            this.txt_gross_total.TabIndex = 17;
            // 
            // txt_discount
            // 
            this.txt_discount.Location = new System.Drawing.Point(480, 463);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(100, 20);
            this.txt_discount.TabIndex = 18;
            this.txt_discount.TextChanged += new System.EventHandler(this.txt_discount_TextChanged);
            this.txt_discount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_discount_KeyDown);
            this.txt_discount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_discount_KeyPress);
            // 
            // txt_net_amount
            // 
            this.txt_net_amount.Location = new System.Drawing.Point(480, 496);
            this.txt_net_amount.Name = "txt_net_amount";
            this.txt_net_amount.Size = new System.Drawing.Size(100, 20);
            this.txt_net_amount.TabIndex = 19;
            // 
            // txt_supplier
            // 
            this.txt_supplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_supplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_supplier.FormattingEnabled = true;
            this.txt_supplier.Location = new System.Drawing.Point(115, 99);
            this.txt_supplier.Name = "txt_supplier";
            this.txt_supplier.Size = new System.Drawing.Size(133, 21);
            this.txt_supplier.TabIndex = 21;
            this.txt_supplier.SelectedIndexChanged += new System.EventHandler(this.txt_supplier_SelectedIndexChanged);
            this.txt_supplier.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_supplier_KeyDown);
            this.txt_supplier.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_supplier_KeyPress);
            this.txt_supplier.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_supplier_MouseClick);
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(115, 71);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(133, 20);
            this.txt_date.TabIndex = 23;
            // 
            // gd_purchase
            // 
            this.gd_purchase.AllowUserToAddRows = false;
            this.gd_purchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_purchase.Location = new System.Drawing.Point(32, 126);
            this.gd_purchase.Name = "gd_purchase";
            this.gd_purchase.Size = new System.Drawing.Size(644, 273);
            this.gd_purchase.TabIndex = 24;
            this.gd_purchase.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gd_purchase_CellContentClick);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(615, 19);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 25;
            this.btn_add.Text = "add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            this.btn_add.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_add_KeyDown);
            this.btn_add.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn_add_KeyPress);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(601, 494);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 26;
            this.btn_clear.Text = "clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(601, 460);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 27;
            this.btn_save.Text = "save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            this.btn_save.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_save_KeyDown);
            // 
            // txt_item_search
            // 
            this.txt_item_search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_item_search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_item_search.FormattingEnabled = true;
            this.txt_item_search.Location = new System.Drawing.Point(401, 24);
            this.txt_item_search.Name = "txt_item_search";
            this.txt_item_search.Size = new System.Drawing.Size(196, 21);
            this.txt_item_search.TabIndex = 29;
            this.txt_item_search.DropDown += new System.EventHandler(this.txt_item_search_TextChanged_1);
            this.txt_item_search.SelectedIndexChanged += new System.EventHandler(this.txt_item_search_SelectedIndexChanged);
            this.txt_item_search.TextChanged += new System.EventHandler(this.txt_item_search_TextChanged_1);
            this.txt_item_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_item_search_KeyDown_1);
            this.txt_item_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_item_search_KeyPress);
            // 
            // txt_payment_id
            // 
            this.txt_payment_id.Enabled = false;
            this.txt_payment_id.Location = new System.Drawing.Point(115, 45);
            this.txt_payment_id.Name = "txt_payment_id";
            this.txt_payment_id.Size = new System.Drawing.Size(133, 20);
            this.txt_payment_id.TabIndex = 123;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 122;
            this.label11.Text = "Transaction id";
            // 
            // purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 540);
            this.Controls.Add(this.txt_payment_id);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_item_search);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.gd_purchase);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.txt_supplier);
            this.Controls.Add(this.txt_net_amount);
            this.Controls.Add(this.txt_discount);
            this.Controls.Add(this.txt_gross_total);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.txt_voucher_no);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "purchase";
            this.Text = " ";
            this.Load += new System.EventHandler(this.purchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gd_purchase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_voucher_no;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.TextBox txt_gross_total;
        private System.Windows.Forms.TextBox txt_discount;
        private System.Windows.Forms.TextBox txt_net_amount;
        private System.Windows.Forms.ComboBox txt_supplier;
        private System.Windows.Forms.DateTimePicker txt_date;
        private System.Windows.Forms.DataGridView gd_purchase;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ComboBox txt_item_search;
        private System.Windows.Forms.TextBox txt_payment_id;
        private System.Windows.Forms.Label label11;
    }
}