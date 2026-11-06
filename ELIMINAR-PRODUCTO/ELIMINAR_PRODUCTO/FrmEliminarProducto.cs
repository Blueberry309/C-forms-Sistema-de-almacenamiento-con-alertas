using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Final;

namespace ELIMINAR_PRODUCTO
{
    public partial class FrmEliminarProducto : Form
    {
        public FrmEliminarProducto()
        {
            InitializeComponent();
        }

        // Método para mostrar y ocultar los controles del formulario
        public void Cuadros(bool estado)
        {
            lblNombre.Visible = estado;
            txtNombre.Visible = estado;

            lblStock.Visible = estado;
            txtStock.Visible = estado;

            lblPregunta.Visible = estado;

            btnCancelar.Visible = estado;
            btnEliminar.Visible = estado;
        }

        // Método para limpiar todos los campos del formulario
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtStock.Clear();
            txtCodigo.Focus();
        }

        // Método para buscar un producto por código
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Valida que el campo del código no esté vacío o contenga espacios en blanco
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Ingrese el código del producto.");
                return;
            }

            // Lee la lista de productos desde el archivo de texto
            List<FrmRegistroProducto.Product> listaParaEliminar = GestionArchivo.LeerProductosTexto();

            // Busca el producto por código
            var producto = listaParaEliminar.FirstOrDefault(
                p => p.Codigo == txtCodigo.Text.Trim().ToUpper());

            // Si el producto fue encontrado
            if (producto != null)
            {
                // Muestra el nombre y stock del producto
                txtNombre.Text = producto.Nombre;
                txtStock.Text = producto.Stock.ToString();

                // Muestra los controles del formulario
                Cuadros(true);

                MessageBox.Show("Producto encontrado.");
            }
            // Si el producto no fue encontrado
            else
            {
                // Muestra un mensaje de error
                MessageBox.Show("Producto no encontrado.");

                // Limpia los campos del formulario
                txtNombre.Clear();
                txtStock.Clear();

                Cuadros(false);
            }
        }

        // Método para eliminar un producto
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Valida que el campo del código no esté vacío (es necesario haber buscado un producto antes)
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Primero busque un producto.");
                return;
            }

            // Solicita confirmación al usuario antes de proceder con la eliminación
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro que desea eliminar este producto?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // Si el usuario hace clic en el botón "Sí"
            if (respuesta == DialogResult.Yes)
            {
                // Carga la lista completa de productos desde el archivo de texto
                List<FrmRegistroProducto.Product> listaProductos =
                    GestionArchivo.LeerProductosTexto();

                // Remueve de la lista el producto cuyo código coincida e identifica si se realizó la eliminación
                int eliminados = listaProductos.RemoveAll(
                    p => p.Codigo == txtCodigo.Text.Trim().ToUpper());

                // Si efectivamente se eliminó el producto de la lista
                if (eliminados > 0)
                {
                    // Guarda la lista actualizada sobrescribiendo el archivo de texto
                    GestionArchivo.SobreescribirProductos(listaProductos);

                    MessageBox.Show("Producto eliminado correctamente.");

                    // Limpia los campos de texto del formulario
                    txtCodigo.Clear();
                    txtNombre.Clear();
                    txtStock.Clear();

                    // Coloca el cursor en el cuadro de texto del código para una nueva búsqueda
                    txtCodigo.Focus();
                }
                else
                {
                    // Muestra un mensaje en caso de que el producto no haya sido encontrado o ya no exista
                    MessageBox.Show("El producto ya no existe o no fue encontrado.");
                }
            }
        }

        // Método que se ejecuta al iniciar/cargar el formulario
        private void Form1_Load(object sender, EventArgs e)
        {
            // Oculta inicialmente los campos del producto hasta que se realice una búsqueda
            Cuadros(false);

            // Configura los campos del nombre y stock para que no puedan ser modificados manualmente
            txtNombre.ReadOnly = true;
            txtStock.ReadOnly = true;
        }

        // Método para el botón de salida, que permite regresar al menú principal
        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Muestra un cuadro de diálogo de confirmación
            DialogResult respuesta = MessageBox.Show(
                "¿Desea regresar al menú principal?", // Mensaje para el usuario
                "Confirmación",                     // Título de la ventana emergente
                MessageBoxButtons.YesNo,             // Botones Sí y No
                MessageBoxIcon.Question);            // Icono de pregunta de la ventana

            // Evalúa si el usuario seleccionó "Sí"
            if (respuesta == DialogResult.Yes)
            {
                // Cierra el formulario actual
                this.Close();
            }
        }
    }
}
