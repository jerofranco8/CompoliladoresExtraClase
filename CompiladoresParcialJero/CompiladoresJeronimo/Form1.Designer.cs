namespace CompiladoresJeronimo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BT_Procesar = new System.Windows.Forms.Button();
            this.TB_Fuente = new System.Windows.Forms.TextBox();
            this.TB_Organizado = new System.Windows.Forms.TextBox();
            this.BTCargarTipoArchivo = new System.Windows.Forms.Button();
            this.BT_Reiniciar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TablaDeErrores = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PosicionInicalError = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PosicionFinalError = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Falla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Causa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Solucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Categoria_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lexema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Linea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Posicion_inicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Posicion_final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.TablaDeErrores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_Procesar
            // 
            this.BT_Procesar.BackColor = System.Drawing.Color.Silver;
            this.BT_Procesar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BT_Procesar.Location = new System.Drawing.Point(459, 213);
            this.BT_Procesar.Name = "BT_Procesar";
            this.BT_Procesar.Size = new System.Drawing.Size(195, 67);
            this.BT_Procesar.TabIndex = 0;
            this.BT_Procesar.Text = "!Procesar¡";
            this.BT_Procesar.UseVisualStyleBackColor = false;
            this.BT_Procesar.Click += new System.EventHandler(this.button1_Click);
            // 
            // TB_Fuente
            // 
            this.TB_Fuente.Location = new System.Drawing.Point(19, 17);
            this.TB_Fuente.Multiline = true;
            this.TB_Fuente.Name = "TB_Fuente";
            this.TB_Fuente.Size = new System.Drawing.Size(1053, 179);
            this.TB_Fuente.TabIndex = 1;
            // 
            // TB_Organizado
            // 
            this.TB_Organizado.Location = new System.Drawing.Point(19, 304);
            this.TB_Organizado.Multiline = true;
            this.TB_Organizado.Name = "TB_Organizado";
            this.TB_Organizado.Size = new System.Drawing.Size(1053, 162);
            this.TB_Organizado.TabIndex = 2;
            // 
            // BTCargarTipoArchivo
            // 
            this.BTCargarTipoArchivo.BackColor = System.Drawing.Color.Silver;
            this.BTCargarTipoArchivo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTCargarTipoArchivo.Location = new System.Drawing.Point(792, 213);
            this.BTCargarTipoArchivo.Name = "BTCargarTipoArchivo";
            this.BTCargarTipoArchivo.Size = new System.Drawing.Size(178, 67);
            this.BTCargarTipoArchivo.TabIndex = 5;
            this.BTCargarTipoArchivo.Text = "Cargar por archivo";
            this.BTCargarTipoArchivo.UseVisualStyleBackColor = false;
            this.BTCargarTipoArchivo.Click += new System.EventHandler(this.BTCargarTipoArchivo_Click);
            // 
            // BT_Reiniciar
            // 
            this.BT_Reiniciar.BackColor = System.Drawing.Color.Silver;
            this.BT_Reiniciar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BT_Reiniciar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BT_Reiniciar.Location = new System.Drawing.Point(87, 213);
            this.BT_Reiniciar.Name = "BT_Reiniciar";
            this.BT_Reiniciar.Size = new System.Drawing.Size(183, 67);
            this.BT_Reiniciar.TabIndex = 6;
            this.BT_Reiniciar.Text = "Reiniciar";
            this.BT_Reiniciar.UseVisualStyleBackColor = false;
            this.BT_Reiniciar.Click += new System.EventHandler(this.BT_Reiniciar_Click_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.TablaDeErrores);
            this.tabControl1.Location = new System.Drawing.Point(4, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1101, 614);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Wheat;
            this.tabPage1.Controls.Add(this.BT_Reiniciar);
            this.tabPage1.Controls.Add(this.BT_Procesar);
            this.tabPage1.Controls.Add(this.BTCargarTipoArchivo);
            this.tabPage1.Controls.Add(this.TB_Fuente);
            this.tabPage1.Controls.Add(this.TB_Organizado);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1093, 586);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Compilador";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1093, 586);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tabla de simbolos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Wheat;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Categoria_,
            this.Lexema,
            this.Linea,
            this.Posicion_inicial,
            this.Posicion_final,
            this.Tipo});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1093, 590);
            this.dataGridView1.TabIndex = 0;
            // 
            // TablaDeErrores
            // 
            this.TablaDeErrores.Controls.Add(this.dataGridView2);
            this.TablaDeErrores.Location = new System.Drawing.Point(4, 24);
            this.TablaDeErrores.Name = "TablaDeErrores";
            this.TablaDeErrores.Padding = new System.Windows.Forms.Padding(3);
            this.TablaDeErrores.Size = new System.Drawing.Size(1093, 586);
            this.TablaDeErrores.TabIndex = 2;
            this.TablaDeErrores.Text = "Tabla de errores";
            this.TablaDeErrores.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Wheat;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.a,
            this.PosicionInicalError,
            this.PosicionFinalError,
            this.Falla,
            this.Causa,
            this.Solucion,
            this.Tipo_});
            this.dataGridView2.Location = new System.Drawing.Point(-4, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(1097, 590);
            this.dataGridView2.TabIndex = 0;
            // 
            // a
            // 
            this.a.HeaderText = "Linea";
            this.a.Name = "a";
            this.a.Width = 63;
            // 
            // PosicionInicalError
            // 
            this.PosicionInicalError.HeaderText = "Posicion Inical Error";
            this.PosicionInicalError.Name = "PosicionInicalError";
            this.PosicionInicalError.Width = 70;
            // 
            // PosicionFinalError
            // 
            this.PosicionFinalError.HeaderText = "Posicion Final Error";
            this.PosicionFinalError.Name = "PosicionFinalError";
            this.PosicionFinalError.Width = 70;
            // 
            // Falla
            // 
            this.Falla.HeaderText = "Falla";
            this.Falla.Name = "Falla";
            this.Falla.Width = 250;
            // 
            // Causa
            // 
            this.Causa.HeaderText = "Causa";
            this.Causa.Name = "Causa";
            this.Causa.Width = 250;
            // 
            // Solucion
            // 
            this.Solucion.HeaderText = "Solucion";
            this.Solucion.Name = "Solucion";
            this.Solucion.Width = 250;
            // 
            // Tipo_
            // 
            this.Tipo_.HeaderText = "Tipo";
            this.Tipo_.Name = "Tipo_";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Categoria_
            // 
            this.Categoria_.HeaderText = "Categoria";
            this.Categoria_.Name = "Categoria_";
            this.Categoria_.Width = 150;
            // 
            // Lexema
            // 
            this.Lexema.HeaderText = "Lexema";
            this.Lexema.Name = "Lexema";
            this.Lexema.Width = 450;
            // 
            // Linea
            // 
            this.Linea.HeaderText = "Linea";
            this.Linea.Name = "Linea";
            // 
            // Posicion_inicial
            // 
            this.Posicion_inicial.HeaderText = "Posicion_inicial";
            this.Posicion_inicial.Name = "Posicion_inicial";
            // 
            // Posicion_final
            // 
            this.Posicion_final.HeaderText = "Posicion_final";
            this.Posicion_final.Name = "Posicion_final";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 613);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Compilador";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.TablaDeErrores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button BT_Procesar;
        private TextBox TB_Organizado;

        private Button BTCargarTipoArchivo;
        private Button BT_Reiniciar;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private TabPage TablaDeErrores;
        private DataGridView dataGridView2;
        public TextBox TB_Fuente;
        private OpenFileDialog openFileDialog1;
        private DataGridViewTextBoxColumn a;
        private DataGridViewTextBoxColumn PosicionInicalError;
        private DataGridViewTextBoxColumn PosicionFinalError;
        private DataGridViewTextBoxColumn Falla;
        private DataGridViewTextBoxColumn Causa;
        private DataGridViewTextBoxColumn Solucion;
        private DataGridViewTextBoxColumn Tipo_;
        private DataGridViewTextBoxColumn Categoria_;
        private DataGridViewTextBoxColumn Lexema;
        private DataGridViewTextBoxColumn Linea;
        private DataGridViewTextBoxColumn Posicion_inicial;
        private DataGridViewTextBoxColumn Posicion_final;
        private DataGridViewTextBoxColumn Tipo;
    }
}