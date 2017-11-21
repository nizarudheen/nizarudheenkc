namespace Inventory
{
    partial class items
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
            this.NUMBER = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_it_no = new System.Windows.Forms.TextBox();
            this.txt_it_code = new System.Windows.Forms.TextBox();
            this.txt_it_name = new System.Windows.Forms.TextBox();
            this.txt_it_salesprice = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_upload = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_it_unit = new System.Windows.Forms.ComboBox();
            this.txt_it_brand = new System.Windows.Forms.ComboBox();
            this.txt_it_catg = new System.Windows.Forms.ComboBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_purchase_rate = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // NUMBER
            // 
            this.NUMBER.AutoSize = true;
            this.NUMBER.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.NUMBER.Location = new System.Drawing.Point(17, 92);
            this.NUMBER.Name = "NUMBER";
            this.NUMBER.Size = new System.Drawing.Size(41, 13);
            this.NUMBER.TabIndex = 0;
            this.NUMBER.Text = "item no";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "item code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "item name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "brand";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "unit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(315, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "ITEM MASTER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "sales rate";
            // 
            // txt_it_no
            // 
            this.txt_it_no.Location = new System.Drawing.Point(90, 95);
            this.txt_it_no.Name = "txt_it_no";
            this.txt_it_no.ReadOnly = true;
            this.txt_it_no.Size = new System.Drawing.Size(121, 20);
            this.txt_it_no.TabIndex = 8;
            // 
            // txt_it_code
            // 
            this.txt_it_code.Location = new System.Drawing.Point(90, 125);
            this.txt_it_code.Name = "txt_it_code";
            this.txt_it_code.Size = new System.Drawing.Size(121, 20);
            this.txt_it_code.TabIndex = 9;
            // 
            // txt_it_name
            // 
            this.txt_it_name.Location = new System.Drawing.Point(90, 157);
            this.txt_it_name.Name = "txt_it_name";
            this.txt_it_name.Size = new System.Drawing.Size(121, 20);
            this.txt_it_name.TabIndex = 10;
            this.txt_it_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_it_name_KeyDown);
            // 
            // txt_it_salesprice
            // 
            this.txt_it_salesprice.Location = new System.Drawing.Point(90, 301);
            this.txt_it_salesprice.Name = "txt_it_salesprice";
            this.txt_it_salesprice.Size = new System.Drawing.Size(121, 20);
            this.txt_it_salesprice.TabIndex = 14;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(108, 404);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 15;
            this.btn_add.Text = "click";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_upload
            // 
            this.btn_upload.Location = new System.Drawing.Point(237, 543);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(75, 23);
            this.btn_upload.TabIndex = 16;
            this.btn_upload.Text = "insert";
            this.btn_upload.UseVisualStyleBackColor = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // btn_update
            // 
            this.btn_update.Enabled = false;
            this.btn_update.Location = new System.Drawing.Point(318, 543);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 17;
            this.btn_update.Text = "update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(399, 543);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 18;
            this.btn_clear.Text = "clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(237, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(712, 410);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 409);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Add new item";
            // 
            // txt_it_unit
            // 
            this.txt_it_unit.FormattingEnabled = true;
            this.txt_it_unit.Location = new System.Drawing.Point(90, 264);
            this.txt_it_unit.Name = "txt_it_unit";
            this.txt_it_unit.Size = new System.Drawing.Size(121, 21);
            this.txt_it_unit.TabIndex = 21;
            this.txt_it_unit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_it_unit_MouseClick);
            // 
            // txt_it_brand
            // 
            this.txt_it_brand.FormattingEnabled = true;
            this.txt_it_brand.Location = new System.Drawing.Point(90, 228);
            this.txt_it_brand.Name = "txt_it_brand";
            this.txt_it_brand.Size = new System.Drawing.Size(121, 21);
            this.txt_it_brand.TabIndex = 22;
            this.txt_it_brand.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_it_brand_MouseClick);
            // 
            // txt_it_catg
            // 
            this.txt_it_catg.FormattingEnabled = true;
            this.txt_it_catg.Location = new System.Drawing.Point(90, 192);
            this.txt_it_catg.Name = "txt_it_catg";
            this.txt_it_catg.Size = new System.Drawing.Size(121, 21);
            this.txt_it_catg.TabIndex = 23;
            this.txt_it_catg.SelectedIndexChanged += new System.EventHandler(this.txt_it_catg_SelectedIndexChanged);
            this.txt_it_catg.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_it_catg_MouseClick);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(296, 59);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(274, 20);
            this.txt_search.TabIndex = 24;
            this.txt_search.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "purchase rate";
            // 
            // txt_purchase_rate
            // 
            this.txt_purchase_rate.Location = new System.Drawing.Point(90, 339);
            this.txt_purchase_rate.Name = "txt_purchase_rate";
            this.txt_purchase_rate.Size = new System.Drawing.Size(121, 20);
            this.txt_purchase_rate.TabIndex = 26;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.textBox1.Location = new System.Drawing.Point(20, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 27);
            this.textBox1.TabIndex = 27;
            this.textBox1.Text = "Enter the item details";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(234, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Search";
            // 
            // items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 591);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt_purchase_rate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.txt_it_catg);
            this.Controls.Add(this.txt_it_brand);
            this.Controls.Add(this.txt_it_unit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_upload);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_it_salesprice);
            this.Controls.Add(this.txt_it_name);
            this.Controls.Add(this.txt_it_code);
            this.Controls.Add(this.txt_it_no);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NUMBER);
            this.Name = "items";
            this.Text = "items";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.items_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NUMBER;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_it_no;
        private System.Windows.Forms.TextBox txt_it_code;
        private System.Windows.Forms.TextBox txt_it_name;
        private System.Windows.Forms.TextBox txt_it_salesprice;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox txt_it_unit;
        private System.Windows.Forms.ComboBox txt_it_brand;
        private System.Windows.Forms.ComboBox txt_it_catg;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_purchase_rate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
    }
}