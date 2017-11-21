namespace Inventory
{
    partial class ledger
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
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ledger_id = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txt_ledger_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rad_income = new System.Windows.Forms.RadioButton();
            this.rad_expence = new System.Windows.Forms.RadioButton();
            this.btn_insert = new System.Windows.Forms.Button();
            this.gd_ledger_view = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gd_ledger_view)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ledger id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // txt_ledger_id
            // 
            this.txt_ledger_id.Location = new System.Drawing.Point(87, 50);
            this.txt_ledger_id.Name = "txt_ledger_id";
            this.txt_ledger_id.Size = new System.Drawing.Size(100, 20);
            this.txt_ledger_id.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox2.Location = new System.Drawing.Point(136, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(278, 26);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "                        Ledger";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_ledger_name
            // 
            this.txt_ledger_name.Location = new System.Drawing.Point(87, 95);
            this.txt_ledger_name.Name = "txt_ledger_name";
            this.txt_ledger_name.Size = new System.Drawing.Size(100, 20);
            this.txt_ledger_name.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Type";
            // 
            // rad_income
            // 
            this.rad_income.AutoSize = true;
            this.rad_income.Location = new System.Drawing.Point(87, 151);
            this.rad_income.Name = "rad_income";
            this.rad_income.Size = new System.Drawing.Size(60, 17);
            this.rad_income.TabIndex = 8;
            this.rad_income.TabStop = true;
            this.rad_income.Text = "Income";
            this.rad_income.UseVisualStyleBackColor = true;
            // 
            // rad_expence
            // 
            this.rad_expence.AutoSize = true;
            this.rad_expence.Location = new System.Drawing.Point(87, 128);
            this.rad_expence.Name = "rad_expence";
            this.rad_expence.Size = new System.Drawing.Size(67, 17);
            this.rad_expence.TabIndex = 9;
            this.rad_expence.TabStop = true;
            this.rad_expence.Text = "Expence";
            this.rad_expence.UseVisualStyleBackColor = true;
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(112, 209);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 23);
            this.btn_insert.TabIndex = 10;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // gd_ledger_view
            // 
            this.gd_ledger_view.AllowUserToAddRows = false;
            this.gd_ledger_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_ledger_view.Location = new System.Drawing.Point(210, 71);
            this.gd_ledger_view.Name = "gd_ledger_view";
            this.gd_ledger_view.Size = new System.Drawing.Size(386, 265);
            this.gd_ledger_view.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ledger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 367);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gd_ledger_view);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.rad_expence);
            this.Controls.Add(this.rad_income);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ledger_name);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txt_ledger_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "ledger";
            this.Text = "ledger";
            this.Load += new System.EventHandler(this.ledger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gd_ledger_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ledger_id;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txt_ledger_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rad_income;
        private System.Windows.Forms.RadioButton rad_expence;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.DataGridView gd_ledger_view;
        private System.Windows.Forms.Button button1;
    }
}