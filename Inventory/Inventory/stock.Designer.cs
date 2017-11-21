namespace Inventory
{
    partial class stock
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
            this.gd_stock_view = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_stock_search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gd_stock_view)).BeginInit();
            this.SuspendLayout();
            // 
            // gd_stock_view
            // 
            this.gd_stock_view.AllowUserToAddRows = false;
            this.gd_stock_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_stock_view.Location = new System.Drawing.Point(12, 67);
            this.gd_stock_view.Name = "gd_stock_view";
            this.gd_stock_view.Size = new System.Drawing.Size(691, 251);
            this.gd_stock_view.TabIndex = 1;
            this.gd_stock_view.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gd_stock_view_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search";
            // 
            // txt_stock_search
            // 
            this.txt_stock_search.Location = new System.Drawing.Point(87, 17);
            this.txt_stock_search.Name = "txt_stock_search";
            this.txt_stock_search.Size = new System.Drawing.Size(100, 20);
            this.txt_stock_search.TabIndex = 4;
            this.txt_stock_search.TextChanged += new System.EventHandler(this.txt_stock_search_TextChanged);
            // 
            // stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 341);
            this.Controls.Add(this.txt_stock_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gd_stock_view);
            this.Name = "stock";
            this.Text = "stock";
            this.Load += new System.EventHandler(this.stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gd_stock_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gd_stock_view;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_stock_search;
    }
}