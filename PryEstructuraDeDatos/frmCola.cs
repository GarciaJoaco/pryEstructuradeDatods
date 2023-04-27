using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEstructuraDeDatos
{
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }
        Cola FilaDepersonas = new Cola();
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (FilaDepersonas.Primero != null)
            {
                txtCodigo2.Text = FilaDepersonas.Primero.Codigo.ToString();
                txtNombre2.Text = FilaDepersonas.Primero.Nombre;
                txtTramite2.Text = FilaDepersonas.Primero.Tramite;
                FilaDepersonas.Eliminar();
                FilaDepersonas.Recorrer(dgvCola);
                FilaDepersonas.Recorrer(ltsCola);
            }
            else
            {
                txtCodigo2.Text = "";
                txtNombre2.Text = "";
                txtTramite2.Text = "";
            }
            

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Nodo objNodo = new Nodo();
            objNodo.Codigo = Convert.ToInt32(txtCodido.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;
            FilaDepersonas.Agregar(objNodo);
            FilaDepersonas.Recorrer(dgvCola);
            txtCodido.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";


        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCola_Load(object sender, EventArgs e)
        {

        }
    }
}
