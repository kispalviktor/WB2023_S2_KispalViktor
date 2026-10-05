namespace _2026._10._05_alapok2
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblNo = new System.Windows.Forms.Label();
            this.lblOsszesen = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTelepules = new System.Windows.Forms.Label();
            this.lblFerfi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(35, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(comboBox1_change);
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Location = new System.Drawing.Point(317, 58);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(35, 13);
            this.lblNo.TabIndex = 2;
            this.lblNo.Text = "label2";
            // 
            // lblOsszesen
            // 
            this.lblOsszesen.AutoSize = true;
            this.lblOsszesen.Location = new System.Drawing.Point(410, 58);
            this.lblOsszesen.Name = "lblOsszesen";
            this.lblOsszesen.Size = new System.Drawing.Size(35, 13);
            this.lblOsszesen.TabIndex = 3;
            this.lblOsszesen.Text = "label3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(410, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.kilepesGomb);
            // 
            // lblTelepules
            // 
            this.lblTelepules.AutoSize = true;
            this.lblTelepules.Location = new System.Drawing.Point(32, 34);
            this.lblTelepules.Name = "lblTelepules";
            this.lblTelepules.Size = new System.Drawing.Size(35, 13);
            this.lblTelepules.TabIndex = 5;
            this.lblTelepules.Text = "label1";
            // 
            // lblFerfi
            // 
            this.lblFerfi.AutoSize = true;
            this.lblFerfi.Location = new System.Drawing.Point(217, 58);
            this.lblFerfi.Name = "lblFerfi";
            this.lblFerfi.Size = new System.Drawing.Size(35, 13);
            this.lblFerfi.TabIndex = 6;
            this.lblFerfi.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 207);
            this.Controls.Add(this.lblFerfi);
            this.Controls.Add(this.lblTelepules);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblOsszesen);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Label lblOsszesen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTelepules;
        private System.Windows.Forms.Label lblFerfi;
    }
}

