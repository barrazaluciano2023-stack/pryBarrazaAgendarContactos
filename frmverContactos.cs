using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace pryBarrazaAgendarContactos
{
    public partial class frmverContactos : Form
    {
        private frmAgendaContactos? vecNombres;
        private frmAgendaContactos? vecNumeros;
        private string[] vecNombresLocal;
        private string[] vecNumerosLocal;
        int indice = 0;
        public frmverContactos(string[] Vecnombres, string[] vecNumeros)
        {
            InitializeComponent();
            vecNombresLocal = Vecnombres;
            vecNumerosLocal = vecNumeros;
            lblDatosContactos.Text = "Nombre: " + vecNombresLocal[0] + " Numero: " + vecNumerosLocal[0];
        }



        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            while (indice <= 4)
            {
                btnSiguiente.Enabled = true;
                btnAnterior.Enabled = true;
                indice++;
                lblDatosContactos.Text = "Nombre: " + vecNombresLocal[indice] + " Numero: " + vecNumerosLocal[indice];
                break;
            }
            if (indice == 4)
            {
                btnSiguiente.Enabled = false;
            }
        }

        private void lblDatosContactos_Click(object sender, EventArgs e)
        {

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            while (indice > 0)
            {
                btnAnterior.Enabled = true;
                indice--;
                lblDatosContactos.Text = "Nombre: " + vecNombresLocal[indice] + " Numero: " + vecNumerosLocal[indice];
                break;
            }
            if (indice == 0)
            {
                btnAnterior.Enabled = false;
                btnSiguiente.Enabled = true;
            }
        }
    }
}
