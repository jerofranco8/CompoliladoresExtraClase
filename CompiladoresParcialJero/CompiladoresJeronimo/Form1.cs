using CompiladoresJeronimo.Transversal.Cache;
using CompiladoresJeronimo.Transversal.Componente;
using CompiladoresJeronimo.Transversal.ManejadorErrores;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CompiladoresJeronimo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private String CodigoDesorganizado;

        private void button1_Click(object sender, EventArgs e)
        {

            List<ComponenteLexico> ListaDeComponentes = new List<ComponenteLexico>();

            String CodigoOrganizado = "";

            Cache.GetCache().Reiniciar();
            GestorErrores.Reiniciar();
            TB_Organizado.Clear();
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            CodigoDesorganizado = "";



            if (string.IsNullOrEmpty(TB_Fuente.Text))
            {
                MessageBox.Show("Debes ingresar una sentencia SQL");
                return;
            }

            for (int i = 0; i < TB_Fuente.Lines.Count(); i++)
            {
                CodigoOrganizado = CodigoOrganizado + (i + 1) + "   " + TB_Fuente.Lines[i] + "\r\n";
            }
            TB_Organizado.Text = CodigoOrganizado;



            for (int i = 0; i < TB_Fuente.Lines.Count(); i++)
            {
                Cache.GetCache().AgregarContenido(TB_Fuente.Lines[i]);
            }

            try
            {
                AnalisadosSintactico.AnalisisSintactico AnaSin = new AnalisadosSintactico.AnalisisSintactico();
                AnaSin.Analizar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            try
            {
                AnalizadorLexico.AnalizadorLexico Analex = AnalizadorLexico.AnalizadorLexico.Crear();
                ComponenteLexico Componente = null;
                do
                {
                    Componente = Analex.DevolverComponente();

                    ListaDeComponentes.Add(Componente);

                } while (!Componente.GetCategoria().Equals(Categoria.FIN_ARCHIVO));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            for (int i = 0; i < ListaDeComponentes.Count(); i++)
            {
                DataGridViewRow Fila = new DataGridViewRow();
                Fila.CreateCells(dataGridView1);
                Fila.Cells[0].Value = ListaDeComponentes[i].GetCategoria();
                Fila.Cells[1].Value = ListaDeComponentes[i].GetLexema();
                Fila.Cells[2].Value = ListaDeComponentes[i].GetNumeroLinea();
                Fila.Cells[3].Value = ListaDeComponentes[i].GetPosicionInicial();
                Fila.Cells[4].Value = ListaDeComponentes[i].GetPosicionFinal();
                Fila.Cells[5].Value = ListaDeComponentes[i].GetTipo();
                dataGridView1.Rows.Add(Fila);
            }
            if (GestorErrores.HayErroresAnalisis())
            {

                if (GestorErrores.ObtenerErrores().Count%2==0)
                {
                    for (int i = GestorErrores.ObtenerErrores().Count()/2; i < GestorErrores.ObtenerErrores().Count(); i++)
                    {


                        DataGridViewRow Fila2 = new DataGridViewRow();
                        Fila2.CreateCells(dataGridView2);
                        Fila2.Cells[0].Value = GestorErrores.ObtenerErrores()[i].GetNumeroLinea();
                        Fila2.Cells[1].Value = GestorErrores.ObtenerErrores()[i].GetPosicionInicial();
                        Fila2.Cells[2].Value = GestorErrores.ObtenerErrores()[i].GetPosicionFinal();
                        Fila2.Cells[3].Value = GestorErrores.ObtenerErrores()[i].GetFalla();
                        Fila2.Cells[4].Value = GestorErrores.ObtenerErrores()[i].GetCausa();
                        Fila2.Cells[5].Value = GestorErrores.ObtenerErrores()[i].GetSolucion();
                        Fila2.Cells[6].Value = GestorErrores.ObtenerErrores()[i].GetTipo();
                        dataGridView2.Rows.Add(Fila2);




                    }
                }
                else {
                    for (int i = (GestorErrores.ObtenerErrores().Count()-1)/2; i < GestorErrores.ObtenerErrores().Count(); i++)
                    {


                        DataGridViewRow Fila2 = new DataGridViewRow();
                        Fila2.CreateCells(dataGridView2);
                        Fila2.Cells[0].Value = GestorErrores.ObtenerErrores()[i].GetNumeroLinea();
                        Fila2.Cells[1].Value = GestorErrores.ObtenerErrores()[i].GetPosicionInicial();
                        Fila2.Cells[2].Value = GestorErrores.ObtenerErrores()[i].GetPosicionFinal();
                        Fila2.Cells[3].Value = GestorErrores.ObtenerErrores()[i].GetFalla();
                        Fila2.Cells[4].Value = GestorErrores.ObtenerErrores()[i].GetCausa();
                        Fila2.Cells[5].Value = GestorErrores.ObtenerErrores()[i].GetSolucion();
                        Fila2.Cells[6].Value = GestorErrores.ObtenerErrores()[i].GetTipo();
                        dataGridView2.Rows.Add(Fila2);


                    }

                }
                
            }


        }




        private void BTCargarTipoArchivo_Click(object sender, EventArgs e)
        {

            DialogResult respuesta;
            string RutaArchivo;
            openFileDialog1.Title = "Abrir archivo de texto";
            openFileDialog1.Filter = "Archivo de texto|*.txt";
            openFileDialog1.FileName = "";

            respuesta = openFileDialog1.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                RutaArchivo = openFileDialog1.FileName;
                FileStream Archivo = new FileStream(RutaArchivo, FileMode.Open, FileAccess.Read);
                StreamReader Leer = new StreamReader(Archivo);
                TB_Fuente.Text = "";
                while (!Leer.EndOfStream)
                {
                    CodigoDesorganizado = (CodigoDesorganizado + Leer.ReadLine() + "\r\n");
                }
                CodigoDesorganizado = CodigoDesorganizado.Remove(CodigoDesorganizado.Length - 2);
                TB_Fuente.Text = CodigoDesorganizado;
            }
            else
            {
                MessageBox.Show("Cancelaste abrir archivo");
            }
        }


    }
}