namespace _2026._09._21_alapok1
{
    partial class Alapok
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
            this.nUD_Elso = new System.Windows.Forms.NumericUpDown();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Elso)).BeginInit();
            this.SuspendLayout();
            // 
            // nUD_Elso
            // 
            this.nUD_Elso.Location = new System.Drawing.Point(0, 0  );
            this.nUD_Elso.Margin = new System.Windows.Forms.Padding(2);
            this.nUD_Elso.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_Elso.Name = "nUD_Elso";
            this.nUD_Elso.Size = new System.Drawing.Size(52, 20);
            this.nUD_Elso.TabIndex = 0;
            this.nUD_Elso.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nUD_Elso.ValueChanged += new System.EventHandler(this.nUD_Elso_ValueChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(513, 331);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "button1";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseHover += new System.EventHandler(this.btnExit_Hover);
            this.Controls.Add(this.btnExit);
            // 
            // Alapok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.nUD_Elso);
            this.Name = "Alapok";
            this.Text = "Alapok";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ClientSizeChanged += new System.EventHandler(this.Form1_Change);
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Elso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown [] nUD_Elso = new System.Windows.Forms.NumericUpDown[5];
        private System.Windows.Forms.Button btnExit;
    }
}

