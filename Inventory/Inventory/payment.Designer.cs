namespace Inventory
{
    partial class payment
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
            this.components = new System.ComponentModel.Container();
            this.txt_pay_no = new System.Windows.Forms.TextBox();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ledger = new System.Windows.Forms.ComboBox();
            this.Btn_insert = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.gd_pay = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_payment_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_date = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txt_name = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gd_pay)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_pay_no
            // 
            this.txt_pay_no.Enabled = false;
            this.txt_pay_no.Location = new System.Drawing.Point(121, 29);
            this.txt_pay_no.Name = "txt_pay_no";
            this.txt_pay_no.Size = new System.Drawing.Size(133, 20);
            this.txt_pay_no.TabIndex = 0;
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(121, 234);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(133, 20);
            this.txt_amount.TabIndex = 3;
            this.txt_amount.TextChanged += new System.EventHandler(this.txt_amount_TextChanged);
            this.txt_amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_amount_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Payment no";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(26, 112);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(60, 13);
            this.Name.TabIndex = 6;
            this.Name.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ledger";
            // 
            // txt_ledger
            // 
            this.txt_ledger.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_ledger.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_ledger.FormattingEnabled = true;
            this.txt_ledger.Location = new System.Drawing.Point(121, 185);
            this.txt_ledger.Name = "txt_ledger";
            this.txt_ledger.Size = new System.Drawing.Size(133, 21);
            this.txt_ledger.TabIndex = 11;
            // 
            // Btn_insert
            // 
            this.Btn_insert.Location = new System.Drawing.Point(121, 332);
            this.Btn_insert.Name = "Btn_insert";
            this.Btn_insert.Size = new System.Drawing.Size(75, 23);
            this.Btn_insert.TabIndex = 14;
            this.Btn_insert.Text = "Insert";
            this.Btn_insert.UseVisualStyleBackColor = true;
            this.Btn_insert.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(29, 332);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 15;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // gd_pay
            // 
            this.gd_pay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_pay.Location = new System.Drawing.Point(271, 66);
            this.gd_pay.Name = "gd_pay";
            this.gd_pay.Size = new System.Drawing.Size(602, 320);
            this.gd_pay.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Payment Code";
            // 
            // txt_payment_id
            // 
            this.txt_payment_id.Enabled = false;
            this.txt_payment_id.Location = new System.Drawing.Point(121, 73);
            this.txt_payment_id.Name = "txt_payment_id";
            this.txt_payment_id.Size = new System.Drawing.Size(133, 20);
            this.txt_payment_id.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Date";
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(121, 273);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(133, 20);
            this.txt_date.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(307, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(538, 29);
            this.textBox1.TabIndex = 21;
            this.textBox1.Text = "                                   Payment Voucher";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(271, 392);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 23;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(121, 109);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(133, 58);
            this.txt_name.TabIndex = 24;
            this.txt_name.Text = "";
            // 
            // payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 438);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.progressBar1);
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
            this.Load += new System.EventHandler(this.payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gd_pay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_pay_no;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txt_ledger;
        private System.Windows.Forms.Button Btn_insert;
        public System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView gd_pay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_payment_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker txt_date;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RichTextBox txt_name;
    }
}