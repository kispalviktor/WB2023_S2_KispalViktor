using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _2026._10._05_alapok2
{
    class data
    {
        public string name { get; }
        public int ferfi { get; }
        public int no { get; }
        public int osszesen
        {
            get
            {
                return ferfi + no;
            }
        }

        public data(string line)
        {
            string[] sz = line.Split('\t');
            this.name = sz[0];
            this.ferfi = int.Parse(sz[1]);
            this.no = int.Parse(sz[2]);
        }
    }
    public partial class Form1 : Form
    {
        private void letszamok()
        {
            int a = comboBox1.SelectedIndex;
            lblFerfi.Text = telepulesek[a].ferfi.ToString() + " férfi";
            lblNo.Text = telepulesek[a].no.ToString() + " nő";
            lblOsszesen.Text = telepulesek[a].osszesen.ToString() + " összessen";
        }
        static List<data> telepulesek = new List<data>();
        static void fileBetoltes(string fileName)
        {
            string[] fileData = File.ReadAllLines(fileName, Encoding.UTF8);
            telepulesek.Clear();
            foreach(string line in fileData)
            {
                try
                {
                    data tmp = new data(line);
                    telepulesek.Add(tmp);
                }
                catch (Exception)
                {

                }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void kilepesGomb(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Kilépés";
            lblTelepules.Text = "Település";
            fileBetoltes("telepulesek.txt");
            comboBox1.Items.Clear();
            foreach(var item in telepulesek)
            {
                comboBox1.Items.Add(item.name);
            }
            comboBox1.SelectedItem = "Kiskunfélegyháza";
            // comboBox1.SelectedIndex = 13;
            letszamok();
        }

        private void comboBox1_change(object sender, EventArgs e)
        {
            letszamok();
        }
    }
}
