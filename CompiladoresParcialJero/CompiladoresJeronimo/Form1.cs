using CompiladoresJeronimo.Transversal.Cache;
using CompiladoresJeronimo.Transversal.Componente;
using CompiladoresJeronimo.Transversal.ManejadorErrores;
using System.IO;
using System.Windows.Forms;

namespace CompiladoresJeronimo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<ComponenteLexico> ListaDeComponentes = new List<ComponenteLexico>();




            for (int i = 0; i < TB_Fuente.Lines.Count(); i++)
            {
                Cache.GetCache().AgregarContenido(TB_Fuente.Lines[i]);
            }
            try
            {
                AnalizadorLexico.AnalizadorLexico Analex = AnalizadorLexico.AnalizadorLexico.Crear();
                ComponenteLexico Componente = null;
                do
                {
                    Componente = Analex.DevolverComponente();
                    MessageBox.Show(Componente.ToString());
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
                for (int i = 0; i < GestorErrores.ObtenerErrores().Count(); i++)
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

       


        private void BT_Organizar_Click(object sender, EventArgs e)
        {
            String CodigoOrganizado = "";

            for (int i = 0; i < TB_Fuente.Lines.Count(); i++)
            {
                CodigoOrganizado = CodigoOrganizado + (i + 1) + "   " + TB_Fuente.Lines[i] + "\r\n";
            }
            TB_Organizado.Text = CodigoOrganizado;
            
        }

        private void BT_Reiniciar_Click_1(object sender, EventArgs e)
        {
            Cache.GetCache().Reiniciar();
            TB_Fuente.Clear();
            TB_Organizado.Clear();
            dataGridView1.Rows.Clear();
        }

        private void BTCargarTipoArchivo_Click(object sender, EventArgs e)
        {
            if (RB_Archivo.Checked)
            {
                Form Formulario2 = new Form2();
                Formulario2.Show();
            }
        }
    }
}