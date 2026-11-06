using Proyecto_Final;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Proyecto_Final.FrmRegistroProducto;

namespace Frm_EditarProductos
{
    public partial class FrmEditarProducto : Form
    {
        private List<Product> listaProductos = new List<Product>();

        public FrmEditarProducto()
        {
            InitializeComponent();
        }

        //Método para mostrar y ocultar los cuadros de texto
        public void Cuadros(bool vista)
        {
            label4.Visible = vista;
            txtNombre.Visible = vista;

            label6.Visible = vista;
            cmbClasificacion.Visible = vista;

            label8.Visible = vista;
            cmbEstadoFisico.Visible = vista;

            label5.Visible = vista;
            txtPrecioCompra.Visible = vista;

            label7.Visible = vista;
            txtPrecioVenta.Visible = vista;

            label9.Visible = vista;
            txtStock.Visible = vista;

            label10.Visible = vista;
            dtpFechaRegistro.Visible = vista;

            label11.Visible = vista;
            dtpFechaCaducidad.Visible = vista;
            btnGuardar.Visible = vista;
            btnCancelar.Visible = vista;
        }

        private void FrmEditarProducto_Load(object sender, EventArgs e)
        {
            // Lee la lista de productos desde el ~archivo de texto
            listaProductos = GestionArchivo.LeerProductosTexto();

            cmbClasificacion.Items.Clear();
            // Agrega las clasificaciones al ComboBox
            foreach (string cat in GestionArchivo.LeerClasificacionesTexto())
            {
                cmbClasificacion.Items.Add(cat);
            }

            // Agrega las opciones al ComboBox de estado físico
            cmbEstadoFisico.Items.Add("Óptimo");
            cmbEstadoFisico.Items.Add("Regular");
            cmbEstadoFisico.Items.Add("Dañado");

            // Ocultar todos los campos
            Cuadros(false);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Valida que el campo del código no esté vacío o contenga espacios en blanco
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Ingrese el código del producto.");
                return;
            }

            // Busca el producto en la lista cuyo código coincida (ignorando espacios y en mayúsculas)
            Product producto = listaProductos.FirstOrDefault(
                p => p.Codigo == txtCodigo.Text.Trim().ToUpper());

            // Si el producto fue encontrado
            if (producto != null)
            {
                MessageBox.Show("Producto encontrado.");

                // Rellena los controles del formulario con los datos del producto para su edición
                txtNombre.Text = producto.Nombre;
                cmbClasificacion.SelectedItem = producto.Clasificacion;
                cmbEstadoFisico.SelectedItem = producto.EstadoFisico;
                txtPrecioCompra.Text = producto.PrecioCompra.ToString();
                txtPrecioVenta.Text = producto.PrecioVenta.ToString();
                txtStock.Text = producto.Stock.ToString();
                dtpFechaRegistro.Value = producto.FechaRegistro;
                dtpFechaCaducidad.Value = producto.FechaCaducidad;

                // Muestra los cuadros de texto y etiquetas en el formulario
                Cuadros(true);
            }
            else
            {
                // Informa al usuario que el producto no existe en la lista
                MessageBox.Show("No se encontró el producto.");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Variables locales para almacenar los datos validados del producto
            int stock;
            decimal precioCompra;
            decimal precioVenta;

            // Valida que el campo Nombre no esté vacío
            if (!Validacion.ValidarTextoVacio(txtNombre.Text, "Nombre")) return;

            // Valida que se haya seleccionado una Clasificación
            if (!Validacion.ValidarSeleccionCombo(cmbClasificacion.SelectedIndex, "Clasificación")) return;

            // Valida que se haya seleccionado un Estado físico
            if (!Validacion.ValidarSeleccionCombo(cmbEstadoFisico.SelectedIndex, "Estado físico")) return;

            // Valida y obtiene el precio de compra numérico
            if (!Validacion.ValidarPrecio(txtPrecioCompra.Text,
                "Precio de compra", out precioCompra)) return;

            // Valida y obtiene el precio de venta numérico
            if (!Validacion.ValidarPrecio(txtPrecioVenta.Text,
                "Precio de venta", out precioVenta)) return;

            // Valida y obtiene la cantidad de stock
            if (!Validacion.ValidarStock(txtStock.Text,
                out stock)) return;

            // Busca el producto correspondiente en la lista mediante su código
            Product producto = listaProductos.FirstOrDefault(
                p => p.Codigo == txtCodigo.Text.Trim().ToUpper());

            // Si el producto existe, procede con la actualización de datos
            if (producto != null)
            {
                producto.Nombre = txtNombre.Text.Trim();
                producto.Clasificacion = cmbClasificacion.SelectedItem.ToString();
                producto.EstadoFisico = cmbEstadoFisico.SelectedItem.ToString();
                producto.PrecioCompra = precioCompra;
                producto.PrecioVenta = precioVenta;
                producto.Stock = stock;
                producto.FechaRegistro = dtpFechaRegistro.Value;
                producto.FechaCaducidad = dtpFechaCaducidad.Value;

                // Sobrescribe el archivo de texto con los cambios realizados a la lista
                GestionArchivo.SobreescribirProductos(listaProductos);

                MessageBox.Show("Producto actualizado correctamente.");

                // Actualiza la lista de productos en memoria desde el archivo de texto
                listaProductos = GestionArchivo.LeerProductosTexto();
            }
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();

            // Oculta todo nuevamente
            Cuadros(false);

            txtCodigo.Focus();
        }
        
        // Método que permite limpiar todos los campos del formulario
        private void LimpiarDatos()
        {
            txtCodigo.Clear();
            txtNombre.Clear();

            // Deselecciona cualquier elemento seleccionado en los ComboBoxes
            cmbClasificacion.SelectedIndex = -1;
            cmbEstadoFisico.SelectedIndex = -1;

            // Limpia el contenido de los cuadros de texto numéricos
            txtPrecioCompra.Clear();
            txtPrecioVenta.Clear();
            txtStock.Clear();

            // Restablece los controles de fecha al día y hora actuales
            dtpFechaRegistro.Value = DateTime.Now;
            dtpFechaCaducidad.Value = DateTime.Now;

            // Permite volver a escribir en el campo de texto del código del producto
            txtCodigo.ReadOnly = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Muestra un cuadro de diálogo de confirmación al usuario
            DialogResult respuesta = MessageBox.Show(
                "¿Desea regresar al menú principal?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // Si el usuario confirma
            if (respuesta == DialogResult.Yes)
            {
                // Cierra el formulario
                this.Close();
            }
        }
    }
}
