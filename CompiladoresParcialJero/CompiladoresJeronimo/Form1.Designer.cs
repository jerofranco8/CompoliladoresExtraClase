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
            this.BT_Organizar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RB_Archivo = new System.Windows.Forms.RadioButton();
            this.RB_Consola = new System.Windows.Forms.RadioButton();
            this.BTCargarTipoArchivo = new System.Windows.Forms.Button();
            this.BT_Reiniciar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Categoria_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lexema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Linea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Posicion_inicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Posicion_final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PosicionInicalError = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PosicionFinalError = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Falla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Causa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Solucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_Procesar
            // 
            this.BT_Procesar.Location = new System.Drawing.Point(237, 264);
            this.BT_Procesar.Name = "BT_Procesar";
            this.BT_Procesar.Size = new System.Drawing.Size(139, 47);
            this.BT_Procesar.TabIndex = 0;
            this.BT_Procesar.Text = "!Procesar¡";
            this.BT_Procesar.UseVisualStyleBackColor = true;
            this.BT_Procesar.Click += new System.EventHandler(this.button1_Click);
            // 
            // TB_Fuente
            // 
            this.TB_Fuente.Location = new System.Drawing.Point(19, 94);
            this.TB_Fuente.Multiline = true;
            this.TB_Fuente.Name = "TB_Fuente";
            this.TB_Fuente.Size = new System.Drawing.Size(586, 138);
            this.TB_Fuente.TabIndex = 1;
            // 
            // TB_Organizado
            // 
            this.TB_Organizado.Location = new System.Drawing.Point(19, 345);
            this.TB_Organizado.Multiline = true;
            this.TB_Organizado.Name = "TB_Organizado";
            this.TB_Organizado.Size = new System.Drawing.Size(586, 121);
            this.TB_Organizado.TabIndex = 2;
            // 
            // BT_Organizar
            // 
            this.BT_Organizar.Location = new System.Drawing.Point(19, 264);
            this.BT_Organizar.Name = "BT_Organizar";
            this.BT_Organizar.Size = new System.Drawing.Size(143, 47);
            this.BT_Organizar.TabIndex = 3;
            this.BT_Organizar.Text = "!Organizar codigo¡";
            this.BT_Organizar.UseVisualStyleBackColor = true;
            this.BT_Organizar.Click += new System.EventHandler(this.BT_Organizar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RB_Archivo);
            this.groupBox1.Controls.Add(this.RB_Consola);
            this.groupBox1.Location = new System.Drawing.Point(19, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 43);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo De Carga";
            // 
            // RB_Archivo
            // 
            this.RB_Archivo.AutoSize = true;
            this.RB_Archivo.Location = new System.Drawing.Point(385, 16);
            this.RB_Archivo.Name = "RB_Archivo";
            this.RB_Archivo.Size = new System.Drawing.Size(66, 19);
            this.RB_Archivo.TabIndex = 1;
            this.RB_Archivo.Text = "Archivo";
            this.RB_Archivo.UseVisualStyleBackColor = true;
            // 
            // RB_Consola
            // 
            this.RB_Consola.AutoSize = true;
            this.RB_Consola.Checked = true;
            this.RB_Consola.Location = new System.Drawing.Point(152, 16);
            this.RB_Consola.Name = "RB_Consola";
            this.RB_Consola.Size = new System.Drawing.Size(68, 19);
            this.RB_Consola.TabIndex = 0;
            this.RB_Consola.TabStop = true;
            this.RB_Consola.Text = "Consola";
            this.RB_Consola.UseVisualStyleBackColor = true;
            // 
            // BTCargarTipoArchivo
            // 
            this.BTCargarTipoArchivo.Location = new System.Drawing.Point(637, 30);
            this.BTCargarTipoArchivo.Name = "BTCargarTipoArchivo";
            this.BTCargarTipoArchivo.Size = new System.Drawing.Size(121, 43);
            this.BTCargarTipoArchivo.TabIndex = 5;
            this.BTCargarTipoArchivo.Text = "Cargar Tipo De Archivo";
            this.BTCargarTipoArchivo.UseVisualStyleBackColor = true;
            this.BTCargarTipoArchivo.Click += new System.EventHandler(this.BTCargarTipoArchivo_Click);
            // 
            // BT_Reiniciar
            // 
            this.BT_Reiniciar.Location = new System.Drawing.Point(457, 264);
            this.BT_Reiniciar.Name = "BT_Reiniciar";
            this.BT_Reiniciar.Size = new System.Drawing.Size(136, 47);
            this.BT_Reiniciar.TabIndex = 6;
            this.BT_Reiniciar.Text = "Reiniciar";
            this.BT_Reiniciar.UseVisualStyleBackColor = true;
            this.BT_Reiniciar.Click += new System.EventHandler(this.BT_Reiniciar_Click_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(26, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(797, 532);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.BT_Reiniciar);
            this.tabPage1.Controls.Add(this.BT_Procesar);
            this.tabPage1.Controls.Add(this.BTCargarTipoArchivo);
            this.tabPage1.Controls.Add(this.TB_Fuente);
            this.tabPage1.Controls.Add(this.TB_Organizado);
            this.tabPage1.Controls.Add(this.BT_Organizar);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(789, 504);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(789, 504);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Categoria_,
            this.Lexema,
            this.Linea,
            this.Posicion_inicial,
            this.Posicion_final,
            this.Tipo});
            this.dataGridView1.Location = new System.Drawing.Point(24, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(676, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // Categoria_
            // 
            this.Categoria_.HeaderText = "Categoria";
            this.Categoria_.Name = "Categoria_";
            // 
            // Lexema
            // 
            this.Lexema.HeaderText = "Lexema";
            this.Lexema.Name = "Lexema";
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
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(789, 504);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.a,
            this.PosicionInicalError,
            this.PosicionFinalError,
            this.Falla,
            this.Causa,
            this.Solucion,
            this.Tipo_});
            this.dataGridView2.Location = new System.Drawing.Point(6, 43);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(745, 367);
            this.dataGridView2.TabIndex = 0;
            // 
            // a
            // 
            this.a.HeaderText = "Linea";
            this.a.Name = "a";
            // 
            // PosicionInicalError
            // 
            this.PosicionInicalError.HeaderText = "Posicion Inical Error";
            this.PosicionInicalError.Name = "PosicionInicalError";
            // 
            // PosicionFinalError
            // 
            this.PosicionFinalError.HeaderText = "Posicion Final Error";
            this.PosicionFinalError.Name = "PosicionFinalError";
            // 
            // Falla
            // 
            this.Falla.HeaderText = "Falla";
            this.Falla.Name = "Falla";
            // 
            // Causa
            // 
            this.Causa.HeaderText = "Causa";
            this.Causa.Name = "Causa";
            // 
            // Solucion
            // 
            this.Solucion.HeaderText = "Solucion";
            this.Solucion.Name = "Solucion";
            // 
            // Tipo_
            // 
            this.Tipo_.HeaderText = "Tipo";
            this.Tipo_.Name = "Tipo_";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 610);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button BT_Procesar;
        private TextBox TB_Fuente;
        private TextBox TB_Organizado;
        private Button BT_Organizar;
        private GroupBox groupBox1;
        private RadioButton RB_Archivo;
        private RadioButton RB_Consola;
        private Button BTCargarTipoArchivo;
        private Button BT_Reiniciar;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Categoria_;
        private DataGridViewTextBoxColumn Lexema;
        private DataGridViewTextBoxColumn Linea;
        private DataGridViewTextBoxColumn Posicion_inicial;
        private DataGridViewTextBoxColumn Posicion_final;
        private DataGridViewTextBoxColumn Tipo;
        private TabPage tabPage3;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn a;
        private DataGridViewTextBoxColumn PosicionInicalError;
        private DataGridViewTextBoxColumn PosicionFinalError;
        private DataGridViewTextBoxColumn Falla;
        private DataGridViewTextBoxColumn Causa;
        private DataGridViewTextBoxColumn Solucion;
        private DataGridViewTextBoxColumn Tipo_;
    }
}