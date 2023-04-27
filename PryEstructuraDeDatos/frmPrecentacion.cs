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
    public partial class frmEstructuraDeDatos : Form
    {
        public frmEstructuraDeDatos()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // que se basa en el resultado que el usuario de cuando se muestre la MessageBox (Resultados de dialogo: Si - No)
            DialogResult s = MessageBox.Show("¿Esta seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //Si el resultado del dialogo es Si, la aplicacion se cierra
            if (s == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void datosPersonalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario usuario= new frmUsuario();
            usuario.ShowDialog();
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmCola cola = new frmCola();
            cola.ShowDialog();
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPila pila= new frmPila();    
            pila.ShowDialog();
        }

        private void listaDobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaDoble listaDoble= new frmListaDoble();
            listaDoble.ShowDialog();    
        }

        private void listaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaSimple listaSimple = new frmListaSimple();   
            listaSimple.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
