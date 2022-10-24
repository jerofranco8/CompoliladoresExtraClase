using CompiladoresJeronimo.Transversal.Componente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompiladoresJeronimo.Transversal.TablaSimbolos
{
    public class TablaLiterales
    {
        private static Dictionary<String, List<ComponenteLexico>> TABLA = new Dictionary<string, List<ComponenteLexico>>();

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

        public static void Agregar(ComponenteLexico Componente)
        {
            if (Componente != null && Tipo.LITERAL.Equals(Componente.GetTipo()))
            {
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
