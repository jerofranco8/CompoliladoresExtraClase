namespace CompiladoresJeronimo
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTCargarTipoArchivo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RB_Archivo = new System.Windows.Forms.RadioButton();
            this.RB_Consola = new System.Windows.Forms.RadioButton();
            this.TB_Organizado = new System.Windows.Forms.TextBox();
            this.TB_Fuente = new System.Windows.Forms.TextBox();
            this.BT_Procesar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CargarArchivo = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BT_Reiniciar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTCargarTipoArchivo
            // 
            this.BTCargarTipoArchivo.Location = new System.Drawing.Point(640, 26);
            this.BTCargarTipoArchivo.Name = "BTCargarTipoArchivo";
            this.BTCargarTipoArchivo.Size = new System.Drawing.Size(121, 43);
            this.BTCargarTipoArchivo.TabIndex = 11;
            this.BTCargarTipoArchivo.Text = "Cargar Tipo De Archivo";
            this.BTCargarTipoArchivo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RB_Archivo);
            this.groupBox1.Controls.Add(this.RB_Consola);
            this.groupBox1.Location = new System.Drawing.Point(39, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 43);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo De Carga";
            // 
            // RB_Archivo
            // 
            this.RB_Archivo.AutoSize = true;
            this.RB_Archivo.Checked = true;
            this.RB_Archivo.Location = new System.Drawing.Point(385, 16);
            this.RB_Archivo.Name = "RB_Archivo";
            this.RB_Archivo.Size = new System.Drawing.Size(66, 19);
            this.RB_Archivo.TabIndex = 1;
            this.RB_Archivo.TabStop = true;
            this.RB_Archivo.Text = "Archivo";
            this.RB_Archivo.UseVisualStyleBackColor = true;
            // 
            // RB_Consola
            // 
            this.RB_Consola.AutoSize = true;
            this.RB_Consola.Location = new System.Drawing.Point(152, 16);
            this.RB_Consola.Name = "RB_Consola";
            this.RB_Consola.Size = new System.Drawing.Size(68, 19);
            this.RB_Consola.TabIndex = 0;
            this.RB_Consola.Text = "Consola";
            this.RB_Consola.UseVisualStyleBackColor = true;
            // 
            // TB_Organizado
            // 
            this.TB_Organizado.Location = new System.Drawing.Point(39, 303);
            this.TB_Organizado.Multiline = true;
            this.TB_Organizado.Name = "TB_Organizado";
            this.TB_Organizado.Size = new System.Drawing.Size(586, 121);
            this.TB_Organizado.TabIndex = 8;
            // 
            // TB_Fuente
            // 
            this.TB_Fuente.Location = new System.Drawing.Point(39, 149);
            this.TB_Fuente.Name = "TB_Fuente";
            this.TB_Fuente.Size = new System.Drawing.Size(586, 23);
            this.TB_Fuente.TabIndex = 7;
            // 
            // BT_Procesar
            // 
            this.BT_Procesar.Location = new System.Drawing.Point(112, 206);
            this.BT_Procesar.Name = "BT_Procesar";
            this.BT_Procesar.Size = new System.Drawing.Size(206, 74);
            this.BT_Procesar.TabIndex = 6;
            this.BT_Procesar.Text = "!Procesar¡";
            this.BT_Procesar.UseVisualStyleBackColor = true;
            this.BT_Procesar.Click += new System.EventHandler(this.BT_Procesar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ubicacion Del Archivo ";
            // 
            // CargarArchivo
            // 
            this.CargarArchivo.Location = new System.Drawing.Point(640, 149);
            this.CargarArchivo.Name = "CargarArchivo";
            this.CargarArchivo.Size = new System.Drawing.Size(121, 41);
            this.CargarArchivo.TabIndex = 13;
            this.CargarArchivo.Text = "Cargar Archivo";
            this.CargarArchivo.UseVisualStyleBackColor = true;
            this.CargarArchivo.Click += new System.EventHandler(this.CargarArchivo_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BT_Reiniciar
            // 
            this.BT_Reiniciar.Location = new System.Drawing.Point(369, 206);
            this.BT_Reiniciar.Name = "BT_Reiniciar";
            this.BT_Reiniciar.Size = new System.Drawing.Size(203, 74);
            this.BT_Reiniciar.TabIndex = 14;
            this.BT_Reiniciar.Text = "Reiniciar";
            this.BT_Reiniciar.UseVisualStyleBackColor = true;
            this.BT_Reiniciar.Click += new System.EventHandler(this.BT_Reiniciar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BT_Reiniciar);
            this.Controls.Add(this.CargarArchivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTCargarTipoArchivo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TB_Organizado);
            this.Controls.Add(this.TB_Fuente);
            this.Controls.Add(this.BT_Procesar);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BTCargarTipoArchivo;
        private GroupBox groupBox1;
        private RadioButton RB_Archivo;
        private RadioButton RB_Consola;
        private TextBox TB_Organizado;
        private TextBox TB_Fuente;
        private Button BT_Procesar;
        private Label label1;
        private Button CargarArchivo;
        private OpenFileDialog openFileDialog1;
        private Button BT_Reiniciar;
    }
}