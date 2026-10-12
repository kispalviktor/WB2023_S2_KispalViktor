using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2026._10._12_VektorGomb
{
    public partial class Form1 : Form
    {
        static Button[,] gombok = new Button[1, 1];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            foreach (var item in gombok)
            {
                Controls.Remove(item);
            }

            int sorokSzama = Convert.ToInt32(nUDSzam.Value);

            gombok = new Button[sorokSzama, 1];

            for (int sor = 0; sor < sorokSzama; sor++)
            {
                for (int oszlop = 0; oszlop < 1; oszlop++)
                {
                    gombok[sor, oszlop] = new Button();
                    gombok[sor, oszlop].Location = new System.Drawing.Point(26 + oszlop, 60 + sor * 20);
                    gombok[sor, oszlop].Name = "btn" + sor.ToString();
                    gombok[sor, oszlop].Size = new System.Drawing.Size(40, 20);
                    gombok[sor, oszlop].TabIndex = 3 + sor;
                    gombok[sor, oszlop].Text = $"{sor + 1}";
                    gombok[sor, oszlop].UseVisualStyleBackColor = true;
                    gombok[sor, oszlop].Visible = true;
                    gombok[sor, oszlop].Enabled = true;
                    Controls.Add(gombok[sor, oszlop]);
                }
            }
        }
    }
}
