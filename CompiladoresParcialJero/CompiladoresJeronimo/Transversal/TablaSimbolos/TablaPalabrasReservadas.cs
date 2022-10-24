using CompiladoresJeronimo.Transversal.Componente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompiladoresJeronimo.Transversal.TablaSimbolos
{
    public class TablaPalabrasReservadas
    {
        private static Dictionary<String, List<ComponenteLexico>> TABLA = new Dictionary<string, List<ComponenteLexico>>();
        private static Dictionary<String,Categoria> PALABRAS_RESERVADAS = new Dictionary<String,Categoria>();

        static TablaPalabrasReservadas()
        {
            PALABRAS_RESERVADAS.Add("SELECT",Categoria.SQL_SELECT);
            PALABRAS_RESERVADAS.Add("FROM",Categoria.SQL_FROM);
            PALABRAS_RESERVADAS.Add("WHERE", Categoria.SQL_WHERE);
            PALABRAS_RESERVADAS.Add("ASC", Categoria.ASCENDENTE);
            PALABRAS_RESERVADAS.Add("DESC", Categoria.DESCENDENTE);
        }

        public static void Reiniciar()
        {
            TABLA.Clear();
        }

        private static List<ComponenteLexico> ObtenerComponentes(String Lexema)
        {
            if (!TABLA.ContainsKey(Lexema))
            {
                TABLA.Add(Lexema, new List<ComponenteLexico>());
            }
            return TABLA[Lexema];
        }
        private static bool EsPalabraReservada(String Lexema)
        {
            return PALABRAS_RESERVADAS.ContainsKey(Lexema);
        }

        public static void Agregar(ComponenteLexico Componente)
        {
            if (Componente != null && EsPalabraReservada(Componente.GetLexema())) 
            {
                Componente = ComponenteLexico.CrearPalabraReservada(Componente.GetLexema(), PALABRAS_RESERVADAS[Componente.GetLexema()],Componente.GetNumeroLinea(),Componente.GetPosicionInicial(),Componente.GetPosicionFinal());
                ObtenerComponentes(Componente.GetLexema()).Add(Componente);
            }
        }

        public static List<ComponenteLexico> ObtenerComponentes()
        {
            List<ComponenteLexico> Componentes = new List<ComponenteLexico>();

            foreach (List<ComponenteLexico> Lista in TABLA.Values)
            {
                Componentes.AddRange(Lista);
            }
            return Componentes;
        }
    }
}
