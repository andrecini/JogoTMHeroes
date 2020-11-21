using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JogoTermoHeros.JogoPrincipal;


namespace JogoTermoHeros
{
    public partial class EscolhaDePersonagens : Form
    {
        public EscolhaDePersonagens()
        {
            InitializeComponent();
        }

        private void EscolhaDePersonagens_Load(object sender, EventArgs e)
        {
            picDireita.Parent = picGif;
            picEsquerda.Parent = picGif;
            picTitulo.Parent = picGif;
            picPersonagens.Parent = picGif;
        }

        public int contPersonagem = 0;
        private void picDireita_Click(object sender, EventArgs e)
        {
            contPersonagem++;
            if (contPersonagem == 0)
            {
                picPersonagens.Image = imageList1.Images[contPersonagem];
            }
            else if (contPersonagem == 1)
            {
                picPersonagens.Image = imageList1.Images[contPersonagem];
            }
         /* else if (contPersonagem == 2)
            {
                picPersonagens.Image = imageList1.Images[contPersonagem];
            }*/
            else 
            {
                contPersonagem = 1;
                picPersonagens.Image = imageList1.Images[contPersonagem];
            }
        }

        private void picEsquerda_Click(object sender, EventArgs e)
        {
            contPersonagem--;
            if (contPersonagem == 0)
            {
                picPersonagens.Image = imageList1.Images[contPersonagem];
            }
            else if (contPersonagem == 1)
            {
                picPersonagens.Image = imageList1.Images[contPersonagem];
            }
            /*else if (contPersonagem == 2)
            {
                picPersonagens.Image = imageList1.Images[contPersonagem];
            }*/
            else
            {
                contPersonagem = 1;
                picPersonagens.Image = imageList1.Images[contPersonagem];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            jogoPrincipal screen = new jogoPrincipal();
            this.Hide();
            screen.ShowDialog();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
