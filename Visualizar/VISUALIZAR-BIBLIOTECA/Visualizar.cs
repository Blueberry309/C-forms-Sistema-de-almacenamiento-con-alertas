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

namespace VISUALIZAR_BIBLIOTECA
{
    public partial class Visualizar : Form
    {
        private List<FrmRegistroProducto.Product> inventarioCompleto = new List<FrmRegistroProducto.Product>();
        public Visualizar()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Jalamos todos los productos del cuaderno .txt mediante el Almacenero
            inventarioCompleto = GestionArchivo.LeerProductosTexto();

            // Jalamos las clasificaciones
            cmbFiltroClasificacion.Items.Clear();
            List<string> categorias = GestionArchivo.LeerClasificacionesTexto();
            foreach (var cat in categorias)
            {
                cmbFiltroClasificacion.Items.Add(cat);
            }

            ActualizarTabla(inventarioCompleto);
        }

        // Método encargado de refrescar el contenido mostrado en el DataGridView
        private void ActualizarTabla(List<FrmRegistroProducto.Product> listaAMostrar)
        {
            // Desvincula el origen de datos previo del DataGridView
            dataGridView1.DataSource = null;

            // Verifica que la lista recibida no sea nula y contenga elementos
            if (listaAMostrar != null && listaAMostrar.Count > 0)
            {
                // Asigna la nueva lista de productos para ser mostrada en la tabla
                dataGridView1.DataSource = listaAMostrar;
            }
        }

        // Filtra los productos en tiempo real a medida que el usuario escribe en el cuadro de búsqueda
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Obtiene el texto a buscar limpiando espacios y pasándolo a mayúsculas
            string textoBusqueda = textBox1.Text.Trim().ToUpper();

            // Si el buscador está vacío, vuelve a mostrar todos los productos
            if (string.IsNullOrEmpty(textoBusqueda))
            {
                ActualizarTabla(inventarioCompleto);
                return;
            }

            // Inicializa una lista para colocar los productos que coincidan con la búsqueda
            List<FrmRegistroProducto.Product> listaFiltrada = new List<FrmRegistroProducto.Product>();
            
            // Recorre todos los productos del inventario
            foreach (var p in inventarioCompleto)
            {
                // Si el código del producto contiene el texto ingresado por el usuario
                if (p.Codigo.ToUpper().Contains(textoBusqueda))
                {
                    // Agrega el producto a la lista temporal filtrada
                    listaFiltrada.Add(p);
                }
            }
            
            // Actualiza la tabla para mostrar únicamente los resultados que coinciden
            ActualizarTabla(listaFiltrada);
        }

        // Filtra los productos que coinciden con la clasificación seleccionada en el ComboBox
        private void cmbFiltroClasificacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Valida si no hay ninguna categoría seleccionada
            if (cmbFiltroClasificacion.SelectedIndex == -1) return;

            // Obtiene el texto de la categoría seleccionada
            string categoriaSeleccionada = cmbFiltroClasificacion.SelectedItem.ToString();
            
            // Inicializa una lista temporal para guardar los productos de dicha categoría
            List<FrmRegistroProducto.Product> listaFiltrada = new List<FrmRegistroProducto.Product>();

            // Recorre el inventario completo para realizar la búsqueda
            foreach (var p in inventarioCompleto)
            {
                // Compara la clasificación del producto con la seleccionada (sin espacios y en mayúsculas)
                if (p.Clasificacion.Trim().ToUpper() == categoriaSeleccionada.Trim().ToUpper())
                {
                    // Agrega el producto coincidente a la lista filtrada
                    listaFiltrada.Add(p);
                }
            }
            
            // Muestra los productos filtrados en la tabla
            ActualizarTabla(listaFiltrada);
        }

        // Limpia todos los filtros aplicados y muestra el inventario completo
        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            // Borra el texto de la barra de búsqueda
            textBox1.Clear();
            
            // Restablece la selección del ComboBox de clasificaciones
            cmbFiltroClasificacion.SelectedIndex = -1;
            
            // Muestra la lista completa de productos sin filtros
            ActualizarTabla(inventarioCompleto);
        }

        // Maneja el evento de clic en el botón Salir
        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Cierra el formulario actual
            this.Close();
        }
    }
}

