using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prac
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            ClassInfo.Add(Int32.Parse(AddID.SelectedItem.ToString()),Int32.Parse(CountMork.Text), Int32.Parse(CountKart.Text),ClassInfo.info);
            MessageBox.Show("Добавление записи прошло успешно");
        }
        public static int id;
        private void button2_Click(object sender, EventArgs e)
        {
            id = Int32.Parse(InfoID.SelectedItem.ToString());
            ClassInfo.pr1 = true;
            Form f = new Form2();
            f.Show();
        }
        public static int CountCheck;
        private void button3_Click(object sender, EventArgs e)
        {
            CountCheck = Int32.Parse(textBox1.Text);
            ClassInfo.pr2 = true;
            Form f = new Form2();
          
            f.Show();
        }
    }
}
