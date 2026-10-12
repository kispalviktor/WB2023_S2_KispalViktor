namespace _2026._10._05_DinamikusGrafika
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
            this.nUDSor = new System.Windows.Forms.NumericUpDown();
            this.nUDOszlop = new System.Windows.Forms.NumericUpDown();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblSor = new System.Windows.Forms.Label();
            this.lblOszlop = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nUDSor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDOszlop)).BeginInit();
            this.SuspendLayout();
            // 
            // nUDSor
            // 
            this.nUDSor.Location = new System.Drawing.Point(26, 24);
            this.nUDSor.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUDSor.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nUDSor.Name = "nUDSor";
            this.nUDSor.Size = new System.Drawing.Size(53, 20);
            this.nUDSor.TabIndex = 0;
            this.nUDSor.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // nUDOszlop
            // 
            this.nUDOszlop.Location = new System.Drawing.Point(110, 24);
            this.nUDOszlop.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUDOszlop.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nUDOszlop.Name = "nUDOszlop";
            this.nUDOszlop.Size = new System.Drawing.Size(49, 20);
            this.nUDOszlop.TabIndex = 1;
            this.nUDOszlop.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(190, 21);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Létrehoz";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblSor
            // 
            this.lblSor.AutoSize = true;
            this.lblSor.Location = new System.Drawing.Point(23, 8);
            this.lblSor.Name = "lblSor";
            this.lblSor.Size = new System.Drawing.Size(68, 13);
            this.lblSor.TabIndex = 3;
            this.lblSor.Text = "Sorok száma";
            // 
            // lblOszlop
            // 
            this.lblOszlop.AutoSize = true;
            this.lblOszlop.Location = new System.Drawing.Point(107, 8);
            this.lblOszlop.Name = "lblOszlop";
            this.lblOszlop.Size = new System.Drawing.Size(84, 13);
            this.lblOszlop.TabIndex = 4;
            this.lblOszlop.Text = "Oszlopok száma";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOszlop);
            this.Controls.Add(this.lblSor);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.nUDOszlop);
            this.Controls.Add(this.nUDSor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUDSor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDOszlop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nUDSor;
        private System.Windows.Forms.NumericUpDown nUDOszlop;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblSor;
        private System.Windows.Forms.Label lblOszlop;
    }
}

