using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_работа_3_
{
    public partial class CalculateForm : Form
    {
        public CalculateForm()
        {
            InitializeComponent();
            tileSize[0, 0] = 10; tileSize[0, 1] = 10;
            tileSize[1, 0] = 15; tileSize[1, 1] = 15;
            tileSize[2, 0] = 10; tileSize[2, 1] = 15;
            tileSize[3, 0] = 20; tileSize[3, 1] = 20;
            tileCount[0] = 8;
            tileCount[1] = 10;
            tileCount[2] = 12;
            tileCount[3] = 20;
            for (int i = 0; i < n; i++) 
                comboBox1.Items.Add(String.Format("{0}x{1}", tileSize[i, 0], tileSize[i, 1]));
            for (int i = 0; i < n; i++)
                comboBox2.Items.Add(String.Format("{0}", tileCount[i]));
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private static short n = 4; 
        private short[,] tileSize = new short[n, 2]; 
        private short[] tileCount = new short[n];

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            decimal sum,s,ss,dec;
            int a=100, b=225, c=150, d=400, v=0;
            if (comboBox1.SelectedIndex == 0)
                v = a;
            if (comboBox1.SelectedIndex == 1)
                v = b;
            if (comboBox1.SelectedIndex == 2)
                v = c;
            if (comboBox1.SelectedIndex == 3)
                v = d;
            s = Int32.Parse(textBox1.Text) * Int32.Parse(textBox2.Text);
            ss = v * Int32.Parse(comboBox2.Text);
            sum = s / ss;
            dec = Math.Ceiling(sum);
            textBox3.Text = dec.ToString();
        }
    }
}
