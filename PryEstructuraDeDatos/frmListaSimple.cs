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
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }
        clslistasimple FilaDePersonas = new clslistasimple();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Nodo objNodo = new Nodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;

            FilaDePersonas.agregar(objNodo);
            FilaDePersonas.Recorrer(comboBox1);
            FilaDePersonas.Recorrer(dgvCola);
            FilaDePersonas.Recorrer(ltsCola);
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (FilaDePersonas != null)
            {
                Int32 X = Convert.ToInt32(comboBox1.Text);
                FilaDePersonas.ELIMINAR(X);
                FilaDePersonas.Recorrer(dgvCola);
                FilaDePersonas.Recorrer(ltsCola);
                FilaDePersonas.Recorrer(comboBox1);


            }
            else
            {
                MessageBox.Show("La lista esta vacia");
            }
        }

        private void frmListaSimple_Load(object sender, EventArgs e)
        {

        }
    }
}
