namespace Proyecto_Final
{
    partial class FrmGestionClasificaciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstClasificaciones = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Nueva_Clasificacion = new System.Windows.Forms.TextBox();
            this.Button_Añadir_C = new System.Windows.Forms.Button();
            this.Button_Quitar = new System.Windows.Forms.Button();
            this.Button_Aceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categorias actuales:";
            // 
            // lstClasificaciones
            // 
            this.lstClasificaciones.FormattingEnabled = true;
            this.lstClasificaciones.ItemHeight = 20;
            this.lstClasificaciones.Location = new System.Drawing.Point(34, 65);
            this.lstClasificaciones.Name = "lstClasificaciones";
            this.lstClasificaciones.Size = new System.Drawing.Size(202, 264);
            this.lstClasificaciones.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(428, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nueva Categoria:\r\n";
            // 
            // Nueva_Clasificacion
            // 
            this.Nueva_Clasificacion.Location = new System.Drawing.Point(397, 91);
            this.Nueva_Clasificacion.MaxLength = 21;
            this.Nueva_Clasificacion.Name = "Nueva_Clasificacion";
            this.Nueva_Clasificacion.Size = new System.Drawing.Size(206, 26);
            this.Nueva_Clasificacion.TabIndex = 3;
            // 
            // Button_Añadir_C
            // 
            this.Button_Añadir_C.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Añadir_C.Location = new System.Drawing.Point(420, 135);
            this.Button_Añadir_C.Name = "Button_Añadir_C";
            this.Button_Añadir_C.Size = new System.Drawing.Size(157, 49);
            this.Button_Añadir_C.TabIndex = 4;
            this.Button_Añadir_C.Text = "Añadir";
            this.Button_Añadir_C.UseVisualStyleBackColor = true;
            this.Button_Añadir_C.Click += new System.EventHandler(this.Button_Añadir_C_Click);
            // 
            // Button_Quitar
            // 
            this.Button_Quitar.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Quitar.Location = new System.Drawing.Point(386, 210);
            this.Button_Quitar.Name = "Button_Quitar";
            this.Button_Quitar.Size = new System.Drawing.Size(226, 49);
            this.Button_Quitar.TabIndex = 5;
            this.Button_Quitar.Text = "Quitar seleccionado";
            this.Button_Quitar.UseVisualStyleBackColor = true;
            this.Button_Quitar.Click += new System.EventHandler(this.Button_Quitar_Click);
            // 
            // Button_Aceptar
            // 
            this.Button_Aceptar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Button_Aceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Aceptar.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Aceptar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button_Aceptar.Location = new System.Drawing.Point(420, 291);
            this.Button_Aceptar.Name = "Button_Aceptar";
            this.Button_Aceptar.Size = new System.Drawing.Size(157, 49);
            this.Button_Aceptar.TabIndex = 6;
            this.Button_Aceptar.Text = "Aceptar";
            this.Button_Aceptar.UseVisualStyleBackColor = false;
            this.Button_Aceptar.Click += new System.EventHandler(this.Button_Aceptar_Click);
            // 
            // FrmGestionClasificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 378);
            this.Controls.Add(this.Button_Aceptar);
            this.Controls.Add(this.Button_Quitar);
            this.Controls.Add(this.Button_Añadir_C);
            this.Controls.Add(this.Nueva_Clasificacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstClasificaciones);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmGestionClasificaciones";
            this.Text = "FrmGestionClasificaciones";
            this.Load += new System.EventHandler(this.FrmGestionClasificaciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstClasificaciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Nueva_Clasificacion;
        private System.Windows.Forms.Button Button_Añadir_C;
        private System.Windows.Forms.Button Button_Quitar;
        private System.Windows.Forms.Button Button_Aceptar;
    }
}