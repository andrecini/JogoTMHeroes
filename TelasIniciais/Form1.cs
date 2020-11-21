using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoTermoHeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void iniciar_click(object sender, EventArgs e)
        {
            OpcoesDeGame screenOpcoes = new OpcoesDeGame();
            this.Hide();
            screenOpcoes.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox2.Parent = pictureBox1;
        }
    }
}
