namespace ALERTAS
{
    partial class FrmAlertas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlertas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDescuentos = new System.Windows.Forms.DataGridView();
            this.dgvCaducidad = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbProductosMerma = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalcularMerma = new System.Windows.Forms.Button();
            this.txtStockSistema = new System.Windows.Forms.TextBox();
            this.txtStockReal = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rtbReporteMerma = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescuentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaducidad)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 80);
            this.panel1.TabIndex = 1;
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
            this.btnSalir.Location = new System.Drawing.Point(701, 8);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(87, 64);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(252, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "MI TIENDA DARSOL";
            // 
            // dgvDescuentos
            // 
            this.dgvDescuentos.AllowUserToAddRows = false;
            this.dgvDescuentos.AllowUserToResizeColumns = false;
            this.dgvDescuentos.AllowUserToResizeRows = false;
            this.dgvDescuentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDescuentos.Location = new System.Drawing.Point(403, 140);
            this.dgvDescuentos.Name = "dgvDescuentos";
            this.dgvDescuentos.ReadOnly = true;
            this.dgvDescuentos.RowHeadersVisible = false;
            this.dgvDescuentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDescuentos.Size = new System.Drawing.Size(368, 102);
            this.dgvDescuentos.TabIndex = 2;
            // 
            // dgvCaducidad
            // 
            this.dgvCaducidad.AllowUserToAddRows = false;
            this.dgvCaducidad.AllowUserToResizeColumns = false;
            this.dgvCaducidad.AllowUserToResizeRows = false;
            this.dgvCaducidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaducidad.Location = new System.Drawing.Point(403, 302);
            this.dgvCaducidad.Name = "dgvCaducidad";
            this.dgvCaducidad.ReadOnly = true;
            this.dgvCaducidad.RowHeadersVisible = false;
            this.dgvCaducidad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCaducidad.Size = new System.Drawing.Size(368, 102);
            this.dgvCaducidad.TabIndex = 3;
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.Location = new System.Drawing.Point(400, 119);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(91, 13);
            this.lblDescuento.TabIndex = 4;
            this.lblDescuento.Text = "DESCUENTOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(400, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "CADUCIDAD";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "REPORTE DE DIFERENCIA DE STOCK";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Seleccionar Producto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Stock Registrado en Sistema";
            // 
            // cmbProductosMerma
            // 
            this.cmbProductosMerma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductosMerma.FormattingEnabled = true;
            this.cmbProductosMerma.Location = new System.Drawing.Point(199, 140);
            this.cmbProductosMerma.Name = "cmbProductosMerma";
            this.cmbProductosMerma.Size = new System.Drawing.Size(171, 21);
            this.cmbProductosMerma.TabIndex = 10;
            this.cmbProductosMerma.SelectedIndexChanged += new System.EventHandler(this.cmbProductosMerma_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Stock Real Fisico (contado):";
            // 
            // btnCalcularMerma
            // 
            this.btnCalcularMerma.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCalcularMerma.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularMerma.Location = new System.Drawing.Point(89, 256);
            this.btnCalcularMerma.Name = "btnCalcularMerma";
            this.btnCalcularMerma.Size = new System.Drawing.Size(183, 43);
            this.btnCalcularMerma.TabIndex = 14;
            this.btnCalcularMerma.Text = "Calcular Perdida con merma";
            this.btnCalcularMerma.UseVisualStyleBackColor = false;
            this.btnCalcularMerma.Click += new System.EventHandler(this.btnCalcularMerma_Click);
            // 
            // txtStockSistema
            // 
            this.txtStockSistema.Enabled = false;
            this.txtStockSistema.Location = new System.Drawing.Point(199, 176);
            this.txtStockSistema.Name = "txtStockSistema";
            this.txtStockSistema.ReadOnly = true;
            this.txtStockSistema.Size = new System.Drawing.Size(170, 20);
            this.txtStockSistema.TabIndex = 15;
            // 
            // txtStockReal
            // 
            this.txtStockReal.Location = new System.Drawing.Point(199, 216);
            this.txtStockReal.Name = "txtStockReal";
            this.txtStockReal.Size = new System.Drawing.Size(170, 20);
            this.txtStockReal.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.rtbReporteMerma);
            this.panel2.Location = new System.Drawing.Point(16, 321);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(353, 117);
            this.panel2.TabIndex = 17;
            // 
            // rtbReporteMerma
            // 
            this.rtbReporteMerma.Location = new System.Drawing.Point(12, 13);
            this.rtbReporteMerma.Name = "rtbReporteMerma";
            this.rtbReporteMerma.Size = new System.Drawing.Size(329, 91);
            this.rtbReporteMerma.TabIndex = 18;
            this.rtbReporteMerma.Text = "";
            this.rtbReporteMerma.TextChanged += new System.EventHandler(this.rtbReporteMerma_TextChanged);
            // 
            // FrmAlertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtStockReal);
            this.Controls.Add(this.txtStockSistema);
            this.Controls.Add(this.btnCalcularMerma);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbProductosMerma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.dgvCaducidad);
            this.Controls.Add(this.dgvDescuentos);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAlertas";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmAlertas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescuentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaducidad)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDescuentos;
        private System.Windows.Forms.DataGridView dgvCaducidad;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbProductosMerma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalcularMerma;
        private System.Windows.Forms.TextBox txtStockSistema;
        private System.Windows.Forms.TextBox txtStockReal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox rtbReporteMerma;
    }
}

