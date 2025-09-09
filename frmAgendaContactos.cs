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
        string vContacto = "";
        string vNumero = "";

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

        private void btnAgendar_TextChanged(object sender, EventArgs e)
        {
            vContacto = txtContacto.Text;
            vNumero = txtNumero.Text;
            //lstResultados.Items.Add("Contacto: " + vContacto + " - Telefono: " + vNumero);
            // Agrega esta línea después de agregar el ítem a lstResultados
            lstResultados.AppendText("Contacto: " + vContacto + " - Telefono: " + vNumero + Environment.NewLine);
            //Limpiar Controles
            txtContacto.Text = "";
            txtNumero.Text = "";
        }

        private void frmAgendaContactos_Load(object sender, EventArgs e)
        {

        }
    }
}
