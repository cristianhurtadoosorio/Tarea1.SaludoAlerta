using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taller1.promedio_de_notas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3, promedio;
            nota1 = double.Parse(txtnt1.Text);
            nota2 = double.Parse(txtnt2.Text);
            nota3 = double.Parse(txtnt3.Text);

            promedio = (nota1 + nota2 + nota3) / 3;

            lblresultado.Text = Convert.ToString( promedio);

            label5.Visible = true;
            lblresultado.Visible = true;
        }
    }
}
