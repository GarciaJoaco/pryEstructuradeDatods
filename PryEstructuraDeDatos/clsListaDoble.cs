using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEstructuraDeDatos
{
    internal class clsListaDoble
    {
        //delclaro campos
        private Nodo pri;
        private Nodo ult;
        internal Nodo anterio;

        //declaro las propiedades
        
        public Nodo primero
        {
            get { return pri; }
            set { pri = value; }
        }

        public Nodo ultimo
        {
            get { return ult; }
            set { ult = value; }

        }
        //declaro metodos
        public void agregar(Nodo nvo)
        {
            if (primero == null)
            {
                primero = nvo;
                ultimo = nvo;

            }
            else
            {
                if (nvo.Codigo < primero.Codigo)
                {
                    nvo.Siguiente = primero;
                    primero.anterio = nvo;
                    primero = nvo;
                }
                else
                {
                    if (nvo.Codigo > ultimo.Codigo)
                    {
                        ultimo.Siguiente = nvo;
                        nvo.anterio = ultimo;
                        ultimo = nvo;
                    }
                    else
                    {
                        Nodo aux = primero;
                        Nodo ant = ultimo;

                        while (aux.Codigo < nvo.Codigo)
                        {
                            ant = aux;
                            aux = aux.Siguiente;
                        }
                        ant.Siguiente = nvo;
                        nvo.Siguiente = aux;
                        aux.anterio = nvo;
                        nvo.Siguiente = ant;


                    }


                }


            }



        }

        public void Recorrer(ListBox lista)
        {
            Nodo aux = primero;
            lista.Items.Clear();
            while (aux != null)
            {
                lista.Items.Add(aux.Codigo + " " + aux.Nombre + " " + aux.Tramite);
                aux = aux.Siguiente;
            }
        }

        public void Recorrer(ComboBox combo)
        {
            Nodo aux = primero;
            combo.Items.Clear();
            while (aux != null)
            {
                combo.Items.Add(aux.Nombre);
                aux = aux.Siguiente;
            }

        }

        public void Recorrer(DataGridView grilla)
        {
            Nodo aux = primero;
            grilla.Rows.Clear();
            while (aux != null)
            {
                grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
            }
        }


        public void RecorrerDes(DataGridView grilla)
        {
            Nodo aux = ultimo;
            grilla.Rows.Clear();
            while (aux != null)
            {
                grilla.Rows.Add(aux.Codigo + " " + aux.Nombre + " " + aux.Tramite);
                aux = aux.anterio;
            }
        }

        public void RecorrerDes(ListBox lista)
        {
            Nodo aux = ult;
            lista.Items.Clear();
            while (aux != null)
            {
                lista.Items.Add(aux.Codigo + " " + aux.Nombre + " " + aux.Tramite);
                aux = aux.anterio;

            }

        }

        public void RecorrerDes(ComboBox Combo)
        {
            Nodo aux = ultimo;
            Combo.Items.Clear();
            while (aux != null)
            {
                Combo.Items.Add(aux.Nombre);
                aux = aux.anterio;

            }
        }

        public void Eliminar(Int32 Codigo)
        {
            if (primero.Codigo == Codigo && ultimo == primero)
            {
                primero = null;
                ultimo = null;
            }
            else
            {
                if (primero.Codigo == Codigo)
                {
                    primero = primero.Siguiente;
                    primero.anterio = null;

                }

                else
                {
                    if (ultimo.Codigo == Codigo)
                    {
                        ultimo = ultimo.anterio;
                        ultimo.anterio = null;
                    }
                    else
                    {
                        Nodo aux = primero;
                        Nodo ant = primero;
                        while (aux.Codigo < Codigo)
                        {
                            ant = aux;
                            aux = aux.Siguiente;
                        }
                        aux = aux.Siguiente;
                        ant.Siguiente = aux;
                        aux.anterio = ant;

                    }

                }

            }
        }


        public void eliminar(Int32 codigo)
        {
            //si el dato que borro es el unico de la lista
             if (primero.Codigo == codigo && ultimo == primero)
             {
                    primero = null;
                    ultimo = null;
             }
             else
                {
                    if (primero.Codigo == codigo) //
                    {
                        primero = primero.Siguiente;
                        primero.anterio = null;
                    }
                 else
                 {
                   if (ultimo.Codigo == codigo)
                   {
                    ultimo = ultimo.anterio;
                    ultimo.Siguiente = null;
                   }
                    else
                    {
                     Nodo aux = primero;
                     Nodo ant = primero;
                     while (aux.Codigo < codigo)
                     {
                       ant = aux;
                       aux = aux.Siguiente;
                     }
                      ant.Siguiente = aux.Siguiente;
                      aux = aux.Siguiente;
                      aux.anterio = ant;
                    }
                 }
             }
            
        }

    }

}

