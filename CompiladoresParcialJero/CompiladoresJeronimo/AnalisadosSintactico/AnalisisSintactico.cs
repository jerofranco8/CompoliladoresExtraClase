using CompiladoresJeronimo.AnalizadorLexico;
using CompiladoresJeronimo.Transversal.Componente;
using CompiladoresJeronimo.Transversal.ManejadorErrores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompiladoresJeronimo.AnalisadosSintactico
{
    public class AnalisisSintactico
    {
        AnalizadorLexico.AnalizadorLexico AnaLex = AnalizadorLexico.AnalizadorLexico.Crear();

        ComponenteLexico Componente;

        private void PedirComponente()
        {
            Componente = AnaLex.DevolverComponente();
        }

        public void Analizar()
        {
            PedirComponente();
            Expresion();

            if (GestorErrores.HayErroresAnalisis())
            {
                MessageBox.Show("Hay errores dentro del proceso de compilacion");
            }
            else if (Categoria.FIN_ARCHIVO.Equals(Componente.GetCategoria()))
            {
                MessageBox.Show("El programa esta bien escrito...");
            }
            else
            {
                MessageBox.Show("El programa esta bien escrito, pero faltaron componentes por evaluar");
            }
        }


        //  <Expresion>-> SELECT<Campos>FROM<Tabla> 
        private void Expresion()
        {
            Select();
            Campos();
            From();
            Tablas();
        }

        private void Select()
        {
            if (Categoria.SQL_SELECT.Equals(Componente.GetCategoria()))
            {
                PedirComponente();
            }
            else
            {
                String Falla = "El codigo fuente debe empezar por SELECT";
                string Causa = "No se ha empezado el codigo con un SELECT, se ha empezado con un: " + Componente.GetLexema();
                String Solucion = "Asegurese de empezar el codigo con SELECT";
                int PosicionFinal = Componente.GetPosicionFinal();
                int PosicionInicial = Componente.GetPosicionInicial();
                int NumeroLinea = Componente.GetNumeroLinea();

                Error Error = Error.CrearErrorSintatico(NumeroLinea, PosicionInicial, PosicionFinal, Falla, Causa, Solucion);
                GestorErrores.Agregar(Error);
                throw new Exception("Se ha presentado un problema durante el analisis sintatico, no se ha empezado el con un SELECT, se recibio: " + Componente.GetLexema());
            }
        }

        private void Campos()
        {
            if (Categoria.CAMPO.Equals(Componente.GetCategoria()))
            {
                PedirComponente();
            }
            else
            {
                String Falla = "El codigo fuente debe incluir minimo un CAMPO";
                string Causa = "No se ha ingresado un CAMPO: " + Componente.GetLexema();
                String Solucion = "Asegurese de ingresar un CAMPO";
                int PosicionFinal = Componente.GetPosicionFinal();
                int PosicionInicial = Componente.GetPosicionInicial();
                int NumeroLinea = Componente.GetNumeroLinea();

                Error Error = Error.CrearErrorSintatico(NumeroLinea, PosicionInicial, PosicionFinal, Falla, Causa, Solucion);
                GestorErrores.Agregar(Error);
                throw new Exception("Se ha presentado un problema durante el analisis sintatico, no se ha Ingresado un CAMPO, se recibio: " + Componente.GetLexema());
            }
            Boolean ComaActiva = true;
            while (ComaActiva)
            {
                if (Categoria.COMA.Equals(Componente.GetCategoria()))
                {
                    PedirComponente();

                    if (Categoria.CAMPO.Equals(Componente.GetCategoria()))
                    {
                        PedirComponente();
                    }
                    else
                    {
                        String Falla = "Luego de la 'COMA', debio seguir otro CAMPO";
                        string Causa = "No se ha ingresado un CAMPO despues de la coma, se ha ingreasado: " + Componente.GetLexema();
                        String Solucion = "Asegurese de ingresar un CAMPO luego de una COMA";
                        int PosicionFinal = Componente.GetPosicionFinal();
                        int PosicionInicial = Componente.GetPosicionInicial();
                        int NumeroLinea = Componente.GetNumeroLinea();

                        Error Error = Error.CrearErrorSintatico(NumeroLinea, PosicionInicial, PosicionFinal, Falla, Causa, Solucion);
                        GestorErrores.Agregar(Error);
                        throw new Exception("Se ha presentado un problema durante el analisis sintatico, no se ha Ingresado un CAMPO luego de una 'COMA', se recibio: " + Componente.GetLexema());
                    }

                }
                else
                {
                    ComaActiva = false;
                }
            }

        }
        private void From()
        {
            if (Categoria.SQL_FROM.Equals(Componente.GetCategoria()))
            {
                PedirComponente();
            }
            else
            {
                String Falla = "Luego de los campos debia seguir un FROM";
                string Causa = "Luego de los campos debia seguir un FROM, y se ingresado un: " + Componente.GetLexema();
                String Solucion = "Asegurese de que luego de los campos siga un FROM";
                int PosicionFinal = Componente.GetPosicionFinal();
                int PosicionInicial = Componente.GetPosicionInicial();
                int NumeroLinea = Componente.GetNumeroLinea();

                Error Error = Error.CrearErrorSintatico(NumeroLinea, PosicionInicial, PosicionFinal, Falla, Causa, Solucion);
                GestorErrores.Agregar(Error);
                throw new Exception("Se ha presentado un problema durante el analisis sintatico, no se ha ingresado el from despues de los campos, se recibio: " + Componente.GetLexema());
            }
        }
        private void Tablas()
        {
            if (Categoria.TABLA.Equals(Componente.GetCategoria()))
            {
                PedirComponente();
            }
            else
            {
                String Falla = "El codigo fuente debe incluir minimo una TABLA";
                string Causa = "No se ha ingresado una TABLA: " + Componente.GetLexema();
                String Solucion = "Asegurese de ingresar una TABLA";
                int PosicionFinal = Componente.GetPosicionFinal();
                int PosicionInicial = Componente.GetPosicionInicial();
                int NumeroLinea = Componente.GetNumeroLinea();

                Error Error = Error.CrearErrorSintatico(NumeroLinea, PosicionInicial, PosicionFinal, Falla, Causa, Solucion);
                GestorErrores.Agregar(Error);
                throw new Exception("Se ha presentado un problema durante el analisis sintatico, no se ha Ingresado una TABLA, se recibio: " + Componente.GetLexema());
            }
            Boolean ComaActiva = true;
            while (ComaActiva)
            {
                if (Categoria.COMA.Equals(Componente.GetCategoria()))
                {
                    PedirComponente();

                    if (Categoria.TABLA.Equals(Componente.GetCategoria()))
                    {
                        PedirComponente();
                    }
                    else
                    {
                        String Falla = "Luego de la 'COMA', debio seguir otra TABLA";
                        string Causa = "No se ha ingresado una TABLA despues de la coma, se ha ingreasado: " + Componente.GetLexema();
                        String Solucion = "Asegurese de ingresar una TABLA luego de una COMA";
                        int PosicionFinal = Componente.GetPosicionFinal();
                        int PosicionInicial = Componente.GetPosicionInicial();
                        int NumeroLinea = Componente.GetNumeroLinea();

                        Error Error = Error.CrearErrorSintatico(NumeroLinea, PosicionInicial, PosicionFinal, Falla, Causa, Solucion);
                        GestorErrores.Agregar(Error);
                        throw new Exception("Se ha presentado un problema durante el analisis sintatico, no se ha Ingresado una TABLA luego de una 'COMA', se recibio: " + Componente.GetLexema());
                    }

                }
                else
                {
                    ComaActiva = false;
                }
            }




        }
    }
}
