namespace Inventory
{
    partial class item_views
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
            this.gd_view = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_view_search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gd_view)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gd_view
            // 
            this.gd_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gd_view.Location = new System.Drawing.Point(0, 0);
            this.gd_view.Name = "gd_view";
            this.gd_view.Size = new System.Drawing.Size(972, 551);
            this.gd_view.TabIndex = 0;
            this.gd_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gd_view_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gd_view);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(972, 551);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_view_search);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 64);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search";
            // 
            // txt_view_search
            // 
            this.txt_view_search.Location = new System.Drawing.Point(100, 35);
            this.txt_view_search.Name = "txt_view_search";
            this.txt_view_search.Size = new System.Drawing.Size(100, 20);
            this.txt_view_search.TabIndex = 4;
            // 
            // item_views
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 626);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "item_views";
            this.Text = "item_views";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.item_views_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gd_view)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gd_view;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_view_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;

    }
}