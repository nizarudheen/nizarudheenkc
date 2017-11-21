namespace Inventory
{
    partial class category
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_catg_id = new System.Windows.Forms.TextBox();
            this.txt_catg_name = new System.Windows.Forms.TextBox();
            this.upload = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.gd_details_catg = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gd_details_catg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category name";
            // 
            // txt_catg_id
            // 
            this.txt_catg_id.Location = new System.Drawing.Point(128, 111);
            this.txt_catg_id.Name = "txt_catg_id";
            this.txt_catg_id.Size = new System.Drawing.Size(100, 20);
            this.txt_catg_id.TabIndex = 2;
            // 
            // txt_catg_name
            // 
            this.txt_catg_name.Location = new System.Drawing.Point(128, 150);
            this.txt_catg_name.Name = "txt_catg_name";
            this.txt_catg_name.Size = new System.Drawing.Size(100, 20);
            this.txt_catg_name.TabIndex = 3;
            // 
            // upload
            // 
            this.upload.Location = new System.Drawing.Point(249, 148);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(75, 23);
            this.upload.TabIndex = 6;
            this.upload.Text = "UPLOAD";
            this.upload.UseVisualStyleBackColor = true;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(441, 147);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 7;
            this.clear.Text = "CLEAR";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // gd_details_catg
            // 
            this.gd_details_catg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_details_catg.Location = new System.Drawing.Point(32, 242);
            this.gd_details_catg.Name = "gd_details_catg";
            this.gd_details_catg.Size = new System.Drawing.Size(494, 150);
            this.gd_details_catg.TabIndex = 8;
            this.gd_details_catg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gd_details_catg_CellContentClick);
            this.gd_details_catg.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gd_details_catg_RowHeaderMouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "CATEGORY DETAILS";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(345, 148);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 10;
            this.btn_update.Text = "update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 404);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gd_details_catg);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.upload);
            this.Controls.Add(this.txt_catg_name);
            this.Controls.Add(this.txt_catg_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "category";
            this.Text = "category";
            this.Load += new System.EventHandler(this.category_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gd_details_catg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_catg_id;
        private System.Windows.Forms.TextBox txt_catg_name;
        private System.Windows.Forms.Button upload;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.DataGridView gd_details_catg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_update;
    }
}