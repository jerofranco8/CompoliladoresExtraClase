using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompiladoresJeronimo.Transversal.ManejadorErrores
{
    public class Error
    {
        private int NumeroLinea;
        private int PosicionInicial;
        private int PosicionFinal;
        private String Falla;
        private string Causa;
        private String Solucion;
        private TipoError Tipo;


        private Error(int NumeroLinea,int PosicionInicial, int PosicionFinal, String Falla,string Causa,String Solucion,TipoError Tipo)
        {
            this.NumeroLinea=NumeroLinea;
            this.Tipo=Tipo;
            this.PosicionFinal=PosicionFinal;
            this.PosicionInicial=PosicionInicial;
            this.Causa=Causa;   
            this.Falla=Falla;
            this.Solucion=Solucion;
        }

        public static Error CrearErrorLexico(int NumeroLinea, int PosicionInicial, int PosicionFinal, String Falla, string Causa, String Solucion)
        {
            return new Error (NumeroLinea, PosicionInicial, PosicionFinal, Falla, Causa, Solucion, TipoError.LEXICO);
        }
        public static Error CrearErrorSemantico(int NumeroLinea, int PosicionInicial, int PosicionFinal, String Falla, string Causa, String Solucion)
        {
            return new Error (NumeroLinea, PosicionInicial, PosicionFinal, Falla, Causa, Solucion, TipoError.SEMANTICO);
        }
        public static Error CrearErrorSintatico(int NumeroLinea, int PosicionInicial, int PosicionFinal, String Falla, string Causa, String Solucion)
        {
            return new Error(NumeroLinea, PosicionInicial, PosicionFinal, Falla, Causa, Solucion, TipoError.SINTACTICO);
        }

        public int GetNumeroLinea()
        {
            if (NumeroLinea <= 0)
            {
                NumeroLinea = 1;
            }
            return NumeroLinea; 
        }

        public int GetPosicionInicial()
        {
            if (PosicionInicial <= 0)
            {
                PosicionInicial=1;
            }
            return PosicionInicial;
        }
        public int GetPosicionFinal()
        {
            if (PosicionFinal <= 0)
            {
                PosicionFinal = 1;
            }
            return PosicionFinal;
        }



        public String GetCausa()
        {
            if (Causa == null)
            {
                Causa = "";
            }
            return Causa;
        }
        public String GetSolucion()
        {
            if (Solucion == null)
            {
                Solucion = "";
            }
            return Solucion;
        }
        public String GetFalla()
        {
            if (Falla == null)
            {
                Falla = "";
            }
            return Falla;
        }

        public TipoError GetTipo()
        {
            return Tipo;

        }

    }
}
