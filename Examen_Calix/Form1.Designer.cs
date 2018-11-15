namespace Examen_Calix
{
    partial class frmInicio
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregarCancion = new System.Windows.Forms.Button();
            this.btnEliminarCancion = new System.Windows.Forms.Button();
            this.btnReporteCanciones = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 290);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnReporteCanciones);
            this.groupBox1.Controls.Add(this.btnEliminarCancion);
            this.groupBox1.Controls.Add(this.btnAgregarCancion);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(42, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 218);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inicio de la Aplicacion";
            // 
            // btnAgregarCancion
            // 
            this.btnAgregarCancion.Location = new System.Drawing.Point(36, 51);
            this.btnAgregarCancion.Name = "btnAgregarCancion";
            this.btnAgregarCancion.Size = new System.Drawing.Size(134, 59);
            this.btnAgregarCancion.TabIndex = 0;
            this.btnAgregarCancion.Text = "Agregar Canciones";
            this.btnAgregarCancion.UseVisualStyleBackColor = true;
            this.btnAgregarCancion.Click += new System.EventHandler(this.btnAgregarCancion_Click);
            // 
            // btnEliminarCancion
            // 
            this.btnEliminarCancion.Location = new System.Drawing.Point(188, 51);
            this.btnEliminarCancion.Name = "btnEliminarCancion";
            this.btnEliminarCancion.Size = new System.Drawing.Size(134, 59);
            this.btnEliminarCancion.TabIndex = 1;
            this.btnEliminarCancion.Text = "Eliminar Canciones";
            this.btnEliminarCancion.UseVisualStyleBackColor = true;
            this.btnEliminarCancion.Click += new System.EventHandler(this.btnEliminarCancion_Click);
            // 
            // btnReporteCanciones
            // 
            this.btnReporteCanciones.Location = new System.Drawing.Point(36, 135);
            this.btnReporteCanciones.Name = "btnReporteCanciones";
            this.btnReporteCanciones.Size = new System.Drawing.Size(134, 59);
            this.btnReporteCanciones.TabIndex = 2;
            this.btnReporteCanciones.Text = "Ver Canciones";
            this.btnReporteCanciones.UseVisualStyleBackColor = true;
            this.btnReporteCanciones.Click += new System.EventHandler(this.btnReporteCanciones_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(188, 135);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(134, 59);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Examen_Calix.Properties.Resources.descarga;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(474, 326);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnReporteCanciones;
        private System.Windows.Forms.Button btnEliminarCancion;
        private System.Windows.Forms.Button btnAgregarCancion;
    }
}

