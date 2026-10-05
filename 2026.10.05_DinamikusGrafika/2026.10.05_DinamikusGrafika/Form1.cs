using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2026._10._05_DinamikusGrafika
{
    public partial class Form1 : Form
    {
        static Button[,] gombok = new Button[10, 10];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int sor = 0; sor < 10; sor++)
            {
                for (int oszlop = 0; oszlop < 10; oszlop++)
                {
                    gombok[sor, oszlop] = new Button();
                    gombok[sor, oszlop].Location = new System.Drawing.Point(26 + oszlop * 60, 60 + sor * 30);
                    gombok[sor, oszlop].Name = "btn" + sor.ToString() + oszlop.ToString();
                    gombok[sor, oszlop].Size = new System.Drawing.Size(50, 20);
                    gombok[sor, oszlop].TabIndex = 3 + sor * 10 + oszlop;
                    gombok[sor, oszlop].Text = $"{sor + 1}, {oszlop + 1}";
                    gombok[sor, oszlop].UseVisualStyleBackColor = true;
                    gombok[sor, oszlop].Visible = true;
                    gombok[sor, oszlop].Enabled = true;
                    Controls.Add(gombok[sor, oszlop]);
                }
            }
        }
    }
}
