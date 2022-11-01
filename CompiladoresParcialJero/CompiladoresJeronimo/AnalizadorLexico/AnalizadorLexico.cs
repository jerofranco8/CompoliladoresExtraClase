using CompiladoresJeronimo.Transversal.Cache;
using CompiladoresJeronimo.Transversal.Componente;
using CompiladoresJeronimo.Transversal.ManejadorErrores;
using CompiladoresJeronimo.Transversal.TablaSimbolos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CompiladoresJeronimo.AnalizadorLexico
{
    public class AnalizadorLexico
    {
        private int Puntero;
        private int NumeroLinea;
        private Linea LineaActual;
        private String CaracterActual;
        private String Lexema;
        private int EstadoActual;
        private bool ContinuarAnalisis;


        private AnalizadorLexico()
        {
            CargarNuevaLinea();
        }

        public static AnalizadorLexico Crear()
        {
            return new AnalizadorLexico();
        }

        private void CargarNuevaLinea()
        {
            NumeroLinea++;
            LineaActual = Cache.GetCache().ObtenerContenido(NumeroLinea);
            NumeroLinea = LineaActual.GetNumeroLinea();
            CaracterActual = LineaActual.GetContenido();
            Puntero = 1;

        }

        private void DevolverPuntero()
        {
            if (Puntero > 1)
            {
                Puntero--;
            }

        }

        private void AumentarPuntero()
        {
            Puntero++;
        }

        private void LeerSiguienteCaracter()
        {
            if (LineaActual.EsFinArchivo())
            {
                CaracterActual = LineaActual.GetContenido();
            }
            else if (Puntero > LineaActual.ObtenerLongitudContenido())
            {
                CaracterActual = "@FL@";
                Puntero = LineaActual.ObtenerLongitudContenido() + 2;
            }
            else

            {
                CaracterActual = LineaActual.GetContenido().Substring(Puntero - 1, 1);
                AumentarPuntero();
            }
        }

        private void Reinicar()
        {
            CaracterActual = "";
            Lexema = "";
            EstadoActual = 0;
            ContinuarAnalisis = true;

        }

        public ComponenteLexico DevolverComponente()
        {
            ComponenteLexico Retorno = null;

            Reinicar();


            while (ContinuarAnalisis)
            {
                if (EstadoActual == 0)
                {
                    ProcesarEstado0();
                }
                else if (EstadoActual == 1)
                {
                    ProcesarEstado1();
                }
                else if (EstadoActual == 2)
                {
                    ProcesarEstado2();
                }
                else if (EstadoActual == 3)
                {
                    ProcesarEstado3();
                }
                else if (EstadoActual == 4)
                {
                    ProcesarEstado4();
                }
                else if (EstadoActual == 5)
                {
                    ProcesarEstado5();
                }
                else if (EstadoActual == 6)
                {
                    Retorno = ProcesarEstado6();
                }
                else if (EstadoActual == 7)
                {
                    Retorno = ProcesarEstado7();
                }
                else if (EstadoActual == 8)
                {
                    ProcesarEstado8();
                }
                else if (EstadoActual == 9)
                {
                    ProcesarEstado9();
                }
                else if (EstadoActual == 10)
                {
                    ProcesarEstado10();
                }
                else if (EstadoActual == 11)
                {
                    ProcesarEstado11();
                }
                else if (EstadoActual == 12)
                {
                    ProcesarEstado12();
                }
                else if (EstadoActual == 13)
                {
                    Retorno = ProcesarEstado13();
                }
                else if (EstadoActual == 14)
                {
                    ProcesarEstado14();
                }
                else if (EstadoActual == 15)
                {
                    Retorno = ProcesarEstado15();
                }
                else if (EstadoActual == 16)
                {
                    ProcesarEstado16();
                }
                else if (EstadoActual == 17)
                {
                    Retorno = ProcesarEstado17();
                }
                else if (EstadoActual == 18)
                {
                    ProcesarEstado18();
                }
                else if (EstadoActual == 19)
                {
                    Retorno = ProcesarEstado19();
                }
                else if (EstadoActual == 20)
                {
                    ProcesarEstado20();
                }
                else if (EstadoActual == 21)
                {
                    ProcesarEstado21();
                }
                else if (EstadoActual == 22)
                {
                    Retorno = ProcesarEstado22();
                }
                else if (EstadoActual == 23)
                {
                    ProcesarEstado23();
                }
                else if (EstadoActual == 24)
                {
                    ProcesarEstado24();
                }
                else if (EstadoActual == 25)
                {
                    ProcesarEstado25();
                }
                else if (EstadoActual == 26)
                {
                    ProcesarEstado26();
                }
                else if (EstadoActual == 27)
                {
                    ProcesarEstado27();
                }
                else if (EstadoActual == 28)
                {
                    Retorno = ProcesarEstado28();
                }
                else if (EstadoActual == 29)
                {
                    ProcesarEstado29();
                }
                else if (EstadoActual == 30)
                {
                    ProcesarEstado30();
                }
                else if (EstadoActual == 31)
                {
                    ProcesarEstado31();
                }
                else if (EstadoActual == 32)
                {
                    Retorno = ProcesarEstado32();
                }
                else if (EstadoActual == 33)
                {
                    ProcesarEstado33();
                }
                else if (EstadoActual == 34)
                {
                    ProcesarEstado34();
                }
                else if (EstadoActual == 35)
                {
                    ProcesarEstado35();
                }
                else if (EstadoActual == 36)
                {
                    ProcesarEstado36();
                }
                else if (EstadoActual == 37)
                {
                    Retorno = ProcesarEstado37();
                }
                else if (EstadoActual == 38)
                {
                    ProcesarEstado38();
                }
                else if (EstadoActual == 39)
                {
                    ProcesarEstado39();
                }
                else if (EstadoActual == 40)
                {
                    ProcesarEstado40();
                }
                else if (EstadoActual == 41)
                {
                    ProcesarEstado41();
                }
                else if (EstadoActual == 42)
                {
                    ProcesarEstado42();
                }
                else if (EstadoActual == 43)
                {
                    ProcesarEstado43();
                }
                else if (EstadoActual == 44)
                {
                    ProcesarEstado44();
                }
                else if (EstadoActual == 45)
                {
                    Retorno = ProcesarEstado45();
                }
                else if (EstadoActual == 46)
                {
                    Retorno = ProcesarEstado46();
                }
                else if (EstadoActual == 47)
                {
                    ProcesarEstado47();
                }
                else if (EstadoActual == 48)
                {
                    ProcesarEstado48();
                }
                else if (EstadoActual == 49)
                {
                    Retorno = ProcesarEstado49();
                }
                else if (EstadoActual == 50)
                {
                    ProcesarEstado50();
                }
                else if (EstadoActual == 51)
                {
                    Retorno = ProcesarEstado51();
                }
                else if (EstadoActual == 52)
                {
                    ProcesarEstado52();
                }
                else if (EstadoActual == 53)
                {
                    ProcesarEstado53();
                }
                else if (EstadoActual == 54)
                {
                    ProcesarEstado54();
                }
                else if (EstadoActual == 55)
                {
                    Retorno = ProcesarEstado55();
                }
                else if (EstadoActual == 56)
                {
                    Retorno = ProcesarEstado56();
                }
                else if (EstadoActual == 57)
                {
                    ProcesarEstado57();
                }
                else if (EstadoActual == 58)
                {
                    Retorno = ProcesarEstado58();
                }
                else if (EstadoActual == 59)
                {
                    Retorno = ProcesarEstado59();
                }
                else if (EstadoActual == 60)
                {
                    Retorno = ProcesarEstado60();
                }
                else if (EstadoActual == 61)
                {
                    ProcesarEstado61();
                }
                else if (EstadoActual == 62)
                {
                    Retorno = ProcesarEstado62();
                }
                else if (EstadoActual == 63)
                {
                    Retorno = ProcesarEstado63();
                }
                else if (EstadoActual == 64)
                {
                    ProcesarEstado64();
                }
                else if (EstadoActual == 65)
                {
                    Retorno = ProcesarEstado65();
                }
                else if (EstadoActual == 66)
                {
                    Retorno = ProcesarEstado66();
                }
                else if (EstadoActual == 67)
                {
                    Retorno = ProcesarEstado67();
                }
                else if (EstadoActual == 68)
                {
                    ProcesarEstado68();
                }
                //ERRORES
                else if (EstadoActual == 69)
                {
                    Retorno = ProcesarEstado69();
                }
                else if (EstadoActual == 70)
                {
                    Retorno = ProcesarEstado70();
                }
                else if (EstadoActual == 71)
                {
                    Retorno = ProcesarEstado71();
                }
                else if (EstadoActual == 72)
                {
                    Retorno = ProcesarEstado72();
                }
                else if (EstadoActual == 73)
                {
                    Retorno = ProcesarEstado73();
                }
                else if (EstadoActual == 74)
                {
                    Retorno = ProcesarEstado74();
                }
                else if (EstadoActual == 75)
                {
                    Retorno = ProcesarEstado75();
                }
                else if (EstadoActual == 76)
                {
                    Retorno = ProcesarEstado76();
                }
                else if (EstadoActual == 77)
                {
                    Retorno = ProcesarEstado77();
                }
                else if (EstadoActual == 78)
                {
                    Retorno = ProcesarEstado78();
                }
                else if (EstadoActual == 79)
                {
                    Retorno = ProcesarEstado79();
                }
                else if (EstadoActual == 80)
                {
                    Retorno = ProcesarEstado80();
                }

            }
            TablaMaestra.Agregar(Retorno);
            return Retorno;
        }

        private void DevorarEspaciosBlanco()
        {
            String Blanco = " ";
            while (Blanco.Equals(CaracterActual))
            {
                LeerSiguienteCaracter();
            }
            while (EsEspacioTextBox())
            {
                LeerSiguienteCaracter();
            }
        }

        private bool EsLetra()
        {
            return char.IsLetter(CaracterActual.ToCharArray()[0]);
        }

        private bool EsDigito()
        {
            return char.IsDigit(CaracterActual.ToCharArray()[0]);
        }
        private bool EsComa()
        {
            return ",".Equals(CaracterActual);
        }

        private bool EsIgual()
        {
            return "=".Equals(CaracterActual);
        }
        private bool EsMenor()
        {
            return "<".Equals(CaracterActual);
        }
        private bool EsMayor()
        {
            return ">".Equals(CaracterActual);
        }
        private bool EsPunto()
        {
            return ".".Equals(CaracterActual);
        }
        private bool EsSignoAdmiracion()
        {
            return "!".Equals(CaracterActual);
        }

        private bool EsGuionBajo()
        {
            return "_".Equals(CaracterActual);
        }
        private bool EsEsapcio()
        {
            return " ".Equals(CaracterActual);
        }
        private bool EsComillaSencilla()
        {
            return "'".Equals(CaracterActual);
        }

        private bool EsFinDeLinea()
        {
            return "\r\n".Equals(CaracterActual);
        }

        private bool EsFinArchivo()
        {
            return "@EOF@".Equals(CaracterActual);
        }


        private bool EsFinLinea()
        {
            return "@FL@".Equals(CaracterActual);
        }
        private bool EsEspacioTextBox()
        {
            return "\t".Equals(CaracterActual);
        }

        private void Concatenar()
        {
            Lexema = Lexema + CaracterActual;
        }

        private bool Es_C()
        {
            return (string.Equals(CaracterActual, "c", StringComparison.OrdinalIgnoreCase));
        }
        private bool Es_A()
        {
            return (string.Equals(CaracterActual, "a", StringComparison.OrdinalIgnoreCase));
        }
        private bool Es_M()
        {
            return (string.Equals(CaracterActual, "m", StringComparison.OrdinalIgnoreCase));
        }
        private bool Es_T()
        {
            return (string.Equals(CaracterActual, "t", StringComparison.OrdinalIgnoreCase));
        }
        private bool Es_N()
        {
            return (string.Equals(CaracterActual, "n", StringComparison.OrdinalIgnoreCase));
        }
        private bool Es_B()
        {
            return (string.Equals(CaracterActual, "b", StringComparison.OrdinalIgnoreCase));
        }
        private bool Es_S()
        {
            return (string.Equals(CaracterActual, "s", StringComparison.OrdinalIgnoreCase));
        }
        private bool Es_E()
        {
            return (string.Equals(CaracterActual, "e", StringComparison.OrdinalIgnoreCase));
        }
        private bool Es_L()
        {
            return (string.Equals(CaracterActual, "l", StringComparison.OrdinalIgnoreCase));
        }
        private bool Es_F()
        {
            return (string.Equals(CaracterActual, "f", StringComparison.OrdinalIgnoreCase));
        }
        private bool Es_R()
        {
            return (string.Equals(CaracterActual, "r", StringComparison.OrdinalIgnoreCase));
        }
        private bool Es_O()
        {
            return (string.Equals(CaracterActual, "o", StringComparison.OrdinalIgnoreCase));
        }
        private bool Es_W()
        {
            return (string.Equals(CaracterActual, "W", StringComparison.OrdinalIgnoreCase));
        }
        private bool Es_H()
        {
            return (string.Equals(CaracterActual, "h", StringComparison.OrdinalIgnoreCase));
        }
        private bool Es_D()
        {
            return (string.Equals(CaracterActual, "d", StringComparison.OrdinalIgnoreCase));
        }
        private bool Es_Y()
        {
            return (string.Equals(CaracterActual, "y", StringComparison.OrdinalIgnoreCase));
        }

        private void ProcesarEstado0()
        {
            LeerSiguienteCaracter();
            DevorarEspaciosBlanco();

            if (Es_C())
            {
                EstadoActual = 1;
                Concatenar();
            }

            else if (Es_T())
            {
                EstadoActual = 8;
                Concatenar();
            }
            else if (EsDigito())
            {
                EstadoActual = 14;
                Concatenar();
            }

            else if (EsComillaSencilla())
            {
                EstadoActual = 20;
                Concatenar();
            }
            else if (Es_S())
            {
                EstadoActual = 23;
                Concatenar();
            }
            else if (Es_F())
            {
                EstadoActual = 29;
                Concatenar();
            }
            else if (Es_W())
            {
                EstadoActual = 33;
                Concatenar();
            }
            else if (Es_O())
            {
                EstadoActual = 38;
                Concatenar();
            }
            else if (Es_A())
            {
                EstadoActual = 47;
                Concatenar();
            }
            else if (Es_D())
            {
                EstadoActual = 52;
                Concatenar();
            }
            else if (EsFinArchivo())
            {
                EstadoActual = 67;
                Concatenar();
            }
            else if (EsFinLinea() || EsFinDeLinea())
            {
                EstadoActual = 68;
            }
            else if (EsIgual())
            {
                EstadoActual = 7;
                Concatenar();
            }
            else if (EsMenor())
            {
                EstadoActual = 57;
                Concatenar();
            }
            else if (EsMayor())
            {
                EstadoActual = 61;
                Concatenar();
            }
            else if (EsSignoAdmiracion())
            {
                EstadoActual = 64;
                Concatenar();
            }
            else if (EsComa())
            {
                EstadoActual = 56;
                Concatenar();
            }

            else
            {
                EstadoActual = 78;
            }
        }


        private void ProcesarEstado1()
        {
            LeerSiguienteCaracter();

            if (Es_A())
            {
                EstadoActual = 2;
                Concatenar();
            }
            else
            {
                EstadoActual = 76;
            }

        }
        private void ProcesarEstado2()
        {
            LeerSiguienteCaracter();

            if (Es_M())
            {
                EstadoActual = 3;
                Concatenar();
            }
            else
            {
                EstadoActual = 76;
            }

        }
        private void ProcesarEstado3()
        {
            LeerSiguienteCaracter();

            if (EsGuionBajo())
            {
                EstadoActual = 4;
                Concatenar();
            }
            else
            {
                EstadoActual = 76;
            }

        }
        private void ProcesarEstado4()
        {
            LeerSiguienteCaracter();

            if (EsLetra() || EsGuionBajo() || EsDigito())
            {
                EstadoActual = 5;
                Concatenar();
            }
            else
            {
                EstadoActual = 76;
            }

        }
        private void ProcesarEstado5()
        {
            LeerSiguienteCaracter();

            if (EsLetra() || EsGuionBajo() || EsDigito())
            {
                EstadoActual = 5;
                Concatenar();
            }
            else
            {
                EstadoActual = 6;
            }
        }

        private ComponenteLexico ProcesarEstado6()
        {
            ContinuarAnalisis = false;
            DevolverPuntero();
            int PosicionFinal = Puntero - 1;
            int PosicionInicial = Puntero - Lexema.Length;
            ComponenteLexico Retorno = ComponenteLexico.CrearSimbolo(Lexema, Categoria.CAMPO, NumeroLinea, PosicionInicial, PosicionFinal);
            return Retorno;
        }

        private ComponenteLexico ProcesarEstado7()
        {
            ContinuarAnalisis = false;
            int PosicionFinal = Puntero - 1;
            int PosicionInicial = Puntero - Lexema.Length;
            ComponenteLexico Retorno = ComponenteLexico.CrearSimbolo(Lexema, Categoria.IGUAL, NumeroLinea, PosicionInicial, PosicionFinal);
            return Retorno;
        }

        private void ProcesarEstado8()
        {
            LeerSiguienteCaracter();

            if (Es_A())
            {
                EstadoActual = 9;
                Concatenar();
            }
            else
            {
                EstadoActual = 77;
            }

        }
        private void ProcesarEstado9()
        {
            LeerSiguienteCaracter();

            if (Es_B())
            {
                EstadoActual = 10;
                Concatenar();
            }
            else
            {
                EstadoActual = 77;
            }

        }
        private void ProcesarEstado10()
        {
            LeerSiguienteCaracter();

            if (EsGuionBajo())
            {
                EstadoActual = 11;
                Concatenar();
            }
            else
            {
                EstadoActual = 77;
            }

        }
        private void ProcesarEstado11()
        {
            LeerSiguienteCaracter();

            if (EsLetra() || EsGuionBajo() || EsDigito())
            {
                EstadoActual = 12;
                Concatenar();
            }
            else
            {
                EstadoActual = 77;
            }

        }
        private void ProcesarEstado12()
        {
            LeerSiguienteCaracter();

            if (EsLetra() || EsGuionBajo() || EsDigito())
            {
                EstadoActual = 12;
                Concatenar();
            }
            else
            {
                EstadoActual = 13;
            }
        }

        private ComponenteLexico ProcesarEstado13()
        {
            ContinuarAnalisis = false;
            DevolverPuntero();
            int PosicionFinal = Puntero - 1;
            int PosicionInicial = Puntero - Lexema.Length;
            ComponenteLexico Retorno = ComponenteLexico.CrearSimbolo(Lexema, Categoria.TABLA, NumeroLinea, PosicionInicial, PosicionFinal);
            return Retorno;
        }

        private void ProcesarEstado14()
        {
            LeerSiguienteCaracter();
            if (EsDigito())
            {
                EstadoActual = 14;
                Concatenar();
            }
            else if (EsPunto())
            {
                EstadoActual = 16;
                Concatenar();
            }
            else
            {
                EstadoActual = 15;
            }

        }

        private ComponenteLexico ProcesarEstado15()
        {
            ContinuarAnalisis = false;
            DevolverPuntero();
            int PosicionFinal = Puntero - 1;
            int PosicionInicial = Puntero - Lexema.Length;
            ComponenteLexico Retorno = ComponenteLexico.CrearSimbolo(Lexema, Categoria.NUMERO_ENTERO, NumeroLinea, PosicionInicial, PosicionFinal);
            return Retorno;
        }

        private void ProcesarEstado16()
        {
            LeerSiguienteCaracter();

            if (EsDigito())
            {
                EstadoActual = 18;
                Concatenar();
            }
            else
            {
                EstadoActual = 17;
            }
        }
        private ComponenteLexico ProcesarEstado17()
        {
            ContinuarAnalisis = false;
            String Falla = "Número decimal no válido";
            string Causa = "Luego del separardor decimal se debe recibir un digito y se recibio un: " + CaracterActual;
            String Solucion = "Luego del separardor decimal se debe recibir un digito";
            int PosicionFinal = Puntero - 1;
            int PosicionInicial = Puntero - Lexema.Length;
            DevolverPuntero();
            Error Error = Error.CrearErrorLexico(NumeroLinea, PosicionInicial, PosicionFinal, Falla, Causa, Solucion);
            GestorErrores.Agregar(Error);
            ComponenteLexico Retorno = ComponenteLexico.CrearDummy(Lexema + "0", Categoria.NUMERO_DECIMAL, NumeroLinea, PosicionInicial, PosicionFinal);
            return Retorno;
        }

        private void ProcesarEstado18()
        {
            LeerSiguienteCaracter();
            if (EsDigito())
            {
                EstadoActual = 18;
                Concatenar();
            }
            else
            {
                EstadoActual = 19;
            }
        }

        private ComponenteLexico ProcesarEstado19()
        {
            ContinuarAnalisis = false;
            DevolverPuntero();
            int PosicionFinal = Puntero - 1;
            int PosicionInicial = Puntero - Lexema.Length;
            ComponenteLexico Retorno = ComponenteLexico.CrearSimbolo(Lexema, Categoria.NUMERO_DECIMAL, NumeroLinea, PosicionInicial, PosicionFinal);
            return Retorno;
        }

        private void ProcesarEstado20()
        {
            LeerSiguienteCaracter();
            if (EsComillaSencilla())
            {
                EstadoActual = 22;
                Concatenar();
            }
            else if (EsFinLinea())
            {
                EstadoActual = 80;
            }
            else
            {
                EstadoActual = 21;
                Concatenar();
            }
        }
        private void ProcesarEstado21()
        {
            LeerSiguienteCaracter();
            if (EsComillaSencilla())
            {
                EstadoActual = 22;
                Concatenar();
            }
            else if (EsFinLinea())
            {
                EstadoActual = 80;
            }
            else
            {
                EstadoActual = 21;
                Concatenar();
            }
        }

        private ComponenteLexico ProcesarEstado22()
        {
            ContinuarAnalisis = false;
            int PosicionFinal = Puntero - 1;
            int PosicionInicial = Puntero - Lexema.Length;
            ComponenteLexico Retorno = ComponenteLexico.CrearLiteral(Lexema, Categoria.LITERAL, NumeroLinea, PosicionInicial, PosicionFinal);
            return Retorno;
        }

        private void ProcesarEstado23()
        {
            LeerSiguienteCaracter();

            if (Es_E())
            {
                EstadoActual = 24;
                Concatenar();
            }
            else
            {
                EstadoActual = 69;
            }

        }
        private void ProcesarEstado24()
        {
            LeerSiguienteCaracter();

            if (Es_L())
            {
                EstadoActual = 25;
                Concatenar();
            }
            else
            {
                EstadoActual = 69;
            }

        }
        private void ProcesarEstado25()
        {
            LeerSiguienteCaracter();

            if (Es_E())
            {
                EstadoActual = 26;
                Concatenar();
            }
            else
            {
                EstadoActual = 69;
            }

        }
        private void ProcesarEstado26()
        {
            LeerSiguienteCaracter();

            if (Es_C())
            {
                EstadoActual = 27;
                Concatenar();
            }
            else
            {
                EstadoActual = 69;
            }

        }
        private void ProcesarEstado27()
        {
            LeerSiguienteCaracter();

            if (Es_T())
            {
                EstadoActual = 28;
                Concatenar();
            }
            else
            {
                EstadoActual = 69;
            }

        }

        private ComponenteLexico ProcesarEstado28()
        {
            ContinuarAnalisis = false;
            int PosicionFinal = Puntero - 1;
            int PosicionInicial = Puntero - Lexema.Length;
            ComponenteLexico Retorno = ComponenteLexico.CrearSimbolo(Lexema, Categoria.SQL_SELECT, NumeroLinea, PosicionInicial, PosicionFinal);
            return Retorno;
        }

        private void ProcesarEstado29()
        {
            LeerSiguienteCaracter();

            if (Es_R())
            {
                EstadoActual = 30;
                Concatenar();
            }
            else
            {
                EstadoActual = 70;
            }

        }
        private void ProcesarEstado30()
        {
            LeerSiguienteCaracter();

            if (Es_O())
            {
                EstadoActual = 31;
                Concatenar();
            }
            else
            {
                EstadoActual = 70;
            }

        }
        private void ProcesarEstado31()
        {
            LeerSiguienteCaracter();

            if (Es_M())
            {
                EstadoActual = 32;
                Concatenar();
            }
            else
            {
                EstadoActual = 70;
            }

        }

        private ComponenteLexico ProcesarEstado32()
        {
            ContinuarAnalisis = false;
            int PosicionFinal = Puntero - 1;
            int PosicionInicial = Puntero - Lexema.Length;
            ComponenteLexico Retorno = ComponenteLexico.CrearSimbolo(Lexema, Categoria.SQL_FROM, NumeroLinea, PosicionInicial, PosicionFinal);
            return Retorno;
        }
        private void ProcesarEstado33()
        {
            LeerSiguienteCaracter();

            if (Es_H())
            {
                EstadoActual = 34;
                Concatenar();
            }
            else
            {
                EstadoActual = 71;
            }

        }

        private void ProcesarEstado34()
        {
            LeerSiguienteCaracter();

            if (Es_E())
            {
                EstadoActual = 35;
                Concatenar();
            }
            else
            {
                EstadoActual = 71;
            }

        }
        private void ProcesarEstado35()
        {
            LeerSiguienteCaracter();

            if (Es_R())
            {
                EstadoActual = 36;
                Concatenar();
            }
            else
            {
                EstadoActual = 71;
            }

        }
        private void ProcesarEstado36()
        {
            LeerSiguienteCaracter();

            if (Es_E())
            {
                EstadoActual = 37;
                Concatenar();
            }
            else
            {
                EstadoActual = 71;
            }

        }

        private ComponenteLexico ProcesarEstado37()
        {
            ContinuarAnalisis = false;
            int PosicionFinal = Puntero - 1;
            int PosicionInicial = Puntero - Lexema.Length;
            ComponenteLexico Retorno = ComponenteLexico.CrearSimbolo(Lexema, Categoria.SQL_WHERE, NumeroLinea, PosicionInicial, PosicionFinal);
            return Retorno;
        }
        private void ProcesarEstado38()
        {
            LeerSiguienteCaracter();

            if (Es_R())
            {
                EstadoActual = 39;
                Concatenar();
            }
            else
            {
                EstadoActual = 79;
            }

        }

        private void ProcesarEstado39()
        {
            LeerSiguienteCaracter();

            if (Es_D())
            {
                EstadoActual = 40;
                Concatenar();
            }
            else
            {
                EstadoActual = 46;
            }

        }
        private void ProcesarEstado40()
        {
            LeerSiguienteCaracter();

            if (Es_E())
            {
                EstadoActual = 41;
                Concatenar();
            }
            else
            {
                EstadoActual = 72;
            }

        }
        private void ProcesarEstado41()
        {
            LeerSiguienteCaracter();

            if (Es_R())
            {
                EstadoActual = 42;
                Concatenar();
            }
            else
            {
                EstadoActual = 72;
            }

        }
        private void ProcesarEstado42()
        {
            LeerSiguienteCaracter();

            if (EsEsapcio())
            {
                EstadoActual = 43;
                Concatenar();
            }
            else
            {
                EstadoActual = 72;
            }

        }

        private void ProcesarEstado43()
        {
            LeerSiguienteCaracter();
            DevorarEspaciosBlanco();

            if (Es_B())
            {
                EstadoActual = 44;
                Concatenar();
            }
            else
            {
                EstadoActual = 72;
            }

        }
        private void ProcesarEstado44()
        {
            LeerSiguienteCaracter();

            if (Es_Y())
            {
                EstadoActual = 45;
                Concatenar();
            }
            else
            {
                EstadoActual = 72;
            }

        }
        private ComponenteLexico ProcesarEstado45()
        {
            ContinuarAnalisis = false;
            int PosicionFinal = Puntero - 1;
            int PosicionInicial = Puntero - Lexema.Length;
            ComponenteLexico Retorno = ComponenteLexico.CrearSimbolo(Lexema, Categoria.SQL_ORDER_BY, NumeroLinea, PosicionInicial, PosicionFinal);
            return Retorno;
        }

        private ComponenteLexico ProcesarEstado46()
        {
            ContinuarAnalisis = false;
            DevolverPuntero();
            int PosicionFinal = Puntero - 1;
            int PosicionInicial = Puntero - Lexema.Length;
            ComponenteLexico Retorno = ComponenteLexico.CrearSimbolo(Lexema, Categoria.CONECTOR_O, NumeroLinea, PosicionInicial, PosicionFinal);
            return Retorno;
        }
        private void ProcesarEstado47()
        {
            LeerSiguienteCaracter();

            if (Es_N())
            {
                EstadoActual = 48;
                Concatenar();
            }
            else if (Es_S())
            {
                EstadoActual = 50;
                Concatenar();
            }
            else
            {
                EstadoActual = 79;
            }

        }
        private void ProcesarEstado48()
        {
            LeerSiguienteCaracter();

            if (Es_D())
            {
                EstadoActual = 49;
                Concatenar();
            }
            else
            {
                EstadoActual = 73;
            }

        }
        private ComponenteLexico ProcesarEstado49()
        {
            ContinuarAnalisis = false;
            int PosicionFinal = Puntero - 1;
            int PosicionInicial = Puntero - Lexema.Length;
            ComponenteLexico Retorno = ComponenteLexico.CrearSimbolo(Lexema, Categoria.CONECTOR_Y, NumeroLinea, PosicionInicial, PosicionFinal);
            return Retorno;
        }
        private void ProcesarEstado50()
        {
            LeerSiguienteCaracter();


            if (Es_C())
            {
                EstadoActual = 51;
                Concatenar();
            }
            else
            {
                EstadoActual = 74;
            }

        }
        private ComponenteLexico ProcesarEstado51()
        {
            ContinuarAnalisis = false;
            int PosicionFinal = Puntero - 1;
            int PosicionInicial = Puntero - Lexema.Length;
            ComponenteLexico Retorno = ComponenteLexico.CrearSimbolo(Lexema, Categoria.ASCENDENTE, NumeroLinea, PosicionInicial, PosicionFinal);
            return Retorno;
        }

        private void ProcesarEstado52()
        {
            LeerSiguienteCaracter();

            if (Es_E())
            {
                EstadoActual = 53;
                Concatenar();
            }
            else
            {
                EstadoActual = 75;
            }

        }
        private void ProcesarEstado53()
        {
            LeerSiguienteCaracter();

            if (Es_S())
            {
                EstadoActual = 54;
                Concatenar();
            }
            else
            {
                EstadoActual = 75;
            }

        }
        private void ProcesarEstado54()
        {
            LeerSiguienteCaracter();

            if (Es_C())
            {
                EstadoActual = 55;
                Concatenar();
            }
            else
            {
                EstadoActual = 75;
            }

        }

        private ComponenteLexico ProcesarEstado55()
        {
            ContinuarAnalisis = false;
            int PosicionFinal = Puntero - 1;
            int PosicionInicial = Puntero - Lexema.Length;
            ComponenteLexico Retorno = ComponenteLexico.CrearSimbolo(Lexema, Categoria.DESCENDENTE, NumeroLinea, PosicionInicial, PosicionFinal);
            return Retorno;
        }
        private ComponenteLexico ProcesarEstado56()
        {
            ContinuarAnalisis = false;
            int PosicionFinal = Puntero - 1;
            int PosicionInicial = Puntero - Lexema.Length;
            ComponenteLexico Retorno = ComponenteLexico.CrearSimbolo(Lexema, Categoria.COMA, NumeroLinea, PosicionInicial, PosicionFinal);
            return Retorno;
        }

        private void ProcesarEstado57()
        {
            LeerSiguienteCaracter();

            if (EsMayor())
            {
                EstadoActual = 58;
                Concatenar();
            }
            else if (EsIgual())
            {
                EstadoActual = 59;
                Concatenar();
            }
            else
            {
                EstadoActual = 60;
            }
        }
        private ComponenteLexico ProcesarEstado58()
        {
            ContinuarAnalisis = false;
            int PosicionFinal = Puntero - 1;
            int PosicionInicial = Puntero - Lexema.Length;
            ComponenteLexico Retorno = ComponenteLexico.CrearSimbolo(Lexema, Categoria.DIFERENTE_QUE, NumeroLinea, PosicionInicial, PosicionFinal);
            return Retorno;
        }
        private ComponenteLexico ProcesarEstado59()
        {
            ContinuarAnalisis = false;
            int PosicionFinal = Puntero - 1;
            int PosicionInicial = Puntero - Lexema.Length;
            ComponenteLexico Retorno = ComponenteLexico.CrearSimbolo(Lexema, Categoria.MENOR_IGUAL, NumeroLinea, PosicionInicial, PosicionFinal);
            return Retorno;
        }
        private ComponenteLexico ProcesarEstado60()
        {
            ContinuarAnalisis = false;
            DevolverPuntero();
            int PosicionFinal = Puntero - 1;
            int PosicionInicial = Puntero - Lexema.Length;
            ComponenteLexico Retorno = ComponenteLexico.CrearSimbolo(Lexema, Categoria.MENOR, NumeroLinea, PosicionInicial, PosicionFinal);
            return Retorno;
        }

        private void ProcesarEstado61()
        {
            LeerSiguienteCaracter();

            if (EsIgual())
            {
                EstadoActual = 63;
                Concatenar();
            }
            else
            {
                EstadoActual = 62;
            }
        }
        private ComponenteLexico ProcesarEstado62()
        {
            ContinuarAnalisis = false;
            DevolverPuntero();
            int PosicionFinal = Puntero - 1;
            int PosicionInicial = Puntero - Lexema.Length;
            ComponenteLexico Retorno = ComponenteLexico.CrearSimbolo(Lexema, Categoria.MAYOR, NumeroLinea, PosicionInicial, PosicionFinal);
            return Retorno;
        }
        private ComponenteLexico ProcesarEstado63()
        {
            ContinuarAnalisis = false;
            int PosicionFinal = Puntero - 1;
            int PosicionInicial = Puntero - Lexema.Length;
            ComponenteLexico Retorno = ComponenteLexico.CrearSimbolo(Lexema, Categoria.MAYOR_IGUAL, NumeroLinea, PosicionInicial, PosicionFinal);
            return Retorno;
        }
        private void ProcesarEstado64()
        {
            LeerSiguienteCaracter();
            if (EsIgual())
            {
                EstadoActual = 65;
                Concatenar();
            }
            else
            {
                EstadoActual = 66;
            }
        }
        private ComponenteLexico ProcesarEstado65()
        {
            ContinuarAnalisis = false;
            int PosicionFinal = Puntero - 1;
            int PosicionInicial = Puntero - Lexema.Length;
            ComponenteLexico Retorno = ComponenteLexico.CrearSimbolo(Lexema, Categoria.DIFERENTE_QUE, NumeroLinea, PosicionInicial, PosicionFinal);
            return Retorno;
        }
        private ComponenteLexico ProcesarEstado66()
        {
            ContinuarAnalisis = false;
            String Falla = "Diferente que no válido";
            string Causa = "Luego del caracter '!' se debe recibir el caracter '=' y se recibio un: " + CaracterActual;
            String Solucion = "Luego del caracter '!' se debe recibir el caracter '='";
            int PosicionFinal = Puntero - 1;
            int PosicionInicial = Puntero - Lexema.Length;
            DevolverPuntero();
            Error Error = Error.CrearErrorLexico(NumeroLinea, PosicionInicial, PosicionFinal, Falla, Causa, Solucion);
            GestorErrores.Agregar(Error);
            ComponenteLexico Retorno = ComponenteLexico.CrearDummy(Lexema + "=", Categoria.DIFERENTE_QUE, NumeroLinea, PosicionInicial, PosicionFinal);
            return Retorno;


        }

        private ComponenteLexico ProcesarEstado67()
        {
            ContinuarAnalisis = false;
            ComponenteLexico Retorno = ComponenteLexico.CrearSimbolo("@EOF@", Categoria.FIN_ARCHIVO, NumeroLinea, 1, 1);
            return Retorno;
        }

        private void ProcesarEstado68()
        {
            CargarNuevaLinea();
            EstadoActual = 0;
        }
        private ComponenteLexico ProcesarEstado69()
        {
            int count = Lexema.Length + 1;
            string Causa = "No se respeto la estructura de la cadena SELECT, el lexema digitado fue: " + Lexema;

            Lexema = "SELECT";
            ContinuarAnalisis = false;
            int PosicionInicial = Puntero - count;
            int PosicionFinal = PosicionInicial + 5;

            DevolverPuntero();
            String Falla = "SELECT no valido";
            String Solucion = "Asegurese de ingresar una cadena con la siguiente estructura SELECT";
            Error Error = Error.CrearErrorLexico(NumeroLinea, PosicionInicial, PosicionFinal, Falla, Causa, Solucion);
            GestorErrores.Agregar(Error);
            ComponenteLexico Retorno = ComponenteLexico.CrearDummy(Lexema, Categoria.SQL_SELECT, NumeroLinea, PosicionInicial, PosicionFinal);
            return Retorno;

        }
        private ComponenteLexico ProcesarEstado70()
        {
            int count = Lexema.Length + 1;
            string Causa = "No se respeto la estructura de la cadena FROM, el lexema digitado fue: " + Lexema;
            Lexema = "FROM";
            ContinuarAnalisis = false;
            int PosicionInicial = Puntero - count;
            int PosicionFinal = PosicionInicial + 3;

            DevolverPuntero();
            String Falla = "FROM no valido";
            String Solucion = "Asegurese de ingresar una cadena con la siguiente estructura FROM";
            Error Error = Error.CrearErrorLexico(NumeroLinea, PosicionInicial, PosicionFinal, Falla, Causa, Solucion);
            GestorErrores.Agregar(Error);
            ComponenteLexico Retorno = ComponenteLexico.CrearDummy(Lexema, Categoria.SQL_FROM, NumeroLinea, PosicionInicial, PosicionFinal);
            return Retorno;
        }
        private ComponenteLexico ProcesarEstado71()
        {

            int count = Lexema.Length + 1;
            string Causa = "No se respeto la estructura de la cadena WHERE, el lexema digitado fue: " + Lexema;
            Lexema = "WHERE";
            ContinuarAnalisis = false;
            int PosicionInicial = Puntero - count;
            int PosicionFinal = PosicionInicial + 4;
            DevolverPuntero();
            String Falla = "WHERE no valido";
            String Solucion = "Asegurese de ingresar una cadena con la siguiente estructura WHERE";
            Error Error = Error.CrearErrorLexico(NumeroLinea, PosicionInicial, PosicionFinal, Falla, Causa, Solucion);
            GestorErrores.Agregar(Error);
            ComponenteLexico Retorno = ComponenteLexico.CrearDummy(Lexema, Categoria.SQL_WHERE, NumeroLinea, PosicionInicial, PosicionFinal);
            return Retorno;
        }
        private ComponenteLexico ProcesarEstado72()
        {

            int count = Lexema.Length + 1;
            string Causa = "No se respeto la estructura de la cadena ORDER BY, el lexema digitado fue: " + Lexema;
            Lexema = "ORDER BY";
            ContinuarAnalisis = false;
            int PosicionInicial = Puntero - count;
            int PosicionFinal = PosicionInicial + 7;
            DevolverPuntero();
            String Falla = "Order by no valido";
            String Solucion = "Asegurese de ingresar una cadena con la siguiente estructura ORDER BY";
            Error Error = Error.CrearErrorLexico(NumeroLinea, PosicionInicial, PosicionFinal, Falla, Causa, Solucion);
            GestorErrores.Agregar(Error);
            ComponenteLexico Retorno = ComponenteLexico.CrearDummy(Lexema, Categoria.SQL_ORDER_BY, NumeroLinea, PosicionInicial, PosicionFinal);
            return Retorno;
        }
        private ComponenteLexico ProcesarEstado73()
        {

            int count = Lexema.Length + 1;
            string Causa = "No se respeto la estructura de la cadena AND, el lexema digitado fue: " + Lexema;
            Lexema = "AND";
            ContinuarAnalisis = false;
            int PosicionInicial = Puntero - count;
            int PosicionFinal = PosicionInicial + 2;
            DevolverPuntero();
            String Falla = "Conector Y no valido";
            String Solucion = "Asegurese de ingresar una cadena con la siguiente estructura AND";
            Error Error = Error.CrearErrorLexico(NumeroLinea, PosicionInicial, PosicionFinal, Falla, Causa, Solucion);
            GestorErrores.Agregar(Error);
            ComponenteLexico Retorno = ComponenteLexico.CrearDummy(Lexema, Categoria.CONECTOR_Y, NumeroLinea, PosicionInicial, PosicionFinal);
            return Retorno;
        }
        private ComponenteLexico ProcesarEstado74()
        {

            int count = Lexema.Length + 1;
            string Causa = "No se respeto la estructura de la cadena ASC, el lexema digitado fue: " + Lexema;
            Lexema = "ASC";
            ContinuarAnalisis = false;
            int PosicionInicial = Puntero - count;
            int PosicionFinal = PosicionInicial + 2;

            DevolverPuntero();
            String Falla = "Ascendente no valido";
            String Solucion = "Asegurese de ingresar una cadena con la siguiente estructura ASC";
            Error Error = Error.CrearErrorLexico(NumeroLinea, PosicionInicial, PosicionFinal, Falla, Causa, Solucion);
            GestorErrores.Agregar(Error);
            ComponenteLexico Retorno = ComponenteLexico.CrearDummy(Lexema, Categoria.ASCENDENTE, NumeroLinea, PosicionInicial, PosicionFinal);
            return Retorno;
        }
        private ComponenteLexico ProcesarEstado75()
        {
            int count = Lexema.Length + 1;
            string Causa = "No se respeto la estructura de la cadena DESC, el lexema digitado fue: " + Lexema;
            Lexema = "DESC";
            ContinuarAnalisis = false;
            int PosicionInicial = Puntero - count;
            int PosicionFinal = PosicionInicial + 4;
            DevolverPuntero();
            String Falla = "Descendente no valido";

            String Solucion = "Asegurese de ingresar una cadena con la siguiente estructura DESC";
            Error Error = Error.CrearErrorLexico(NumeroLinea, PosicionInicial, PosicionFinal, Falla, Causa, Solucion);
            GestorErrores.Agregar(Error);
            ComponenteLexico Retorno = ComponenteLexico.CrearDummy(Lexema, Categoria.DESCENDENTE, NumeroLinea, PosicionInicial, PosicionFinal);
            return Retorno;
        }
        private ComponenteLexico ProcesarEstado76()
        {
            int count = Lexema.Length + 1;
            var seed = Environment.TickCount;
            var random = new Random(seed);
            var value = random.Next(0, 1000);
            string Causa = "No se respeto la estructura de la cadena CAM_<nombre>, el lexema digitado fue: " + Lexema;
            Lexema = "CAM_" + value;
            ContinuarAnalisis = false;
            int PosicionInicial = Puntero - count;
            int PosicionFinal = PosicionInicial + Lexema.Length - 1;
            DevolverPuntero();
            String Falla = "Campo no valido";

            String Solucion = "Asegurese de ingresar una cadena con la siguiente estructura CAM_<nombre>";
            Error Error = Error.CrearErrorLexico(NumeroLinea, PosicionInicial, PosicionFinal, Falla, Causa, Solucion);
            GestorErrores.Agregar(Error);
            ComponenteLexico Retorno = ComponenteLexico.CrearDummy(Lexema, Categoria.CAMPO, NumeroLinea, PosicionInicial, PosicionFinal);
            return Retorno;
        }
        private ComponenteLexico ProcesarEstado77()
        {
            int count = Lexema.Length + 1;
            var seed = Environment.TickCount;
            var random = new Random(seed);
            var value = random.Next(0, 1000);
            string Causa = "No se respeto la estructura de la cadena TAB_<nombre>, el lexema digitado fue: " + Lexema;
            Lexema = "TAB_" + value;
            ContinuarAnalisis = false;
            int PosicionInicial = Puntero - count;
            int PosicionFinal = PosicionInicial + Lexema.Length - 1;
            DevolverPuntero();
            String Falla = "Tabla no valida";

            String Solucion = "Asegurese de ingresar una cadena con la siguiente estructura TAB_<nombre>";
            Error Error = Error.CrearErrorLexico(NumeroLinea, PosicionInicial, PosicionFinal, Falla, Causa, Solucion);
            GestorErrores.Agregar(Error);
            ComponenteLexico Retorno = ComponenteLexico.CrearDummy(Lexema, Categoria.TABLA, NumeroLinea, PosicionInicial, PosicionFinal);
            return Retorno;
        }
        private ComponenteLexico ProcesarEstado78()
        {
            String Falla = "Simoblo no reconocido por el legunaje";
            string Causa = "Recibí " + CaracterActual + " ";
            String Solucion = "Asegurese que el programa de entrada solo contenga simbolos validos";
            int PosicionFinal = Puntero - 1;
            int PosicionInicial = Puntero - 1;
            Error Error = Error.CrearErrorLexico(NumeroLinea, PosicionInicial, PosicionFinal, Falla, Causa, Solucion);
            GestorErrores.Agregar(Error);
            throw new Exception("Se ha presentado un problema durante el analisis lexico, dado que se leyo un simbolo desconocido: " + CaracterActual);
        }
        private ComponenteLexico ProcesarEstado79()
        {
            String Falla = "Simbolo no recuperable";
            string Causa = "Recibí '" + CaracterActual + "' y es imposible saber que necesitaba el usuario";
            String Solucion = "Asegurese que la cadena de simoblos sea valida o recuperable";
            int PosicionFinal = Puntero - 1;
            int PosicionInicial = Puntero - 1;
            Error Error = Error.CrearErrorLexico(NumeroLinea, PosicionInicial, PosicionFinal, Falla, Causa, Solucion);
            GestorErrores.Agregar(Error);
            throw new Exception("Se ha presentado un problema durante el analisis lexico, dado que el simbolo: '" + CaracterActual + "' es inteligible ");
        }
        private ComponenteLexico ProcesarEstado80()
        {

            Lexema = Lexema + "’";
            ContinuarAnalisis = false;
            String Falla = "Literal no valido";
            string Causa = "Luego de iniciar un literal sebe de cerrar con una comilla sencilla";
            String Solucion = "Luego de iniciar un literal, debe ser cerrado con una comilla sencilla";
            int PosicionFinal = Puntero - 1;
            int PosicionInicial = Puntero - Lexema.Length;

            DevolverPuntero();
            Error Error = Error.CrearErrorLexico(NumeroLinea, PosicionInicial, PosicionFinal, Falla, Causa, Solucion);
            GestorErrores.Agregar(Error);
            ComponenteLexico Retorno = ComponenteLexico.CrearDummy(Lexema + "'", Categoria.LITERAL, NumeroLinea, PosicionInicial, PosicionFinal);
            return Retorno;

        }


    }
}
