using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryEstructuraDeDatos
{
    internal class Nodo
    {
        internal Nodo anterio;

        //Campos del Nodo
        private Int32 cod;
        private String nom;
        private String tra;
        private Nodo sig;
        private Nodo ant;

        //Propiedades del nodo
        public Int32 Codigo
        {
            get { return cod; }
            set { cod = value; }
        }

        public String Nombre
        {
            get { return nom; }
            set { nom = value; }
        }

        public String Tramite
        {
            get { return tra; }
            set { tra = value; }
        }

        public Nodo Siguiente
        {
            get { return sig; }
            set { sig = value; }
        }
        public Nodo izquierdo
        {
            get { return ant; }
            set { ant = value; }
        }
        public Nodo Derecho
        {
            get { return sig; }
            set { sig = value; }
        }



    }
}
