namespace Inventory
{
    partial class sale_report
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
            this.gd_sale_report = new System.Windows.Forms.DataGridView();
            this.bill_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.net_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_excel = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_date2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_date1 = new System.Windows.Forms.DateTimePicker();
            this.ckbox = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.fd_save = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.gd_sale_report)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gd_sale_report
            // 
            this.gd_sale_report.AllowUserToAddRows = false;
            this.gd_sale_report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_sale_report.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bill_no,
            this.name,
            this.date,
            this.code,
            this.item,
            this.price,
            this.quantity,
            this.total,
            this.net_total});
            this.gd_sale_report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gd_sale_report.Location = new System.Drawing.Point(0, 0);
            this.gd_sale_report.Name = "gd_sale_report";
            this.gd_sale_report.Size = new System.Drawing.Size(864, 407);
            this.gd_sale_report.TabIndex = 0;
            this.gd_sale_report.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gd_sale_report_CellContentClick);
            // 
            // bill_no
            // 
            this.bill_no.HeaderText = "bill_no";
            this.bill_no.Name = "bill_no";
            // 
            // name
            // 
            this.name.HeaderText = "name";
            this.name.Name = "name";
            // 
            // date
            // 
            this.date.HeaderText = "date";
            this.date.Name = "date";
            // 
            // code
            // 
            this.code.HeaderText = "code";
            this.code.Name = "code";
            // 
            // item
            // 
            this.item.HeaderText = "item";
            this.item.Name = "item";
            // 
            // price
            // 
            this.price.HeaderText = "price";
            this.price.Name = "price";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "quantity";
            this.quantity.Name = "quantity";
            // 
            // total
            // 
            this.total.HeaderText = "total";
            this.total.Name = "total";
            // 
            // net_total
            // 
            this.net_total.HeaderText = "net total";
            this.net_total.Name = "net_total";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_excel);
            this.panel1.Controls.Add(this.txt_search);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txt_date2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_date1);
            this.panel1.Controls.Add(this.ckbox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 104);
            this.panel1.TabIndex = 1;
            // 
            // btn_excel
            // 
            this.btn_excel.Location = new System.Drawing.Point(722, 32);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Size = new System.Drawing.Size(130, 23);
            this.btn_excel.TabIndex = 9;
            this.btn_excel.Text = "insert to excel";
            this.btn_excel.UseVisualStyleBackColor = true;
            this.btn_excel.Click += new System.EventHandler(this.btn_excel_Click);
            // 
            // txt_search
            // 
            this.txt_search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_search.FormattingEnabled = true;
            this.txt_search.Location = new System.Drawing.Point(392, 36);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(206, 21);
            this.txt_search.TabIndex = 7;
            this.txt_search.SelectedIndexChanged += new System.EventHandler(this.txt_search_SelectedIndexChanged);
            this.txt_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_search_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "search";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(189, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_date2
            // 
            this.txt_date2.Enabled = false;
            this.txt_date2.Location = new System.Drawing.Point(53, 62);
            this.txt_date2.Name = "txt_date2";
            this.txt_date2.Size = new System.Drawing.Size(119, 20);
            this.txt_date2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "to";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "from";
            // 
            // txt_date1
            // 
            this.txt_date1.Enabled = false;
            this.txt_date1.Location = new System.Drawing.Point(53, 36);
            this.txt_date1.Name = "txt_date1";
            this.txt_date1.Size = new System.Drawing.Size(119, 20);
            this.txt_date1.TabIndex = 1;
            // 
            // ckbox
            // 
            this.ckbox.AutoSize = true;
            this.ckbox.Location = new System.Drawing.Point(12, 12);
            this.ckbox.Name = "ckbox";
            this.ckbox.Size = new System.Drawing.Size(76, 17);
            this.ckbox.TabIndex = 0;
            this.ckbox.Text = "Date Wise";
            this.ckbox.UseVisualStyleBackColor = true;
            this.ckbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.gd_sale_report);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(864, 407);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txt_total);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 377);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(864, 30);
            this.panel3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(677, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Net total";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(743, 3);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(115, 20);
            this.txt_total.TabIndex = 9;
            // 
            // sale_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 511);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "sale_report";
            this.Text = "sale_report";
            this.Load += new System.EventHandler(this.sale_report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gd_sale_report)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gd_sale_report;
        private System.Windows.Forms.DataGridViewTextBoxColumn bill_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn item;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker txt_date2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txt_date1;
        private System.Windows.Forms.CheckBox ckbox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txt_search;
        private System.Windows.Forms.DataGridViewTextBoxColumn net_total;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_excel;
        private System.Windows.Forms.SaveFileDialog fd_save;
    }
}