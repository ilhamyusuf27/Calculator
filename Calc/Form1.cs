using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(nilaia.Text);
            var b = Convert.ToInt32(nilaib.Text);
            Double nilai;
            switch (operasi.SelectedIndex)
            {
                case 0:
                    nilai = a + b;
                    hasil.Text = Convert.ToString(nilai);
                    break;
                case 1:
                    nilai = a - b;
                    hasil.Text = Convert.ToString(nilai);
                    break;
                case 2:
                    nilai = a * b;
                    hasil.Text = Convert.ToString(nilai);
                    break;
                case 3:
                    nilai = a / b;
                    hasil.Text = Convert.ToString(nilai);
                    break;
            }
        }
    }
}
