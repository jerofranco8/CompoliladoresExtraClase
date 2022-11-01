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
                MessageBox.Show("El programa esta bien escrito a nivel sintactico pero hay errores lexicos en los componentes, revisa la tabla de errores para encontrarlos");
            }
            else if (Categoria.FIN_ARCHIVO.Equals(Componente.GetCategoria()))
            {
                MessageBox.Show("!PROGRAMA BIEN ESCRITO A NIVEL SINTACTICO Y LEXICO¡");
            }
            else
            {
                MessageBox.Show("El programa esta bien escrito , pero faltaron componentes por evaluar");

            }
        }


        //  <Expresión> 	 -->  SELECT<Campos>FROM<Tablas><Where><Order by>
        private void Expresion()
        {
            Select();
            Campos();
            From();
            Tablas();
            Where();
            Order_BY();
            if (!Categoria.FIN_ARCHIVO.Equals(Componente.GetCategoria()))
            {
                MessageBox.Show("Near '" + Componente.GetLexema() + "': syntax error ");
                String Falla = "Programa mal escrito a nivel de estructura";
                string Causa = "El programa escrito no debia incluir: " + Componente.GetLexema() + " en ese lugar";
                String Solucion = "Asegurese de tener el programa bien escrito a nivel de estructura";
                int PosicionFinal = Componente.GetPosicionFinal();
                int PosicionInicial = Componente.GetPosicionInicial();
                int NumeroLinea = Componente.GetNumeroLinea();

                Error Error = Error.CrearErrorSintatico(NumeroLinea, PosicionInicial, PosicionFinal, Falla, Causa, Solucion);
                GestorErrores.Agregar(Error);
                throw new Exception("Se ha presentado un problema durante el analisis sintatico, el programa esta mal escrito a nivel de estructura cerca a : " + Componente.GetLexema());
            }
        }

        private void Select()
        {

            if (Categoria.SQL_SELECT.Equals(Componente.GetCategoria()))
            {
                PedirComponente();
            }
            else
            {
                MessageBox.Show("Near '" + Componente.GetLexema() + "': syntax error ");
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
        //  < Campos>  	 -->  CAMPO|CAMPO,<Campos>
        private void Campos()
        {
            if (Categoria.CAMPO.Equals(Componente.GetCategoria()))
            {
                PedirComponente();
            }
            else
            {
                MessageBox.Show("Near 'SELECT': syntax error ");
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
                        MessageBox.Show("Near '" + Componente.GetLexema() + "': syntax error ");
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
                MessageBox.Show("Near '" + Componente.GetLexema() + "': syntax error ");
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
        //  <Tablas>     	 -->  TABLA|TABLA,<Tablas>
        private void Tablas()
        {
            if (Categoria.TABLA.Equals(Componente.GetCategoria()))
            {
                PedirComponente();
            }
            else
            {
                MessageBox.Show("Near '" + Componente.GetLexema() + "': syntax error ");
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
                        MessageBox.Show("Near '" + Componente.GetLexema() + "': syntax error ");
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

        // <Where>      	  -->  WHERE<Condiciones>|Epsilon
        private void Where()
        {
            if (Categoria.SQL_WHERE.Equals(Componente.GetCategoria()))
            {
                PedirComponente();
                Condiciones();
            }

        }
        // <Condiciones>  -->  <Operando><Operador><Operando><Conector>
        private void Condiciones()
        {
            Operando();
            Operador();
            Operando();
            Conector();
        }
        // <Operando>      -->  CAMPO|LITERAL|DECIMAL|ENTERO
        private void Operando()
        {
            if (Categoria.CAMPO.Equals(Componente.GetCategoria()))
            {
                PedirComponente();

            }
            else if (Categoria.LITERAL.Equals(Componente.GetCategoria()))
            {
                PedirComponente();
            }
            else if (Categoria.NUMERO_DECIMAL.Equals(Componente.GetCategoria()))
            {
                PedirComponente();
            }
            else if (Categoria.NUMERO_ENTERO.Equals(Componente.GetCategoria()))
            {
                PedirComponente();
            }
            else
            {
                MessageBox.Show("Near '" + Componente.GetLexema() + "': syntax error ");
                String Falla = "Operando no valido";
                string Causa = "Se esperaba recibir un campo, literal, decimal o entero y se recibio : " + Componente.GetLexema();
                String Solucion = "Asegurese de tener un campo, literal, decimal o entero en la posicion indicada ";
                int PosicionFinal = Componente.GetPosicionFinal();
                int PosicionInicial = Componente.GetPosicionInicial();
                int NumeroLinea = Componente.GetNumeroLinea();

                Error Error = Error.CrearErrorSintatico(NumeroLinea, PosicionInicial, PosicionFinal, Falla, Causa, Solucion);
                GestorErrores.Agregar(Error);
                throw new Exception("Se ha presentado un problema durante el analisis sintatico, se esperaba  un campo, literal, decimal o entero despues de una operando y se recibio: " + Componente.GetLexema());
            }
        }
        // <Operador>       -->  MAYOR QUE|MENOR QUE|IGUAL QUE|MAYOR O IGUAL QUE|  MENOR O IGUAL QUE|DIFERENTE QUE
        private void Operador()
        {
            if (Categoria.MAYOR.Equals(Componente.GetCategoria()))
            {
                PedirComponente();

            }
            else if (Categoria.MENOR.Equals(Componente.GetCategoria()))
            {
                PedirComponente();
            }
            else if (Categoria.IGUAL.Equals(Componente.GetCategoria()))
            {
                PedirComponente();
            }
            else if (Categoria.MAYOR_IGUAL.Equals(Componente.GetCategoria()))
            {
                PedirComponente();
            }
            else if (Categoria.MENOR_IGUAL.Equals(Componente.GetCategoria()))
            {
                PedirComponente();
            }
            else if (Categoria.DIFERENTE_QUE.Equals(Componente.GetCategoria()))
            {
                PedirComponente();
            }
            else
            {
                MessageBox.Show("Near '" + Componente.GetLexema() + "': syntax error ");
                String Falla = "Operador no valido";
                string Causa = "Se esperaba recibir un operador valido y se recibio : " + Componente.GetLexema();
                String Solucion = "Asegurese de tener un operador valido en la posicion indicada ";
                int PosicionFinal = Componente.GetPosicionFinal();
                int PosicionInicial = Componente.GetPosicionInicial();
                int NumeroLinea = Componente.GetNumeroLinea();

                Error Error = Error.CrearErrorSintatico(NumeroLinea, PosicionInicial, PosicionFinal, Falla, Causa, Solucion);
                GestorErrores.Agregar(Error);
                throw new Exception("Se ha presentado un problema durante el analisis sintatico, se esperaba un operador valido, se recibio: " + Componente.GetLexema());
            }

        }
        // <Conector>         -->  AND<Condiciones>|OR<Condiciones>|Epsilon
        private void Conector()
        {
            if (Categoria.CONECTOR_Y.Equals(Componente.GetCategoria()))
            {
                PedirComponente();
                Condiciones();

            }
            else if (Categoria.CONECTOR_O.Equals(Componente.GetCategoria()))
            {
                PedirComponente();
                Condiciones();
            }
        }
        // <Order by>         -->  ORDER BY<Ordenadores>| Epsilon
        private void Order_BY()
        {
            if (Categoria.SQL_ORDER_BY.Equals(Componente.GetCategoria()))
            {
                PedirComponente();
                Ordenadores();

            }
        }
        // <Ordenadores>  -->  <Campos><Criterio>|<Índices><Criterio>
        private void Ordenadores()
        {

            if (Categoria.CAMPO.Equals(Componente.GetCategoria()))
            {
                Campos();
                Criterio();

            }
            else if (Categoria.NUMERO_ENTERO.Equals(Componente.GetCategoria()))
            {
                Indices();
                Criterio();
            }
        }
        // <Criterio>            -->  ASC|DESC| Epsilon
        private void Criterio()
        {
            if (Categoria.ASCENDENTE.Equals(Componente.GetCategoria()))
            {
                PedirComponente();

            }
            else if (Categoria.DESCENDENTE.Equals(Componente.GetCategoria()))
            {
                PedirComponente();
            }

        }
        // <Índices>       -->  ENTERO|ENTERO<Índices>
        private void Indices()
        {
            PedirComponente();
            Boolean ComaActiva = true;
            while (ComaActiva)
            {
                if (Categoria.COMA.Equals(Componente.GetCategoria()))
                {
                    PedirComponente();

                    if (Categoria.NUMERO_ENTERO.Equals(Componente.GetCategoria()))
                    {
                        PedirComponente();
                    }
                    else
                    {
                        MessageBox.Show("Near '" + Componente.GetLexema() + "': syntax error ");
                        String Falla = "Luego de la 'COMA', debio seguir un numero entero";
                        string Causa = "No se ha ingresado un numero entero despues de la coma, se ha ingreasado: " + Componente.GetLexema();
                        String Solucion = "Asegurese de ingresar un numero entero luego de una COMA";
                        int PosicionFinal = Componente.GetPosicionFinal();
                        int PosicionInicial = Componente.GetPosicionInicial();
                        int NumeroLinea = Componente.GetNumeroLinea();

                        Error Error = Error.CrearErrorSintatico(NumeroLinea, PosicionInicial, PosicionFinal, Falla, Causa, Solucion);
                        GestorErrores.Agregar(Error);
                        throw new Exception("Se ha presentado un problema durante el analisis sintatico, no se ha Ingresado un numero entero luego de una 'COMA', se recibio: " + Componente.GetLexema());
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
