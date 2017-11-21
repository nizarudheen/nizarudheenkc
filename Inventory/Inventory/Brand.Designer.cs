namespace Inventory
{
    partial class Brand
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
            this.txt_brand_name = new System.Windows.Forms.TextBox();
            this.txt_brand_id = new System.Windows.Forms.TextBox();
            this.btn_upload = new System.Windows.Forms.Button();
            this.gd_brand = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gd_brand)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "brand id";
            // 
            // txt_brand_name
            // 
            this.txt_brand_name.Location = new System.Drawing.Point(104, 96);
            this.txt_brand_name.Name = "txt_brand_name";
            this.txt_brand_name.Size = new System.Drawing.Size(100, 20);
            this.txt_brand_name.TabIndex = 1;
            this.txt_brand_name.TextChanged += new System.EventHandler(this.txt_brand_name_TextChanged);
            this.txt_brand_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_brand_name_KeyDown);
            // 
            // txt_brand_id
            // 
            this.txt_brand_id.Location = new System.Drawing.Point(104, 55);
            this.txt_brand_id.Name = "txt_brand_id";
            this.txt_brand_id.Size = new System.Drawing.Size(100, 20);
            this.txt_brand_id.TabIndex = 2;
            // 
            // btn_upload
            // 
            this.btn_upload.Location = new System.Drawing.Point(238, 55);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(75, 23);
            this.btn_upload.TabIndex = 3;
            this.btn_upload.Text = "upload";
            this.btn_upload.UseVisualStyleBackColor = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // gd_brand
            // 
            this.gd_brand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_brand.Location = new System.Drawing.Point(12, 181);
            this.gd_brand.Name = "gd_brand";
            this.gd_brand.Size = new System.Drawing.Size(399, 150);
            this.gd_brand.TabIndex = 4;
            this.gd_brand.ColumnHeadersHeightChanged += new System.EventHandler(this.r);
            this.gd_brand.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.r);
            this.gd_brand.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gd_brand_RowHeaderMouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "brand name";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(238, 96);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 7;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Brand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 390);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gd_brand);
            this.Controls.Add(this.btn_upload);
            this.Controls.Add(this.txt_brand_id);
            this.Controls.Add(this.txt_brand_name);
            this.Controls.Add(this.label1);
            this.Name = "Brand";
            this.Text = "Brand";
            this.Load += new System.EventHandler(this.Brand_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gd_brand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_brand_name;
        private System.Windows.Forms.TextBox txt_brand_id;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.DataGridView gd_brand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button button1;
    }
}