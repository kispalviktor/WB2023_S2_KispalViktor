using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2026._09._21_alapok1
{
    public partial class Alapok : Form
    {
        public Alapok()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClientSize = new System.Drawing.Size(800, 600);
            int a = ClientSize.Width;
            int b = ClientSize.Height;
            int xnumUD = 0;
            int ynumUD = b - 20;
            nUD_Elso.Location = new System.Drawing.Point(xnumUD, ynumUD);

        }

        private void Form1_Change(object sender, EventArgs e)
        {
            int a = ClientSize.Width;
            int b = ClientSize.Height;
            int xnumUD = 0;
            int ynumUD = b - 20;
            nUD_Elso.Location = new System.Drawing.Point(xnumUD, ynumUD);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnExit_Hover(object sender, EventArgs e)
        {
            btnExit.Text = "Kilépés";
            btnExit.ForeColor = Color.Green;
        }

        private void nUD_Elso_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
