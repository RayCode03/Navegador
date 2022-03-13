using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navegador
{
    public partial class Form1 : Form
    {

        List<string> Favoristos = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Navegador.Navigate(UrlNavega.Text);
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Navegador.Navigate(UrlNavega.Text);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Navegador.GoBack();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Navegador.GoForward();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Navegador.Refresh();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Navegador.Stop();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Navegador.GoHome(); 
        }

        private void btnFavorito_Click(object sender, EventArgs e)
        {
            Favoristos.Add(Navegador.Url.ToString());
            ActualizarCom();


        }

        private void ActualizarCom()
        {
            foreach(String direccion in Favoristos)
            {
                cmbf.Items.Add(direccion);
            }
        }

        private void cmbf_SelectedIndexChanged(object sender, EventArgs e)
        {
            Navegador.Navigate(cmbf.SelectedItem.ToString());
        }
    }
}
