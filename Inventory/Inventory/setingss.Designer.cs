namespace Inventory
{
    partial class setingss
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rad_no = new System.Windows.Forms.RadioButton();
            this.rad_yes = new System.Windows.Forms.RadioButton();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.Location = new System.Drawing.Point(16, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(316, 26);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Do you want to print bill ?";
            // 
            // rad_no
            // 
            this.rad_no.AutoSize = true;
            this.rad_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_no.Location = new System.Drawing.Point(31, 82);
            this.rad_no.Name = "rad_no";
            this.rad_no.Size = new System.Drawing.Size(41, 17);
            this.rad_no.TabIndex = 7;
            this.rad_no.TabStop = true;
            this.rad_no.Text = "No";
            this.rad_no.UseVisualStyleBackColor = true;
            this.rad_no.CheckedChanged += new System.EventHandler(this.rad_no_CheckedChanged);
            // 
            // rad_yes
            // 
            this.rad_yes.AutoSize = true;
            this.rad_yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_yes.Location = new System.Drawing.Point(31, 59);
            this.rad_yes.Name = "rad_yes";
            this.rad_yes.Size = new System.Drawing.Size(46, 17);
            this.rad_yes.TabIndex = 6;
            this.rad_yes.TabStop = true;
            this.rad_yes.Text = "Yes";
            this.rad_yes.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(448, 283);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // setingss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 318);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rad_no);
            this.Controls.Add(this.rad_yes);
            this.Name = "setingss";
            this.Text = "setingss";
            this.Load += new System.EventHandler(this.setingss_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rad_no;
        private System.Windows.Forms.RadioButton rad_yes;
        private System.Windows.Forms.Button buttonSave;
    }
}