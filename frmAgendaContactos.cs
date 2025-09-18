using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBarrazaAgendarContactos
{
    

    public partial class frmAgendaContactos : Form
    {
        int canContactos = 0;   
        public string[] vecNombres = new string[5];
        public string[] vecNumeros = new string[5];
        int indice = 0;

        public frmAgendaContactos()
        {
            InitializeComponent();
        }

        private void txtContacto_TextChanged(object sender, EventArgs e)

        {

            if (txtContacto.Text != "")
            {
                txtNumero.Enabled = true;
            }

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            if (txtNumero.Text != "")
            {
                btnAgendar.Enabled = true;
            }
        }

        //private void btnAgendar_TextChanged(object sender, EventArgs e)
        //{

        //}

        private void frmAgendaContactos_Load(object sender, EventArgs e)
        {
            lblCantidadContactos.Text = ("Cantidad de Contactos Agendados: " + canContactos++);

        }

        public void btnAgendar_Click(object sender, EventArgs e)
        {
           while (indice < 5)
            {
                btnAgendar.Enabled = true;
                break;

            }
            vecNombres[indice] = txtContacto.Text;
            vecNumeros[indice] = txtNumero.Text;
            lstResultados.Text = ("Contacto: " + vecNombres[indice] + " - Telefono: " + vecNumeros[indice] + Environment.NewLine + "\n");
            lblCantidadContactos.Text = ("Cantidad de Contactos Agendados: " + canContactos++);
            indice++;
            //Limpiar Controles
            txtContacto.Text = "";
            txtNumero.Text = "";
            if (indice == 5)
            {
                btnAgendar.Enabled = false;
                MessageBox.Show("No se pueden Agendar mas Contactos");
            }
        }

       

        private void btnVerContactos_Click(object sender, EventArgs e)
        {
            frmverContactos ventanaGestion = new frmverContactos(vecNombres,vecNumeros);
            ventanaGestion.ShowDialog();
        }
    }
}
