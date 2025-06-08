using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElenilsonDescubraNumeroSequencia
{
    public partial class Jogo : Form
    {
        int[] iNumerosSequencia = new int[6];

        Random random = new Random();

        int iAcertos = 0;
        int iErros = 0;

        public Jogo()
        {
            InitializeComponent();
            GerarNumerosSequencia();
        }

        private void GerarNumerosSequencia()
        {
            int iNumeroSoma = random.Next(3, 9); ;

            iNumerosSequencia[0] = random.Next(1, 50);
            
            for(int i = 1; i < iNumerosSequencia.Length; i++)
            {
                iNumerosSequencia[i] = iNumerosSequencia[0] + iNumeroSoma * i;
            }

            btnAzul.Text = iNumerosSequencia[0].ToString();
            btnVermelho.Text = iNumerosSequencia[1].ToString();
            btnLaranja.Text = iNumerosSequencia[2].ToString();
            btnVerde.Text = iNumerosSequencia[3].ToString();
            btnRoxo.Text = iNumerosSequencia[4].ToString();
        }
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNumeroSugerido.Text))
            {
                int iNumeroSugerido = Convert.ToInt32(txtNumeroSugerido.Text);

                if (iNumerosSequencia[5] == iNumeroSugerido)
                {
                    iAcertos++;
                    lblNumerosAcertos.Text = iAcertos.ToString();
                }
                else
                {
                    iErros++;
                    lblNumerosErros.Text = iErros.ToString();
                }

                GerarNumerosSequencia();

                txtNumeroSugerido.Text = "";
                txtNumeroSugerido.Focus();

                if (iAcertos == 3)
                {
                    MessageBox.Show("Parabéns, você venceu!");

                    Menu menu = new Menu();
                    menu.Show();
                    this.Close();
                }
                else if(iErros == 2)
                {
                    MessageBox.Show("Você perdeu, tente de novo!");

                    Menu menu = new Menu();
                    menu.Show();
                    this.Close();
                }
                else
                {

                }
            }
        }
    }
}
