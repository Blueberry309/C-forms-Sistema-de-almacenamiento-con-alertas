using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class FrmRegistroProducto : Form
    {
        // Lista estática que mantiene la colección de productos en memoria
        public static List<Product> listaProductos = new List<Product>();

        // Constructor del formulario de registro
        public FrmRegistroProducto()
        {
            InitializeComponent();
            // Carga los valores iniciales para las opciones de la interfaz
            RellenarOpciones();
        }

        // Clase que modela las propiedades y datos de un Producto
        public class Product
        {
            public string Codigo { get; set; }
            public string Nombre { get; set; }
            public string Clasificacion { get; set; }
            public string EstadoFisico { get; set; }
            public decimal PrecioCompra { get; set; }
            public decimal PrecioVenta { get; set; }
            public decimal Stock { get; set; } // Nota: se mapeará dinámicamente como entero en la lectura/escritura
            public DateTime FechaRegistro { get; set; }
            public DateTime FechaCaducidad { get; set; }
        }

        // Llena el ComboBox del estado físico con las opciones preestablecidas
        private void RellenarOpciones()
        {
            cmb_EstadoF.Items.Add("Óptimo");
            cmb_EstadoF.Items.Add("Regular");
            cmb_EstadoF.Items.Add("Dañado");
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmRegistroProducto_Load(object sender, EventArgs e)
        {
            // Carga los productos
            listaProductos = GestionArchivo.LeerProductosTexto();

            // Carga las clasificaciones guardadas en el ComboBox
            cmb_Clasificacion.Items.Clear();
            List<string> clasificacionesGuardadas = GestionArchivo.LeerClasificacionesTexto();
            foreach (var cat in clasificacionesGuardadas)
            {
                cmb_Clasificacion.Items.Add(cat);
            }
        }


        private void Boton_Guardar_Click(object sender, EventArgs e)
        {
            // Variables locales para almacenar temporalmente los valores convertidos y validados
            int stock;
            decimal precioCompra;
            decimal precioVenta;

            // Valida que los campos de texto obligatorios (Código y Nombre) no estén vacíos
            if (!Validacion.ValidarTextoVacio(txtCodigo.Text, "Código")) return;
            if (!Validacion.ValidarTextoVacio(txtNombre_P.Text, "Nombre del Producto")) return;

            // Valida que se haya seleccionado un elemento en los ComboBoxes correspondientes
            if (!Validacion.ValidarSeleccionCombo(cmb_Clasificacion.SelectedIndex, "Clasificación")) return;
            if (!Validacion.ValidarSeleccionCombo(cmb_EstadoF.SelectedIndex, "Estado Físico")) return;

            // Valida el formato y rango de los precios y el stock
            if (!Validacion.ValidarPrecio(txtPrecio_Compra.Text, "Precio de Compra", out precioCompra)) return;
            if (!Validacion.ValidarPrecio(txtPrecio_Venta.Text, "Precio de Venta", out precioVenta)) return;
            if (!Validacion.ValidarStock(txtStock.Text, out stock)) return;

            // Recorre la lista de productos para verificar si el código ya existe
            foreach (var p in listaProductos)
            {
                // Si el código del producto actual coincide con el ingresado en el formulario
                if (p.Codigo == txtCodigo.Text.Trim().ToUpper())
                {
                    // Muestra una alerta informando el conflicto del código duplicado
                    MessageBox.Show("El código '" + txtCodigo.Text.Trim().ToUpper() + "' ya existe para otro producto. Ingrese uno diferente.");
                    
                    // Sitúa el cursor en el cuadro de texto del código para facilitar la edición
                    txtCodigo.Focus();
                    return; // Detiene la ejecución del registro
                }
            }

            // Crea una nueva instancia de la clase Product y le asigna los valores validados del formulario
            Product nuevo = new Product();
            nuevo.Codigo = txtCodigo.Text.Trim().ToUpper();
            nuevo.Nombre = txtNombre_P.Text.Trim();
            nuevo.Stock = stock;
            nuevo.PrecioCompra = precioCompra;
            nuevo.PrecioVenta = precioVenta;
            nuevo.Clasificacion = cmb_Clasificacion.SelectedItem.ToString();
            nuevo.EstadoFisico = cmb_EstadoF.SelectedItem.ToString();
            nuevo.FechaRegistro = Fecha_Registro.Value;
            nuevo.FechaCaducidad = Fecha_Caducidad.Value;

            // Mantener la lista en memoria RAM sincronizada
            listaProductos.Add(nuevo);

            // Guarda físicamente en el archivo de texto de manera permanente
            GestionArchivo.GuardarProductoTexto(nuevo);

            MessageBox.Show("¡Producto guardado con éxito en el servidor de texto!");
            LimpiarDatos();
        }

        // Limpia todos los campos del formulario para permitir el ingreso de un nuevo producto
        private void LimpiarDatos()
        {
            txtCodigo.Clear();
            txtNombre_P.Clear();
            cmb_Clasificacion.SelectedIndex = -1;
            cmb_EstadoF.SelectedIndex = -1;
            txtPrecio_Compra.Clear();
            txtPrecio_Venta.Clear();
            txtStock.Clear();
            Fecha_Registro.Value = DateTime.Now;
            Fecha_Caducidad.Value = DateTime.Now;
        }

        // Abre el formulario para editar las clasificaciones
        private void Button_Editar_Click(object sender, EventArgs e)
        {
            FrmGestionClasificaciones ventana = new FrmGestionClasificaciones(cmb_Clasificacion);
            ventana.ShowDialog();
        }

        public void Boton_Cancelar_Click(object sender, EventArgs e)
        {

        }

        // Confirma la cancelación del registro y cierra el formulario actual
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("¿Está seguro que desea cancelar el registro? Volverá al menú principal.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                this.Close();

            }
        }
    }
}
