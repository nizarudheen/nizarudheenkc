namespace Inventory
{
    partial class balance_sheet
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
            this.gd_balance = new System.Windows.Forms.DataGridView();
            this.db_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db_amound = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cr_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cr_amound = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gd_balance)).BeginInit();
            this.SuspendLayout();
            // 
            // gd_balance
            // 
            this.gd_balance.AllowUserToAddRows = false;
            this.gd_balance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_balance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.db_date,
            this.debit,
            this.db_amound,
            this.cr_date,
            this.credit,
            this.cr_amound});
            this.gd_balance.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gd_balance.Location = new System.Drawing.Point(0, 96);
            this.gd_balance.Name = "gd_balance";
            this.gd_balance.Size = new System.Drawing.Size(819, 596);
            this.gd_balance.TabIndex = 0;
            // 
            // db_date
            // 
            this.db_date.HeaderText = "Db_Date";
            this.db_date.Name = "db_date";
            // 
            // debit
            // 
            this.debit.HeaderText = "Debits";
            this.debit.Name = "debit";
            this.debit.Width = 150;
            // 
            // db_amound
            // 
            this.db_amound.HeaderText = "db_amound";
            this.db_amound.Name = "db_amound";
            // 
            // cr_date
            // 
            this.cr_date.HeaderText = "Cr_Date";
            this.cr_date.Name = "cr_date";
            // 
            // credit
            // 
            this.credit.HeaderText = "Credit";
            this.credit.Name = "credit";
            this.credit.Width = 150;
            // 
            // cr_amound
            // 
            this.cr_amound.HeaderText = "Cr_amound";
            this.cr_amound.Name = "cr_amound";
            // 
            // balance_sheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 692);
            this.Controls.Add(this.gd_balance);
            this.Name = "balance_sheet";
            this.Text = "balance_sheet";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.balance_sheet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gd_balance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gd_balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn db_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn debit;
        private System.Windows.Forms.DataGridViewTextBoxColumn db_amound;
        private System.Windows.Forms.DataGridViewTextBoxColumn cr_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cr_amound;
    }
}