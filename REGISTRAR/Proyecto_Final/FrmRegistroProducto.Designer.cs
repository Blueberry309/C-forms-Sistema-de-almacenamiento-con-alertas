namespace Proyecto_Final
{
    partial class FrmRegistroProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistroProducto));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_Clasificacion = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrecio_Compra = new System.Windows.Forms.TextBox();
            this.txtPrecio_Venta = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre_P = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Fecha_Caducidad = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.Fecha_Registro = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_EstadoF = new System.Windows.Forms.ComboBox();
            this.Button_Editar = new System.Windows.Forms.Button();
            this.Boton_Guardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO DE PRODUCTOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo del producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 200);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre del producto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(481, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio de compra:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(481, 200);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio de venta:";
            // 
            // cmb_Clasificacion
            // 
            this.cmb_Clasificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Clasificacion.FormattingEnabled = true;
            this.cmb_Clasificacion.Location = new System.Drawing.Point(82, 307);
            this.cmb_Clasificacion.Name = "cmb_Clasificacion";
            this.cmb_Clasificacion.Size = new System.Drawing.Size(177, 28);
            this.cmb_Clasificacion.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 275);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Categoria:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(481, 275);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Stock inicial:";
            // 
            // txtPrecio_Compra
            // 
            this.txtPrecio_Compra.Location = new System.Drawing.Point(485, 162);
            this.txtPrecio_Compra.MaxLength = 1000;
            this.txtPrecio_Compra.Name = "txtPrecio_Compra";
            this.txtPrecio_Compra.Size = new System.Drawing.Size(251, 26);
            this.txtPrecio_Compra.TabIndex = 8;
            // 
            // txtPrecio_Venta
            // 
            this.txtPrecio_Venta.Location = new System.Drawing.Point(485, 236);
            this.txtPrecio_Venta.MaxLength = 1000;
            this.txtPrecio_Venta.Name = "txtPrecio_Venta";
            this.txtPrecio_Venta.Size = new System.Drawing.Size(251, 26);
            this.txtPrecio_Venta.TabIndex = 9;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(485, 309);
            this.txtStock.MaxLength = 1000;
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(152, 26);
            this.txtStock.TabIndex = 10;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(87, 162);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(252, 26);
            this.txtCodigo.TabIndex = 11;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // txtNombre_P
            // 
            this.txtNombre_P.Location = new System.Drawing.Point(82, 236);
            this.txtNombre_P.Name = "txtNombre_P";
            this.txtNombre_P.Size = new System.Drawing.Size(252, 26);
            this.txtNombre_P.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(83, 347);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Estado Físico:";
            // 
            // Fecha_Caducidad
            // 
            this.Fecha_Caducidad.Location = new System.Drawing.Point(485, 447);
            this.Fecha_Caducidad.Name = "Fecha_Caducidad";
            this.Fecha_Caducidad.Size = new System.Drawing.Size(251, 26);
            this.Fecha_Caducidad.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(481, 340);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Fecha de registro:";
            // 
            // Fecha_Registro
            // 
            this.Fecha_Registro.Location = new System.Drawing.Point(485, 376);
            this.Fecha_Registro.Name = "Fecha_Registro";
            this.Fecha_Registro.Size = new System.Drawing.Size(251, 26);
            this.Fecha_Registro.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(481, 415);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Fecha de caducidad:";
            // 
            // cmb_EstadoF
            // 
            this.cmb_EstadoF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_EstadoF.FormattingEnabled = true;
            this.cmb_EstadoF.Location = new System.Drawing.Point(82, 374);
            this.cmb_EstadoF.Name = "cmb_EstadoF";
            this.cmb_EstadoF.Size = new System.Drawing.Size(177, 28);
            this.cmb_EstadoF.TabIndex = 14;
            // 
            // Button_Editar
            // 
            this.Button_Editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Editar.Location = new System.Drawing.Point(303, 301);
            this.Button_Editar.Name = "Button_Editar";
            this.Button_Editar.Size = new System.Drawing.Size(88, 34);
            this.Button_Editar.TabIndex = 19;
            this.Button_Editar.Text = "Agregar";
            this.Button_Editar.UseVisualStyleBackColor = true;
            this.Button_Editar.Click += new System.EventHandler(this.Button_Editar_Click);
            // 
            // Boton_Guardar
            // 
            this.Boton_Guardar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Boton_Guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_Guardar.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Guardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Boton_Guardar.Location = new System.Drawing.Point(82, 429);
            this.Boton_Guardar.Name = "Boton_Guardar";
            this.Boton_Guardar.Size = new System.Drawing.Size(170, 63);
            this.Boton_Guardar.TabIndex = 21;
            this.Boton_Guardar.Text = "Guardar";
            this.Boton_Guardar.UseVisualStyleBackColor = false;
            this.Boton_Guardar.Click += new System.EventHandler(this.Boton_Guardar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 80);
            this.panel1.TabIndex = 22;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(713, 8);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(87, 64);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(252, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(281, 37);
            this.label11.TabIndex = 2;
            this.label11.Text = "MI TIENDA DARSOL";
            // 
            // FrmRegistroProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 517);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Boton_Guardar);
            this.Controls.Add(this.Button_Editar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Fecha_Registro);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Fecha_Caducidad);
            this.Controls.Add(this.cmb_EstadoF);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNombre_P);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtPrecio_Venta);
            this.Controls.Add(this.txtPrecio_Compra);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_Clasificacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmRegistroProducto";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmRegistroProducto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_Clasificacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrecio_Compra;
        private System.Windows.Forms.TextBox txtPrecio_Venta;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre_P;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker Fecha_Caducidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker Fecha_Registro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_EstadoF;
        private System.Windows.Forms.Button Button_Editar;
        private System.Windows.Forms.Button Boton_Guardar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label11;
    }
}

