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
        clslistasimple list = new clslistasimple();

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (list != null)
            {
                Int32 X = Convert.ToInt32(comboBox1.Text);
                list.ELIMINAR(X);
                list.Recorrer(dgvCola);
                list.Recorrer(ltsCola);
                list.Recorrer(comboBox1);


            }
            else
            {

            }
        }

        private void frmListaSimple_Load(object sender, EventArgs e)
        {

        }
    }
}
