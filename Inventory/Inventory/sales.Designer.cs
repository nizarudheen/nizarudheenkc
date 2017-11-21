namespace Inventory
{
    partial class sales
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
            this.txt_item_search = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.gd_sale = new System.Windows.Forms.DataGridView();
            this.txt_date = new System.Windows.Forms.DateTimePicker();
            this.txt_customer = new System.Windows.Forms.ComboBox();
            this.txt_net_amount = new System.Windows.Forms.TextBox();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.txt_gross_total = new System.Windows.Forms.TextBox();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.txt_bill_no = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.jk = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_pluss = new System.Windows.Forms.Button();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.btn_print = new System.Windows.Forms.Button();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_payment_id = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gd_sale)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_item_search
            // 
            this.txt_item_search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_item_search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_item_search.FormattingEnabled = true;
            this.txt_item_search.Location = new System.Drawing.Point(381, 17);
            this.txt_item_search.Name = "txt_item_search";
            this.txt_item_search.Size = new System.Drawing.Size(196, 21);
            this.txt_item_search.TabIndex = 53;
            this.txt_item_search.SelectedIndexChanged += new System.EventHandler(this.txt_item_search_SelectedIndexChanged);
            this.txt_item_search.DisplayMemberChanged += new System.EventHandler(this.txt_item_search_SelectedIndexChanged);
            this.txt_item_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_item_search_KeyDown);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(597, 417);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 52;
            this.btn_save.Text = "save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(199, 422);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 51;
            this.btn_clear.Text = "clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(595, 12);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 50;
            this.btn_add.Text = "add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            this.btn_add.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_add_KeyDown);
            // 
            // gd_sale
            // 
            this.gd_sale.AllowUserToAddRows = false;
            this.gd_sale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_sale.Location = new System.Drawing.Point(12, 128);
            this.gd_sale.Name = "gd_sale";
            this.gd_sale.Size = new System.Drawing.Size(665, 214);
            this.gd_sale.TabIndex = 49;
            this.gd_sale.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gd_sale_RowHeaderMouseClick);
            this.gd_sale.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gd_sale_RowHeaderMouseDoubleClick);
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(97, 51);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(133, 20);
            this.txt_date.TabIndex = 48;
            this.txt_date.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_date_KeyDown);
            // 
            // txt_customer
            // 
            this.txt_customer.AllowDrop = true;
            this.txt_customer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_customer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_customer.FormattingEnabled = true;
            this.txt_customer.Location = new System.Drawing.Point(97, 82);
            this.txt_customer.Name = "txt_customer";
            this.txt_customer.Size = new System.Drawing.Size(133, 21);
            this.txt_customer.TabIndex = 47;
            this.txt_customer.SelectedIndexChanged += new System.EventHandler(this.txt_customer_SelectedIndexChanged);
            this.txt_customer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_customer_KeyDown);
            // 
            // txt_net_amount
            // 
            this.txt_net_amount.Location = new System.Drawing.Point(487, 448);
            this.txt_net_amount.Name = "txt_net_amount";
            this.txt_net_amount.Size = new System.Drawing.Size(100, 20);
            this.txt_net_amount.TabIndex = 46;
            this.txt_net_amount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_net_amount_KeyDown);
            // 
            // txt_discount
            // 
            this.txt_discount.Location = new System.Drawing.Point(487, 415);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(100, 20);
            this.txt_discount.TabIndex = 45;
            this.txt_discount.TextChanged += new System.EventHandler(this.txt_discount_TextChanged);
            this.txt_discount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_discount_KeyDown);
            // 
            // txt_gross_total
            // 
            this.txt_gross_total.Location = new System.Drawing.Point(487, 382);
            this.txt_gross_total.Name = "txt_gross_total";
            this.txt_gross_total.Size = new System.Drawing.Size(100, 20);
            this.txt_gross_total.TabIndex = 44;
            this.txt_gross_total.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_gross_total_KeyDown);
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(364, 52);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(71, 20);
            this.txt_quantity.TabIndex = 43;
            this.txt_quantity.Text = "0";
            this.txt_quantity.TextChanged += new System.EventHandler(this.txt_quantity_TextChanged);
            this.txt_quantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_quantity_KeyDown);
            this.txt_quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_quantity_KeyPress);
            this.txt_quantity.Leave += new System.EventHandler(this.txt_quantity_Leave);
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(464, 51);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(71, 20);
            this.txt_price.TabIndex = 42;
            this.txt_price.Text = "0";
            this.txt_price.TextChanged += new System.EventHandler(this.txt_price_TextChanged);
            this.txt_price.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_price_KeyDown);
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(570, 52);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(100, 20);
            this.txt_total.TabIndex = 41;
            // 
            // txt_bill_no
            // 
            this.txt_bill_no.Location = new System.Drawing.Point(97, 2);
            this.txt_bill_no.Name = "txt_bill_no";
            this.txt_bill_no.ReadOnly = true;
            this.txt_bill_no.Size = new System.Drawing.Size(133, 20);
            this.txt_bill_no.TabIndex = 40;
            this.txt_bill_no.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_bill_no_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(402, 422);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "discount";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(402, 455);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "net amount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(402, 389);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "gross total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(314, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "item search";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(314, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(434, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(538, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "customer name ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "date";
            // 
            // jk
            // 
            this.jk.AutoSize = true;
            this.jk.Location = new System.Drawing.Point(16, 9);
            this.jk.Name = "jk";
            this.jk.Size = new System.Drawing.Size(38, 13);
            this.jk.TabIndex = 30;
            this.jk.Text = "Bill no ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "stock";
            // 
            // txt_stock
            // 
            this.txt_stock.Location = new System.Drawing.Point(364, 87);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(100, 20);
            this.txt_stock.TabIndex = 55;
            this.txt_stock.TextChanged += new System.EventHandler(this.txt_stock_TextChanged);
            // 
            // btn_minus
            // 
            this.btn_minus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_minus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_minus.Location = new System.Drawing.Point(236, 9);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(24, 13);
            this.btn_minus.TabIndex = 116;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // btn_pluss
            // 
            this.btn_pluss.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_pluss.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_pluss.Location = new System.Drawing.Point(236, -1);
            this.btn_pluss.Name = "btn_pluss";
            this.btn_pluss.Size = new System.Drawing.Size(24, 11);
            this.btn_pluss.TabIndex = 117;
            this.btn_pluss.Text = "+";
            this.btn_pluss.UseVisualStyleBackColor = true;
            this.btn_pluss.Click += new System.EventHandler(this.btn_pluss_Click);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(597, 445);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(75, 23);
            this.btn_print.TabIndex = 118;
            this.btn_print.Text = "print";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(486, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 119;
            // 
            // txt_payment_id
            // 
            this.txt_payment_id.Enabled = false;
            this.txt_payment_id.Location = new System.Drawing.Point(97, 28);
            this.txt_payment_id.Name = "txt_payment_id";
            this.txt_payment_id.Size = new System.Drawing.Size(133, 20);
            this.txt_payment_id.TabIndex = 121;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 120;
            this.label11.Text = "Transaction id";
            // 
            // sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 494);
            this.Controls.Add(this.txt_payment_id);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_pluss);
            this.Controls.Add(this.txt_stock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_item_search);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.gd_sale);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.txt_customer);
            this.Controls.Add(this.txt_net_amount);
            this.Controls.Add(this.txt_discount);
            this.Controls.Add(this.txt_gross_total);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.txt_bill_no);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.jk);
            this.Name = "sales";
            this.Text = "sales";
            this.Load += new System.EventHandler(this.sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gd_sale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txt_item_search;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView gd_sale;
        private System.Windows.Forms.DateTimePicker txt_date;
        private System.Windows.Forms.ComboBox txt_customer;
        private System.Windows.Forms.TextBox txt_net_amount;
        private System.Windows.Forms.TextBox txt_discount;
        private System.Windows.Forms.TextBox txt_gross_total;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.TextBox txt_bill_no;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label jk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_pluss;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.Button btn_print;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txt_payment_id;
        private System.Windows.Forms.Label label11;

    }
}