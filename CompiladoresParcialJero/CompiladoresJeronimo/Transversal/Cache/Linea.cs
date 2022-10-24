using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompiladoresJeronimo.Transversal.Cache
{
    public class Linea
    {
        private int NumeroLinea;
        private String Contenido;

        private Linea (int NumeroLinea, string Contenido)
        {
            this.NumeroLinea = NumeroLinea;
            this.Contenido = Contenido;
        }

        public static Linea Crear(int NumeroLinea, String Contenido)
        {
            return new Linea (NumeroLinea, Contenido);
        }

        public String GetContenido()
        {
            if(Contenido == null)
            {
                Contenido = "";
            }
            return Contenido;
        }

        public int GetNumeroLinea()
        {
            if (NumeroLinea < 0)
            {
                NumeroLinea = 0;
            }
            return NumeroLinea;
        }

        public bool EsFinArchivo()
        {
            return "@EOF@".Equals(GetContenido());
        }

        public int ObtenerLongitudContenido()
        {
            return GetContenido().Length;
        }

    }

}
