using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrices
{
    public partial class Form1 : Form
    {
        Matrix objMatrix;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            objMatrix = new Matrix();
        }

        private void setMatrixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rows, columns, min, max;
            rows = int.Parse(textBox1.Text);
            columns = int.Parse(textBox2.Text);
            min = int.Parse(textBox3.Text);
            max = int.Parse(textBox4.Text);
            objMatrix.SetData(rows, columns, min, max);
        }

        private void getMatrixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txbMatrix.Text = objMatrix.GetData();
        }
    }
}
