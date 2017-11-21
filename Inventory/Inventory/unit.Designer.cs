namespace Inventory
{
    partial class unit
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
            this.btn_clear = new System.Windows.Forms.Button();
            this.BTN_INSERT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_unit_id = new System.Windows.Forms.TextBox();
            this.txt_unit_name = new System.Windows.Forms.TextBox();
            this.gd_unit = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gd_unit)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(362, 229);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 0;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // BTN_INSERT
            // 
            this.BTN_INSERT.Location = new System.Drawing.Point(146, 229);
            this.BTN_INSERT.Name = "BTN_INSERT";
            this.BTN_INSERT.Size = new System.Drawing.Size(75, 23);
            this.BTN_INSERT.TabIndex = 1;
            this.BTN_INSERT.Text = "INSERT";
            this.BTN_INSERT.UseVisualStyleBackColor = true;
            this.BTN_INSERT.Click += new System.EventHandler(this.BTN_INSERT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "unit id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "unit name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_unit_id
            // 
            this.txt_unit_id.Location = new System.Drawing.Point(121, 130);
            this.txt_unit_id.Name = "txt_unit_id";
            this.txt_unit_id.Size = new System.Drawing.Size(100, 20);
            this.txt_unit_id.TabIndex = 4;
            // 
            // txt_unit_name
            // 
            this.txt_unit_name.Location = new System.Drawing.Point(121, 180);
            this.txt_unit_name.Name = "txt_unit_name";
            this.txt_unit_name.Size = new System.Drawing.Size(100, 20);
            this.txt_unit_name.TabIndex = 5;
            // 
            // gd_unit
            // 
            this.gd_unit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_unit.Location = new System.Drawing.Point(19, 281);
            this.gd_unit.Name = "gd_unit";
            this.gd_unit.Size = new System.Drawing.Size(471, 150);
            this.gd_unit.TabIndex = 6;
            this.gd_unit.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gd_unit_RowHeaderMouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "UNIT DETAILS ";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(254, 229);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 8;
            this.btn_update.Text = "update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // unit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 457);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gd_unit);
            this.Controls.Add(this.txt_unit_name);
            this.Controls.Add(this.txt_unit_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_INSERT);
            this.Controls.Add(this.btn_clear);
            this.Name = "unit";
            this.Text = "unit";
            this.Load += new System.EventHandler(this.unit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gd_unit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button BTN_INSERT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_unit_id;
        private System.Windows.Forms.TextBox txt_unit_name;
        private System.Windows.Forms.DataGridView gd_unit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_update;
    }
}