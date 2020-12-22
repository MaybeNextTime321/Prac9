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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (ClassInfo.pr1)
            {
                ClassInfo.pr1 = false;
                dataGridView1.ColumnCount = 2;
                dataGridView1.RowCount = 1;
                dataGridView1.Columns[0].HeaderText = "Морковь";
                dataGridView1.Columns[1].HeaderText = "Картофель";

                for (int i = 0; i <= 1; i++)
                {
                    dataGridView1.Rows[0].Cells[i].Value = ClassInfo.info[Form1.id, i];
                }
            }
            else { 
                if (ClassInfo.pr2)
                {
                    ClassInfo.pr2 = false;
                    int sum = 0;int k = 0;
                    for (int i =1; i <= 5; i++)
                    {
                        sum = 0;
                        for (int j=0; j<=1; j++)
                        {
                            sum += ClassInfo.info[i, j];

                        }
                        if (sum < Form1.CountCheck) k++;
                    }
                    dataGridView1.RowCount = k+1;
                    dataGridView1.ColumnCount = 3;
                    dataGridView1.Columns[0].HeaderText = "ID Склада";
                    dataGridView1.Columns[1].HeaderText = "Морковь";
                    dataGridView1.Columns[2].HeaderText = "Картофель";
                    int z = 0;
                    for (int i = 1; i <= 5; i++)
                    {
                        sum = 0;
                        for (int j = 0; j <= 1; j++)
                        {
                            sum += ClassInfo.info[i, j];

                        }
                        if (sum < Form1.CountCheck) {
                           dataGridView1.Rows[z].Cells[0].Value = i;
                            for (int e1 = 0; e1 <= 1; e1++)
                            {
                                dataGridView1.Rows[z].Cells[e1+1].Value = ClassInfo.info[i, e1];
                            }
                            z++;
                        }
                    }
                }
            }
        }
    }
}
