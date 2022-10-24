using CompiladoresJeronimo.Transversal.Componente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompiladoresJeronimo.Transversal.TablaSimbolos
{
    public class TablaMaestra
    {
        public static void Agregar(ComponenteLexico componente)
        {
            TablaPalabrasReservadas.Agregar(componente);
            TablaSimbolo.Agregar(componente);
            TablaLiterales.Agregar(componente);
            TablaDummies.Agregar(componente);

        }

        public static void reiniciar()
        {
            TablaPalabrasReservadas.Reiniciar();
            TablaLiterales.Reiniciar();
            TablaDummies.Reiniciar();
            TablaSimbolo.Reiniciar();

        }

        public static List<ComponenteLexico> ObtenerComponentes(Tipo tipo)
        {
            if (Tipo.SIMBOLO.Equals(tipo))
            {
                return TablaSimbolo.ObtenerComponentes();
            }
            else if (Tipo.DUMMY.Equals(tipo))
            {
                return TablaDummies.ObtenerComponentes();

            }
            else if (Tipo.LITERAL.Equals(tipo)){
                return TablaLiterales.ObtenerComponentes();
            }
            else
            {
                return TablaPalabrasReservadas.ObtenerComponentes();
            }
        }


    }
}
