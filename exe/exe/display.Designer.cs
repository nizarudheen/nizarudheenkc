namespace exe
{
    partial class display
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
            ((System.ComponentModel.ISupportInitialize)(this.gd_view)).BeginInit();
            this.SuspendLayout();
            // 
            // gd_view
            // 
            this.gd_view.AllowUserToAddRows = false;
            this.gd_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_view.Location = new System.Drawing.Point(1, 0);
            this.gd_view.Name = "gd_view";
            this.gd_view.Size = new System.Drawing.Size(763, 298);
            this.gd_view.TabIndex = 0;
            // 
            // display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 310);
            this.Controls.Add(this.gd_view);
            this.Name = "display";
            this.Text = "display";
            this.Load += new System.EventHandler(this.display_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gd_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gd_view;
    }
}