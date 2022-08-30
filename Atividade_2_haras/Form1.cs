using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_2_haras
{
    public partial class frmHaras : Form
    {
        public frmHaras()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
            //fApplication.Exit()
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            txtNum1.Text = String.Empty;
            txtResultado.Clear();
            lblResultado.Text = String.Empty;
        }


        private void Calcular_Click(object sender, EventArgs e)
        {
            int numero, total;
            //atribuir valor a variável

            numero = int.Parse(txtNum1.Text);
            //processamento

            total = (numero) * 4;

            //Saída
            lblResultado.Text = "Vão ser " + total + " ferraduras";
            txtResultado.Text = "Vão ser " + total + " ferraduras";
            MessageBox.Show("O resultado é " + total, "Resultado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
        }
    }
}
