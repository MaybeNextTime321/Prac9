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
    public partial class ConstructForm : Form
    {
        public ConstructForm()
        {
            InitializeComponent();
        }
        private int indexOfFlat; 
        private bool flat = false;
        private int indexOfDecor; 
        private int sizeOfDecor = 50; 
        private List<PictureBox> decors = new List<PictureBox>();

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListView1_MouseDown(object sender, MouseEventArgs e)
        {
            flat = true;
            indexOfFlat = FlatList.Items.IndexOf(FlatList.GetItemAt(e.X, e.Y));
            if (indexOfFlat != -1) //если удалось определить индекс
            {
                FlatList.DoDragDrop(FlatList.Items[indexOfFlat].ImageIndex,
                DragDropEffects.Copy);
            }
        }

        private void Panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void Panel1_DragDrop(object sender, DragEventArgs e)
        {
            if (flat)
            {
                pnlView.BackgroundImage = imgListFlat.Images[indexOfFlat];
            }
            else 
            {
                decors.Add(new PictureBox());
                pnlView.Controls.Add(decors[decors.Count - 1]);
                decors[decors.Count - 1].Width = decors[decors.Count - 1].Height = sizeOfDecor;
                decors[decors.Count - 1].Image = imgListDecor.Images[indexOfDecor];
                decors[decors.Count - 1].MouseUp +=
                new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            }

        }
        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox img = sender as PictureBox;
                {
                    img.Left = img.Left + e.X - img.Width / 2;
                    img.Top = img.Top + e.Y - img.Height / 2;
                }
            }
        }

        private void ListView2_MouseDown(object sender, MouseEventArgs e)
        {
            flat = false;
            indexOfDecor = DecorList.Items.IndexOf(DecorList.GetItemAt(e.X, e.Y));
            if (indexOfDecor != -1)
            {
                DecorList.DoDragDrop(DecorList.Items[indexOfDecor].ImageIndex,
                DragDropEffects.Copy);
            }
        }

        private void ConstructForm_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            pnlView.BackgroundImage = null;
            pnlView.Controls.Clear();
        }
    }
}
