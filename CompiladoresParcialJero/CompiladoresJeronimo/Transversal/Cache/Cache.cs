using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace CompiladoresJeronimo.Transversal.Cache
{
    public class Cache
    {
        private static Cache INSTANCIA = new Cache();   
        private Dictionary<int, Linea> Lineas= new Dictionary<int, Linea>();  

        private Cache()
        {

        }

        public static Cache GetCache()
        {
            return INSTANCIA;
        }

        public void Reiniciar()
        {
            Lineas.Clear();
        }

        public int ObetenerNumeroLineas()
        {
            return Lineas.Keys.Count;
        }

        public void AgregarContenido(String Contenido)
        {
            if(Contenido != null)
            {
                int NumeroLinea =ObetenerNumeroLineas()+1;
                Lineas.Add(NumeroLinea, Linea.Crear(NumeroLinea, Contenido));
            }
        }

        public Linea ObtenerContenido (int NumeroLinea)
        {
            Linea retorno = Linea.Crear(NumeroLinea, "@EOF@");

            if (Lineas.ContainsKey(NumeroLinea))
            {
                retorno = Lineas[NumeroLinea];
            }
            return retorno; 
        }
                 
    }
}
