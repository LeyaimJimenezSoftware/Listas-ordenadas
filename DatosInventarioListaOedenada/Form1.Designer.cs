namespace DatosInventarioListaOedenada
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
            this.textBoxInsertar = new System.Windows.Forms.TextBox();
            this.buttonInsertar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxEliminar = new System.Windows.Forms.TextBox();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonInventario = new System.Windows.Forms.Button();
            this.textBoxDatos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelN = new System.Windows.Forms.Label();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.buttonAgragar = new System.Windows.Forms.Button();
            this.Codigo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxInsertar
            // 
            this.textBoxInsertar.Location = new System.Drawing.Point(678, 485);
            this.textBoxInsertar.Name = "textBoxInsertar";
            this.textBoxInsertar.Size = new System.Drawing.Size(100, 22);
            this.textBoxInsertar.TabIndex = 35;
            // 
            // buttonInsertar
            // 
            this.buttonInsertar.Location = new System.Drawing.Point(696, 513);
            this.buttonInsertar.Name = "buttonInsertar";
            this.buttonInsertar.Size = new System.Drawing.Size(82, 26);
            this.buttonInsertar.TabIndex = 34;
            this.buttonInsertar.Text = "Insertar";
            this.buttonInsertar.UseVisualStyleBackColor = true;
            this.buttonInsertar.Click += new System.EventHandler(this.buttonInsertar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(708, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "label1";
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(203, 329);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(100, 22);
            this.textBoxBuscar.TabIndex = 32;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(105, 325);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(82, 26);
            this.buttonBuscar.TabIndex = 31;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // textBoxEliminar
            // 
            this.textBoxEliminar.Location = new System.Drawing.Point(203, 295);
            this.textBoxEliminar.Name = "textBoxEliminar";
            this.textBoxEliminar.Size = new System.Drawing.Size(100, 22);
            this.textBoxEliminar.TabIndex = 30;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(105, 293);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(82, 26);
            this.buttonEliminar.TabIndex = 29;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonInventario
            // 
            this.buttonInventario.Location = new System.Drawing.Point(105, 357);
            this.buttonInventario.Name = "buttonInventario";
            this.buttonInventario.Size = new System.Drawing.Size(82, 26);
            this.buttonInventario.TabIndex = 27;
            this.buttonInventario.Text = "Inventario";
            this.buttonInventario.UseVisualStyleBackColor = true;
            this.buttonInventario.Click += new System.EventHandler(this.buttonInventario_Click);
            // 
            // textBoxDatos
            // 
            this.textBoxDatos.Location = new System.Drawing.Point(290, 71);
            this.textBoxDatos.Multiline = true;
            this.textBoxDatos.Name = "textBoxDatos";
            this.textBoxDatos.Size = new System.Drawing.Size(374, 198);
            this.textBoxDatos.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Precio";
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(86, 104);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(58, 17);
            this.labelN.TabIndex = 23;
            this.labelN.Text = "Nombre";
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(154, 155);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(100, 22);
            this.textBoxCantidad.TabIndex = 22;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(154, 127);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrecio.TabIndex = 21;
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(154, 66);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(100, 22);
            this.textBoxCodigo.TabIndex = 19;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(154, 99);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 22);
            this.textBoxNombre.TabIndex = 20;
            // 
            // buttonAgragar
            // 
            this.buttonAgragar.Location = new System.Drawing.Point(154, 198);
            this.buttonAgragar.Name = "buttonAgragar";
            this.buttonAgragar.Size = new System.Drawing.Size(82, 26);
            this.buttonAgragar.TabIndex = 28;
            this.buttonAgragar.Text = "Agragar";
            this.buttonAgragar.UseVisualStyleBackColor = true;
            this.buttonAgragar.Click += new System.EventHandler(this.buttonAgragar_Click);
            // 
            // Codigo
            // 
            this.Codigo.AutoSize = true;
            this.Codigo.Location = new System.Drawing.Point(86, 71);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(52, 17);
            this.Codigo.TabIndex = 18;
            this.Codigo.Text = "Codigo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 463);
            this.Controls.Add(this.textBoxInsertar);
            this.Controls.Add(this.buttonInsertar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxEliminar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonInventario);
            this.Controls.Add(this.textBoxDatos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.textBoxCantidad);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.buttonAgragar);
            this.Controls.Add(this.Codigo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInsertar;
        private System.Windows.Forms.Button buttonInsertar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxEliminar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonInventario;
        private System.Windows.Forms.TextBox textBoxDatos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Button buttonAgragar;
        private System.Windows.Forms.Label Codigo;
    }
}

