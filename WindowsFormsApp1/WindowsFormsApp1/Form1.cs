using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btncalcular_Click(object sender, EventArgs e)
        {
            n1 = txtnt1.Text;
            n2 = txtnt1.Text;
            n3 = txtnt3.Text;

            prom = (n1 + n2 + n3) / 3;

                RESULTADO_PROMEDIO = prom;
        }
    }
}
