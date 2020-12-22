using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_работа_3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'А' || e.KeyChar > 'я') && (e.KeyChar != 8))
                e.Handled = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            ToolTip t = new ToolTip();
            t.SetToolTip(textBox1, "Введите имя");
            ToolTip t1 = new ToolTip();
            t1.SetToolTip(textBox2, "Введите фамилию");
            ToolTip t2 = new ToolTip();
            t2.SetToolTip(button1, "Нажмите, чтобы выйти");
            ToolTip t3 = new ToolTip();
            t3.SetToolTip(button2, "Нажмите, чтобы выбрать изображение");
            ToolTip t4 = new ToolTip();
            t4.SetToolTip(button3, "Нажмите, чтобы увидеть превью");
            ToolTip t5 = new ToolTip();
            t5.SetToolTip(pictureBox1, "Это ваше изображение");

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName); //загружаем изображение в компонент
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (textBox1.Text != "") && (openFileDialog1.FileName != ""))
            {
                PreviewForm previewFrm = new PreviewForm(textBox1.Text, textBox2.Text, comboBox1.Text, openFileDialog1.FileName);
                previewFrm.ShowDialog();
            }
        }
    }
}
