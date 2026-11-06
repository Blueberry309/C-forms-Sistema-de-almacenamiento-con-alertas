using ELIMINAR_PRODUCTO;
using VISUALIZAR_BIBLIOTECA;
using ALERTAS;
using Proyecto_Final;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Instancia el formulario de edición de productos
            Frm_EditarProductos.FrmEditarProducto editar =
                new Frm_EditarProductos.FrmEditarProducto();

            // Muestra el formulario de manera modal
            editar.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Muestra una ventana emergente de confirmación preguntando al usuario si desea salir
            DialogResult rs = MessageBox.Show("¿Está seguro que desea salir del programa?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Si el usuario confirma su salida presionando "Sí"
            if (rs == DialogResult.Yes)
            {
                // Cierra el formulario principal finalizando el programa
                this.Close();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Instancia el formulario de registro de productos
            Proyecto_Final.FrmRegistroProducto registro = new Proyecto_Final.FrmRegistroProducto();

            // Muestra el formulario de registro de manera modal
            registro.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Instancia el formulario para eliminar productos
            FrmEliminarProducto eliminar = new FrmEliminarProducto();
            
            // Muestra el formulario de eliminación
            eliminar.ShowDialog();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            // Instancia el formulario para visualizar los productos
            VISUALIZAR_BIBLIOTECA.Visualizar visualizar = new VISUALIZAR_BIBLIOTECA.Visualizar();
            
            // Muestra el formulario de visualización
            visualizar.ShowDialog();
        }

        // Método que se ejecuta al cargar el formulario principal
        private void Form1_Load(object sender, EventArgs e)
        {
            // Obtiene el nombre del usuario de la sesión actual de Windows
            string usuarioSistema = Environment.UserName;
            
            // Muestra el nombre del usuario en mayúsculas en la etiqueta
            lblNombreUsuario.Text = "Nombre Usuario: " + usuarioSistema.ToUpper();

            // Obtiene la fecha y hora actuales del sistema
            DateTime horaActual = DateTime.Now;
            
            // Muestra la fecha y hora de ingreso formateadas
            lblFechaIngreso.Text = "Fecha / Hora Ingreso: " + horaActual.ToString("dd/MM/yyyy HH:mm");
        }

        private void btnAlertas_Click(object sender, EventArgs e)
        {
            // Instancia el formulario de reportes de mermas y alertas
            FrmAlertas alertas = new FrmAlertas();
            
            // Muestra el formulario de alertas
            alertas.ShowDialog();
        }
    }
}
