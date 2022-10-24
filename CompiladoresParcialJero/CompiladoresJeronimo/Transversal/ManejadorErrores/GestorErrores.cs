using CompiladoresJeronimo.Transversal.Cache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompiladoresJeronimo.Transversal.ManejadorErrores
{
    public class GestorErrores
    {
        private static Dictionary<TipoError, List<Error>> TABLA_ERRORES = new Dictionary<TipoError, List<Error>>();
        private static bool EstaInicializada = false;
        private static void Inicializar()
        {
            if (EstaInicializada == false)
            {
                TABLA_ERRORES.Add(TipoError.LEXICO, new List<Error>());
                TABLA_ERRORES.Add(TipoError.SINTACTICO, new List<Error>());
                TABLA_ERRORES.Add(TipoError.SEMANTICO, new List<Error>());
                EstaInicializada = true;
            }
        }

        public static void Agregar(Error Error)
        {
            Inicializar();
            if (Error != null)
            {
                TABLA_ERRORES[Error.GetTipo()].Add(Error);
            }
        }
        public static bool HayErrores(TipoError Tipo)
        {
            if (TABLA_ERRORES.Count!=0)
            {
                return TABLA_ERRORES[Tipo].Count > 0;
            }
            
            return false;
        }
        public static bool HayErroresAnalisis()
        {
            return HayErrores(TipoError.LEXICO) || HayErrores(TipoError.SEMANTICO) || HayErrores(TipoError.SINTACTICO);

        }
        public static void Reiniciar()
        {
            EstaInicializada = false;
            TABLA_ERRORES.Clear();
            Inicializar();
        }

        public static Dictionary<TipoError, List<Error>> GetTablaErrores()
        {
            return TABLA_ERRORES;

        }

        public static List<Error> ObtenerErrores()
        {
           
                List<Error> Errores = new List<Error>();

                Errores.AddRange(TABLA_ERRORES[TipoError.LEXICO]);
                Errores.AddRange(TABLA_ERRORES[TipoError.SINTACTICO]);
                Errores.AddRange(TABLA_ERRORES[TipoError.SEMANTICO]);

                return Errores;
            
        }

    }
}
