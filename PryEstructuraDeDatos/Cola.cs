using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


    

namespace PryEstructuraDeDatos
{
    internal class Cola
    {
        public Nodo Primero;
        public Nodo Ultimo;

        public void Agregar(Nodo nuevo)   
        {   
            if (Primero== null) // si el promero no tiene asignado ningun objeto
                                //entonces le asigna "nuevo", al prinero y segundo 
	        {
                Primero = nuevo;
                Ultimo = nuevo;
	        }
            else
            {
                Ultimo.Siguiente  = nuevo;
                Ultimo = nuevo;
            }
             
        }

        public void Eliminar()
        {
            if (Primero == Ultimo)
            {
                Primero = null;//si hubiera un solo obgeto en la cola
                Ultimo = null;//estese elimina por lo tanto primero
                              //y ultimo queda en nulo.
            }
            else
            {
                Primero = Primero.Siguiente;//pero si hubiera otro
                                            //objeto en la cola 
                                            //  le asigna el primero al siguiente

            }

        }
        public void Recorrer (  DataGridView Grilla) 
        {
            Nodo aux = Primero;
            Grilla.Rows.Clear();
            while (aux !=null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
            }
        }
        public void Recorrer(ListBox lista)
        {
            Nodo aux = Primero;
            lista.Items.Clear();
            while (aux!= null)
            {
                lista.Items.Add(aux.Codigo + "" + aux.Nombre + "" + aux.Tramite);
                aux = aux.Siguiente;    
            }
        }

        public void Recorrer ( ComboBox combo)
        { Nodo aux = Primero;
            combo.Items.Clear();    
            while (aux != null)
            {
                combo.Items.Add(aux.Nombre);
                aux = aux.Siguiente;
            }
        }
           


    }
}

