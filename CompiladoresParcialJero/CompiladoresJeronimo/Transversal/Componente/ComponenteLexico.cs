using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompiladoresJeronimo.Transversal.Componente
{
    public class ComponenteLexico
    {
        private String lexema;
        private Categoria Categoria;
        private Tipo Tipo;
        private int NumeroLinea;
        private int PosicionInicial;
        private int PosicionFinal;

        private ComponenteLexico(String Lexema, Categoria categoria, Tipo tipo, int NumeroLinea, int PosicionInicial, int PosicionFinal)
        {
            this.lexema = Lexema;
            this.Categoria= categoria;
            this.Tipo= tipo;
            this.NumeroLinea= NumeroLinea;
            this.PosicionInicial= PosicionInicial;
            this.PosicionFinal= PosicionFinal;
        }

        public static ComponenteLexico CrearSimbolo(String Lexema, Categoria categoria, int NumeroLinea, int PosicionInicial, int PosicionFinal)
        {
            return new ComponenteLexico(Lexema,categoria, Tipo.SIMBOLO,NumeroLinea,PosicionInicial,PosicionFinal);
        }
        public static ComponenteLexico CrearLiteral(String Lexema, Categoria categoria, int NumeroLinea, int PosicionInicial, int PosicionFinal)
        {
            return new ComponenteLexico(Lexema, categoria, Tipo.LITERAL, NumeroLinea, PosicionInicial, PosicionFinal);
        }
        public static ComponenteLexico CrearDummy(String Lexema, Categoria categoria, int NumeroLinea, int PosicionInicial, int PosicionFinal)
        {
            return new ComponenteLexico(Lexema, categoria, Tipo.DUMMY, NumeroLinea, PosicionInicial, PosicionFinal);
        }
        public static ComponenteLexico CrearPalabraReservada(String Lexema, Categoria categoria, int NumeroLinea, int PosicionInicial, int PosicionFinal)
        {
            return new ComponenteLexico(Lexema, categoria, Tipo.PALABRA_RESERVADA, NumeroLinea, PosicionInicial, PosicionFinal);
        }


        public String GetLexema()
        {
            if (lexema == null)
            {
                lexema = "";
            }
            return lexema;
        }

        public Categoria GetCategoria()
        {
            return Categoria;
        }

        public Tipo GetTipo()
        {
            return Tipo;
        }
        public int GetNumeroLinea()
        {
            return NumeroLinea;
        }

        public int GetPosicionInicial()
        {
            return PosicionInicial;
        }

        public int GetPosicionFinal()
        {
            return PosicionFinal;
        }

        public String ToString()
        {
            StringBuilder sb = new StringBuilder();
            String SaltoLinea = "\n";

            sb.Append("Tipo Componente: ").Append(GetTipo()).Append(SaltoLinea);
            sb.Append("Categoria: ").Append(GetCategoria()).Append(SaltoLinea);
            sb.Append("Lexema: ").Append(GetLexema()).Append(SaltoLinea);
            sb.Append("Numero Linea: ").Append(GetNumeroLinea()).Append(SaltoLinea);
            sb.Append("Posicion Inicial: ").Append(GetPosicionInicial()).Append(SaltoLinea);
            sb.Append("Posicion final: ").Append(GetPosicionFinal()).Append(SaltoLinea);

            return sb.ToString();
        }
    }

}
