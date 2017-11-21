namespace image
{
    partial class Form1
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
            this.txt_addno = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.mkkkkj = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ptr_box = new System.Windows.Forms.PictureBox();
            this.gd_details = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_browse = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.fd = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_nmsearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gd_details)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_addno
            // 
            this.txt_addno.Location = new System.Drawing.Point(85, 65);
            this.txt_addno.Name = "txt_addno";
            this.txt_addno.Size = new System.Drawing.Size(100, 20);
            this.txt_addno.TabIndex = 0;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(85, 115);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 1;
            // 
            // mkkkkj
            // 
            this.mkkkkj.AutoSize = true;
            this.mkkkkj.Location = new System.Drawing.Point(12, 65);
            this.mkkkkj.Name = "mkkkkj";
            this.mkkkkj.Size = new System.Drawing.Size(51, 13);
            this.mkkkkj.TabIndex = 3;
            this.mkkkkj.Text = "admn_no";
            this.mkkkkj.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ptr_box
            // 
            this.ptr_box.Location = new System.Drawing.Point(85, 158);
            this.ptr_box.Name = "ptr_box";
            this.ptr_box.Size = new System.Drawing.Size(100, 92);
            this.ptr_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptr_box.TabIndex = 6;
            this.ptr_box.TabStop = false;
            this.ptr_box.Click += new System.EventHandler(this.ptr_box_Click);
            // 
            // gd_details
            // 
            this.gd_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_details.Location = new System.Drawing.Point(268, 90);
            this.gd_details.Name = "gd_details";
            this.gd_details.Size = new System.Drawing.Size(333, 150);
            this.gd_details.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "image";
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(73, 256);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(75, 23);
            this.btn_browse.TabIndex = 9;
            this.btn_browse.Text = "browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(12, 319);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 23);
            this.btn_insert.TabIndex = 10;
            this.btn_insert.Text = "insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // fd
            // 
            this.fd.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_nmsearch
            // 
            this.txt_nmsearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_nmsearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_nmsearch.Location = new System.Drawing.Point(268, 58);
            this.txt_nmsearch.Name = "txt_nmsearch";
            this.txt_nmsearch.Size = new System.Drawing.Size(257, 20);
            this.txt_nmsearch.TabIndex = 14;
            this.txt_nmsearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_nmsearch_MouseClick);
            this.txt_nmsearch.TextChanged += new System.EventHandler(this.txt_nmsearch_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 400);
            this.Controls.Add(this.txt_nmsearch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gd_details);
            this.Controls.Add(this.ptr_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mkkkkj);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_addno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptr_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gd_details)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_addno;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label mkkkkj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ptr_box;
        private System.Windows.Forms.DataGridView gd_details;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.OpenFileDialog fd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_nmsearch;
    }
}

