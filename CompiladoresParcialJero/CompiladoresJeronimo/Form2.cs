using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CompiladoresJeronimo.Transversal.Cache;
using CompiladoresJeronimo.Transversal.Componente;
using System.Runtime.Intrinsics.X86;

namespace CompiladoresJeronimo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private String CodigoOrganizado;
        private String CodigoDesorganizado;

        private void CargarArchivo_Click(object sender, EventArgs e)
        {
            
            DialogResult respuesta;
            string RutaArchivo;
            openFileDialog1.Title = "Abrir archivo de texto";
            openFileDialog1.Filter = "Archivo de texto|*.txt";
            openFileDialog1.FileName = "";

            respuesta= openFileDialog1.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                RutaArchivo = openFileDialog1.FileName;
                FileStream Archivo = new FileStream(RutaArchivo, FileMode.Open, FileAccess.Read);
                StreamReader Leer = new StreamReader(Archivo);
                TB_Organizado.Text = "";
                while (!Leer.EndOfStream) {
                    CodigoDesorganizado = (CodigoDesorganizado+ Leer.ReadLine()+ "\r\n");
                }
                CodigoDesorganizado = CodigoDesorganizado.Remove(CodigoDesorganizado.Length - 2);
                TB_Fuente.Text = RutaArchivo;
                TB_Organizado.Text=CodigoDesorganizado;
            }
            else
            {
                MessageBox.Show("Cancelaste abrir archivo");
            }
            

        }

        private void BT_Procesar_Click(object sender, EventArgs e)
        {
            TB_Organizado.Text = CodigoDesorganizado;
            for (int i = 0; i < TB_Organizado.Lines.Count(); i++) 
            {
                Cache.GetCache().AgregarContenido(TB_Organizado.Lines[i]);
            }

            for (int i = 0; i < TB_Organizado.Lines.Count(); i++)
            {
                CodigoOrganizado = CodigoOrganizado + (i + 1) + "   " + TB_Organizado.Lines[i] + "\r\n";
            }

            TB_Organizado.Text = CodigoOrganizado;

            try
            {
                AnalizadorLexico.AnalizadorLexico Analex = AnalizadorLexico.AnalizadorLexico.Crear();
                ComponenteLexico Componente = null;
                do
                {
                    Componente = Analex.DevolverComponente();
                    MessageBox.Show(Componente.ToString());
                } while (!Componente.GetCategoria().Equals(Categoria.FIN_ARCHIVO));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BT_Reiniciar_Click(object sender, EventArgs e)
        {
            Cache.GetCache().Reiniciar();
            TB_Fuente.Clear();
            TB_Organizado.Clear();
            CodigoDesorganizado = "";
            CodigoOrganizado = "";
        }

        
    }
}
