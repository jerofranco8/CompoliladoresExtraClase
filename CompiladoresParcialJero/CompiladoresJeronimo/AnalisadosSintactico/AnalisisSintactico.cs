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

        public  void  Analizar()
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


        //  <Expresion>-><Termino><ExpresionPrima> 
        private void Expresion()
        {
            Termino();
            ExpresionPrima();
        }
        // <Termino>-><Factor><TerminoPrima>
        private void Termino()
        {
            Factor();
            TerminoPrima();
        }
        //  <ExpresionPrima>->+<Expresion>|-<Expresion>|Epsilon
        private void ExpresionPrima()
        {
            if (Categoria.SUMA.Equals(Componente.GetCategoria()))
            {
                PedirComponente();
                Expresion();
            }
            else if (Categoria.RESTA.Equals(Componente.GetCategoria()))
            {
                PedirComponente();
                Expresion();
            }
        }

        //  <Factor>->NUMERO ENTERO|NUMERO DECIMAL|(<Expresion>)
        private void Factor()
        {
            if (Categoria.NUMERO_ENTERO.Equals(Componente.GetCategoria()))
            {
                PedirComponente();

            }
            else if (Categoria.NUMERO_DECIMAL.Equals(Componente.GetCategoria()))
            {
                PedirComponente();
            }

            else if (Categoria.ABRE.Equals(Componente.GetCategoria()))
            {

                PedirComponente();
                Expresion();
                if (Categoria.CIERRA.Equals(Componente.GetCategoria()))
                {
                    PedirComponente();
                }

                else
                {
                    String Falla = "No se cerro parentesis";
                    string Causa = "Esperaba ')' y recibi " + Componente.GetLexema() + " ";
                    String Solucion = "Asegurese de tener la posicion indicada ";
                    int PosicionFinal = Componente.GetPosicionFinal();
                    int PosicionInicial = Componente.GetPosicionInicial();
                    int NumeroLinea = Componente.GetNumeroLinea();

                    Error Error = Error.CrearErrorSintatico(NumeroLinea, PosicionInicial, PosicionFinal, Falla, Causa, Solucion);
                    GestorErrores.Agregar(Error);
                    throw new Exception("Se ha presentado un problema durante el analisis sintatico, no se ha recibido el ')' esperado, se recibio: " + Componente.GetLexema());
                }
            }

            
            else
            {
                String Falla = "Componente no valido";
                string Causa = "No recibi lo esprado ";
                String Solucion = "Asegurese de tener la posicion indicada ";
                int PosicionFinal = Componente.GetPosicionFinal();
                int PosicionInicial = Componente.GetPosicionInicial();
                int NumeroLinea = Componente.GetNumeroLinea();

                Error Error = Error.CrearErrorSintatico(NumeroLinea, PosicionInicial, PosicionFinal, Falla, Causa, Solucion);
                GestorErrores.Agregar(Error);
                throw new Exception("Se ha presentado un problema durante el analisis sintatico, se esperaba un simoblo vlaido, se recibio: " + Componente.GetLexema());
            }

        }

        //  <TerminoPrima>->*<Termino>|/<Termino>|Epsilon
        private void TerminoPrima()
        {
            if (Categoria.DIVISOR.Equals(Componente.GetCategoria()))
            {
                PedirComponente();
                Termino();
            }
            else if (Categoria.MULTIPLICADOR.Equals(Componente.GetCategoria()))
            {
                PedirComponente();
                Termino();
            }
        }
    }
}
