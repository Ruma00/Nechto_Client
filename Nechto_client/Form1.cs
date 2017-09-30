using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nechto_client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Init()
        {
            dataGridView1.RowCount = 4;
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 2; j++)
                    dataGridView1[j, i].Value = Image.FromFile("");//init image
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pictureBox2.Image = Image.FromFile("");//image from cell
        }
    }
}
