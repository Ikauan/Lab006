using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab006.Lab00
{
    public partial class Telaprincipal : Form
    {
        public Telaprincipal()
        {
            InitializeComponent();
        }

        public void MaiorDeTres()
        {
            int valor1 = Convert.ToInt32(nudValor1.Text);
            int valor2 = Convert.ToInt32(nudValor2.Text);
            int valor3 = Convert.ToInt32(nudValor3.Text);


            if (valor1 > valor2)
            {
                if (valor1 > valor3)
                {
                    lblResultado.Text = valor1.ToString();
                }
                else
                {
                    lblResultado.Text = valor3.ToString();
                }
            }
            else if (valor2 > valor3)
                lblResultado.Text = valor2.ToString();
            else
                lblResultado.Text = valor3.ToString();

        }

        private void Telaprincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            MaiorDeTres();
            
        }
    }
}
