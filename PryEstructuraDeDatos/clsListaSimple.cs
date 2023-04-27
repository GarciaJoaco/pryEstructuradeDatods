using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace PryEstructuraDeDatos
{


    internal class clslistasimple
    {
        public Nodo primero;
        public Nodo anterior;
        public Nodo aux;

        public void agregar(Nodo NUEVO)
        {

            if (primero == null)
            {
                primero = NUEVO;

            }
            else
            {

                if (NUEVO.Codigo < primero.Codigo)
                {
                    NUEVO.Siguiente = primero;
                    primero = NUEVO;

                }
                else
                {
                    Nodo aux = primero;
                    Nodo ant = primero;
                    while (NUEVO.Codigo > aux.Codigo)
                    {
                        ant = aux;
                        aux = aux.Siguiente;
                        if (aux == null)
                        {
                            break;
                        }

                    }
                    ant.Siguiente = NUEVO;
                    NUEVO.Siguiente = aux;
                }


            }


        }
        public void Recorrer(ComboBox combo)
        {
            Nodo aux = primero;
            combo.Items.Clear();
            while (aux != null)
            {
                combo.Items.Add(aux.Codigo);
                aux = aux.Siguiente;

            }

        }
        public void Recorrer(DataGridView grilla)
        {
            Nodo aux = primero;
            grilla.Rows.Clear();
            while (aux != null)
            {
                grilla.Rows.Add(aux.Codigo,aux.Nombre,aux.Tramite);
                aux = aux.Siguiente;

            }

        }
        public void Recorrer(ListBox lista)
        {

            lista.Items.Clear();
            while (aux != null)
            {
                lista.Items.Add(aux.Codigo + " " + aux.Nombre + " " + aux.Tramite);
                aux = aux.Siguiente;

            }

        }

        public void ELIMINAR(Int32 codigo)
        {
            if (primero.Codigo == codigo)
            {
                primero = primero.Siguiente;
            }
            else
            {
                Nodo anterior = primero;
                Nodo aux = primero;
                while (aux.Codigo != codigo)
                {
                    anterior = aux;
                    aux = aux.Siguiente;

                }
                anterior.Siguiente = aux.Siguiente;



            }

        }
    }
}