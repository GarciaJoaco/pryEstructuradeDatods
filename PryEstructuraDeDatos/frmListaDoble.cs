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
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
        }
        clslistasimple FilaDePersonas = new clslistasimple();
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

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
