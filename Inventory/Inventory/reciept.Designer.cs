namespace Inventory
{
    partial class reciept
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
            this.txt_name = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_date = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_payment_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gd_pay = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.Btn_insert = new System.Windows.Forms.Button();
            this.txt_ledger = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.txt_pay_no = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gd_pay)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(117, 135);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(133, 58);
            this.txt_name.TabIndex = 41;
            this.txt_name.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(303, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(579, 29);
            this.textBox1.TabIndex = 39;
            this.textBox1.Text = "                                  Receipt  Voucher";
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(117, 299);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(133, 20);
            this.txt_date.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Date";
            // 
            // txt_payment_id
            // 
            this.txt_payment_id.Enabled = false;
            this.txt_payment_id.Location = new System.Drawing.Point(117, 99);
            this.txt_payment_id.Name = "txt_payment_id";
            this.txt_payment_id.Size = new System.Drawing.Size(133, 20);
            this.txt_payment_id.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Transaction id";
            // 
            // gd_pay
            // 
            this.gd_pay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_pay.Location = new System.Drawing.Point(274, 90);
            this.gd_pay.Name = "gd_pay";
            this.gd_pay.Size = new System.Drawing.Size(622, 320);
            this.gd_pay.TabIndex = 34;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(25, 358);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 33;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // Btn_insert
            // 
            this.Btn_insert.Location = new System.Drawing.Point(117, 358);
            this.Btn_insert.Name = "Btn_insert";
            this.Btn_insert.Size = new System.Drawing.Size(75, 23);
            this.Btn_insert.TabIndex = 32;
            this.Btn_insert.Text = "Insert";
            this.Btn_insert.UseVisualStyleBackColor = true;
            this.Btn_insert.Click += new System.EventHandler(this.Btn_insert_Click);
            // 
            // txt_ledger
            // 
            this.txt_ledger.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_ledger.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_ledger.FormattingEnabled = true;
            this.txt_ledger.Location = new System.Drawing.Point(117, 207);
            this.txt_ledger.Name = "txt_ledger";
            this.txt_ledger.Size = new System.Drawing.Size(133, 21);
            this.txt_ledger.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Ledger";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(22, 138);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(60, 13);
            this.Name.TabIndex = 28;
            this.Name.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Receipt no";
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(117, 264);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(133, 20);
            this.txt_amount.TabIndex = 26;
            this.txt_amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_amount_KeyPress_1);
            // 
            // txt_pay_no
            // 
            this.txt_pay_no.Enabled = false;
            this.txt_pay_no.Location = new System.Drawing.Point(117, 52);
            this.txt_pay_no.Name = "txt_pay_no";
            this.txt_pay_no.Size = new System.Drawing.Size(133, 20);
            this.txt_pay_no.TabIndex = 25;
            // 
            // reciept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 451);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_payment_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gd_pay);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.Btn_insert);
            this.Controls.Add(this.txt_ledger);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.txt_pay_no);
           
            this.Text = "reciept";
            this.Load += new System.EventHandler(this.reciept_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gd_pay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txt_name;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker txt_date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_payment_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gd_pay;
        public System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button Btn_insert;
        private System.Windows.Forms.ComboBox txt_ledger;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.TextBox txt_pay_no;
    }
}