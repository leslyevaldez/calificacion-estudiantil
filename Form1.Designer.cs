namespace calificaciones.leliv
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.lblNota4 = new System.Windows.Forms.Label();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.txtNota4 = new System.Windows.Forms.TextBox();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.btnPromedio = new System.Windows.Forms.Button();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblCompletivo = new System.Windows.Forms.Label();
            this.txtCompletivo = new System.Windows.Forms.TextBox();
            this.btnCompletivo = new System.Windows.Forms.Button();
            this.lblExtraordinario = new System.Windows.Forms.Label();
            this.txtExtraordinario = new System.Windows.Forms.TextBox();
            this.btnExtraordinario = new System.Windows.Forms.Button();
            this.lblResultadoCompletivo = new System.Windows.Forms.Label();
            this.lblResultadoExtraordinario = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(262, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(276, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Calificacion De Estudiantes";
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Location = new System.Drawing.Point(204, 53);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(49, 16);
            this.lblNota1.TabIndex = 1;
            this.lblNota1.Text = "Nota 1:";
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(338, 53);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(162, 22);
            this.txtNota1.TabIndex = 2;
            // 
            // lblNota4
            // 
            this.lblNota4.AutoSize = true;
            this.lblNota4.Location = new System.Drawing.Point(204, 163);
            this.lblNota4.Name = "lblNota4";
            this.lblNota4.Size = new System.Drawing.Size(49, 16);
            this.lblNota4.TabIndex = 3;
            this.lblNota4.Text = "Nota 4:";
            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.Location = new System.Drawing.Point(204, 126);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(49, 16);
            this.lblNota3.TabIndex = 4;
            this.lblNota3.Text = "Nota 3:";
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Location = new System.Drawing.Point(204, 92);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(49, 16);
            this.lblNota2.TabIndex = 5;
            this.lblNota2.Text = "Nota 2:";
            // 
            // txtNota4
            // 
            this.txtNota4.Location = new System.Drawing.Point(338, 163);
            this.txtNota4.Name = "txtNota4";
            this.txtNota4.Size = new System.Drawing.Size(162, 22);
            this.txtNota4.TabIndex = 6;
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(338, 126);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(162, 22);
            this.txtNota3.TabIndex = 8;
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(338, 92);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(162, 22);
            this.txtNota2.TabIndex = 9;
            // 
            // btnPromedio
            // 
            this.btnPromedio.Location = new System.Drawing.Point(217, 205);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(283, 23);
            this.btnPromedio.TabIndex = 10;
            this.btnPromedio.Text = "Calcular Promedio";
            this.btnPromedio.UseVisualStyleBackColor = true;
            this.btnPromedio.Click += new System.EventHandler(this.btnPromedio_Click);
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(204, 245);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(66, 16);
            this.lblPromedio.TabIndex = 11;
            this.lblPromedio.Text = "Promedio";
            // 
            // lblCompletivo
            // 
            this.lblCompletivo.AutoSize = true;
            this.lblCompletivo.Location = new System.Drawing.Point(204, 277);
            this.lblCompletivo.Name = "lblCompletivo";
            this.lblCompletivo.Size = new System.Drawing.Size(110, 16);
            this.lblCompletivo.TabIndex = 12;
            this.lblCompletivo.Text = "Nota Completivo:";
            // 
            // txtCompletivo
            // 
            this.txtCompletivo.Location = new System.Drawing.Point(350, 271);
            this.txtCompletivo.Name = "txtCompletivo";
            this.txtCompletivo.Size = new System.Drawing.Size(162, 22);
            this.txtCompletivo.TabIndex = 13;
            // 
            // btnCompletivo
            // 
            this.btnCompletivo.Location = new System.Drawing.Point(217, 299);
            this.btnCompletivo.Name = "btnCompletivo";
            this.btnCompletivo.Size = new System.Drawing.Size(283, 23);
            this.btnCompletivo.TabIndex = 14;
            this.btnCompletivo.Text = "Calcular Completivo";
            this.btnCompletivo.UseVisualStyleBackColor = true;
            this.btnCompletivo.Click += new System.EventHandler(this.btnCompletivo_Click);
            // 
            // lblExtraordinario
            // 
            this.lblExtraordinario.AutoSize = true;
            this.lblExtraordinario.Location = new System.Drawing.Point(214, 371);
            this.lblExtraordinario.Name = "lblExtraordinario";
            this.lblExtraordinario.Size = new System.Drawing.Size(125, 16);
            this.lblExtraordinario.TabIndex = 15;
            this.lblExtraordinario.Text = "Nota Extraordinario:";
            // 
            // txtExtraordinario
            // 
            this.txtExtraordinario.Location = new System.Drawing.Point(350, 365);
            this.txtExtraordinario.Name = "txtExtraordinario";
            this.txtExtraordinario.Size = new System.Drawing.Size(162, 22);
            this.txtExtraordinario.TabIndex = 16;
            // 
            // btnExtraordinario
            // 
            this.btnExtraordinario.Location = new System.Drawing.Point(217, 405);
            this.btnExtraordinario.Name = "btnExtraordinario";
            this.btnExtraordinario.Size = new System.Drawing.Size(283, 23);
            this.btnExtraordinario.TabIndex = 17;
            this.btnExtraordinario.Text = "Calcular Extraordinario";
            this.btnExtraordinario.UseVisualStyleBackColor = true;
            this.btnExtraordinario.Click += new System.EventHandler(this.btnExtraordinario_Click);
            // 
            // lblResultadoCompletivo
            // 
            this.lblResultadoCompletivo.AutoSize = true;
            this.lblResultadoCompletivo.Location = new System.Drawing.Point(214, 334);
            this.lblResultadoCompletivo.Name = "lblResultadoCompletivo";
            this.lblResultadoCompletivo.Size = new System.Drawing.Size(69, 16);
            this.lblResultadoCompletivo.TabIndex = 18;
            this.lblResultadoCompletivo.Text = "Resultado";
            // 
            // lblResultadoExtraordinario
            // 
            this.lblResultadoExtraordinario.AutoSize = true;
            this.lblResultadoExtraordinario.Location = new System.Drawing.Point(214, 431);
            this.lblResultadoExtraordinario.Name = "lblResultadoExtraordinario";
            this.lblResultadoExtraordinario.Size = new System.Drawing.Size(69, 16);
            this.lblResultadoExtraordinario.TabIndex = 19;
            this.lblResultadoExtraordinario.Text = "Resultado";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(665, 23);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 20;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(665, 65);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 21;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblResultadoExtraordinario);
            this.Controls.Add(this.lblResultadoCompletivo);
            this.Controls.Add(this.btnExtraordinario);
            this.Controls.Add(this.txtExtraordinario);
            this.Controls.Add(this.lblExtraordinario);
            this.Controls.Add(this.btnCompletivo);
            this.Controls.Add(this.txtCompletivo);
            this.Controls.Add(this.lblCompletivo);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.btnPromedio);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.txtNota4);
            this.Controls.Add(this.lblNota2);
            this.Controls.Add(this.lblNota3);
            this.Controls.Add(this.lblNota4);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.lblNota1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.Label lblNota4;
        private System.Windows.Forms.Label lblNota3;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.TextBox txtNota4;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.Button btnPromedio;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblCompletivo;
        private System.Windows.Forms.TextBox txtCompletivo;
        private System.Windows.Forms.Button btnCompletivo;
        private System.Windows.Forms.Label lblExtraordinario;
        private System.Windows.Forms.TextBox txtExtraordinario;
        private System.Windows.Forms.Button btnExtraordinario;
        private System.Windows.Forms.Label lblResultadoCompletivo;
        private System.Windows.Forms.Label lblResultadoExtraordinario;
        private System.Windows.Forms.Button btnLimpiar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnSalir;
    }
}

