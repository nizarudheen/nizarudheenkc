namespace Inventory
{
    partial class sales_man_view
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
            this.gd_sl_man_view = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_sales_man_search = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gd_sl_man_view)).BeginInit();
            this.SuspendLayout();
            // 
            // gd_sl_man_view
            // 
            this.gd_sl_man_view.AllowUserToAddRows = false;
            this.gd_sl_man_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_sl_man_view.Location = new System.Drawing.Point(12, 64);
            this.gd_sl_man_view.Name = "gd_sl_man_view";
            this.gd_sl_man_view.Size = new System.Drawing.Size(673, 389);
            this.gd_sl_man_view.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "search";
            // 
            // txt_sales_man_search
            // 
            this.txt_sales_man_search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_sales_man_search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_sales_man_search.FormattingEnabled = true;
            this.txt_sales_man_search.Location = new System.Drawing.Point(105, 30);
            this.txt_sales_man_search.Name = "txt_sales_man_search";
            this.txt_sales_man_search.Size = new System.Drawing.Size(297, 21);
            this.txt_sales_man_search.TabIndex = 3;
            this.txt_sales_man_search.SelectedIndexChanged += new System.EventHandler(this.txt_sales_man_search_SelectedIndexChanged);
            // 
            // sales_man_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 465);
            this.Controls.Add(this.txt_sales_man_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gd_sl_man_view);
            this.Name = "sales_man_view";
            this.Text = "sales_man_view";
            this.Load += new System.EventHandler(this.sales_man_view_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gd_sl_man_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gd_sl_man_view;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txt_sales_man_search;
    }
}