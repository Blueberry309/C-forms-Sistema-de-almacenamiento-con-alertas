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
using static Proyecto_Final.FrmRegistroProducto;

namespace ALERTAS
{
    public partial class FrmAlertas : Form
    {
        public FrmAlertas()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Muestra un cuadro de diálogo de confirmación con los botones Sí y No
            DialogResult respuesta = MessageBox.Show(
                "¿Desea regresar al menú principal?", // Mensaje que se muestra al usuario
                "Confirmación",                     // Título de la ventana emergente
                MessageBoxButtons.YesNo,             // Botones Sí y No
                MessageBoxIcon.Question);            // Icono de pregunta de la ventana

            // Evalúa si el usuario hizo clic en el botón "Sí"
            if (respuesta == DialogResult.Yes)
            {
                // Cierra el formulario actual para regresar al menú principal
                this.Close();
            }
        }

        private void FrmAlertas_Load(object sender, EventArgs e)
        {
            // ================== CONFIGURACIÓN DEL DGV DESCUENTOS ==================
            // Limpia las columnas previas del DataGridView de descuentos
            dgvDescuentos.Columns.Clear();

            // Agrega las columnas correspondientes para el reporte de descuentos
            dgvDescuentos.Columns.Add("colCodigoDesc", "Código");
            dgvDescuentos.Columns.Add("colProductoDesc", "Producto");
            dgvDescuentos.Columns.Add("colMotivoDesc", "Motivo");
            dgvDescuentos.Columns.Add("colDescuento", "Descuento");

            // Configura propiedades visuales y de interacción del DataGridView
            dgvDescuentos.ReadOnly = true;                 // Solo lectura
            dgvDescuentos.AllowUserToAddRows = false;      // Evita que el usuario agregue filas manualmente
            dgvDescuentos.RowHeadersVisible = false;       // Oculta la columna de cabecera de las filas

            // ================== CONFIGURACIÓN DEL DGV CADUCIDAD ==================
            // Limpia las columnas previas del DataGridView de caducidad
            dgvCaducidad.Columns.Clear();

            // Agrega las columnas para mostrar productos próximos a vencer o vencidos
            dgvCaducidad.Columns.Add("colCodigoCad", "Código");
            dgvCaducidad.Columns.Add("colProductoCad", "Producto");
            dgvCaducidad.Columns.Add("colFechaCad", "Fecha de Caducidad");
            dgvCaducidad.Columns.Add("colDias", "Estado");

            // Configura propiedades visuales y de interacción del DataGridView de caducidad
            dgvCaducidad.ReadOnly = true;
            dgvCaducidad.AllowUserToAddRows = false;
            dgvCaducidad.RowHeadersVisible = false;

            // Lee la lista de productos desde el archivo de texto de almacenamiento
            List<Product> productos = GestionArchivo.LeerProductosTexto();

            // Muestra un mensaje de verificación con la cantidad de productos leídos y la ruta de ejecución
            MessageBox.Show(
                "Productos encontrados: " + productos.Count +
                "\n\nRuta del archivo:\n" + Application.StartupPath,
                "Verificación"
            );

            // Limpia los elementos existentes en el ComboBox de productos para la merma
            cmbProductosMerma.Items.Clear();

            // Recorre cada producto cargado para clasificarlo en los DataGridViews correspondientes
            foreach (Product p in productos)
            {
                // Agrega el código del producto al ComboBox de mermas
                cmbProductosMerma.Items.Add(p.Codigo);
                
                // Si el producto se encuentra físicamente dañado, se agrega a la lista de descuentos
                if (p.EstadoFisico.Trim().ToUpper() == "DAÑADO")
                {
                    dgvDescuentos.Rows.Add(
                        p.Codigo,
                        p.Nombre,
                        "Producto dañado",
                        "10%" // Se asigna un descuento predeterminado del 10%
                    );
                }

                // Calcula la cantidad de días restantes hasta la fecha de caducidad
                int dias = (p.FechaCaducidad.Date - DateTime.Now.Date).Days;

                // Filtra productos vencidos o próximos a vencer en los siguientes 30 días
                if (dias <= 30)
                {
                    string estado;

                    // Determina el texto descriptivo del estado según los días de vencimiento
                    if (dias < 0)
                    {
                        estado = "VENCIDO";
                    }
                    else if (dias == 0)
                    {
                        estado = "VENCE HOY";
                    }
                    else
                    {
                        estado = "VENCE EN " + dias + " DÍAS";
                    }

                    // Agrega el producto al DataGridView de caducidad con su estado correspondiente
                    dgvCaducidad.Rows.Add(
                        p.Codigo,
                        p.Nombre,
                        p.FechaCaducidad.ToShortDateString(),
                        estado
                    );
                }

            }

            // Limpia los campos de texto y el reporte de merma en la interfaz
            txtStockSistema.Clear();
            txtStockReal.Clear();
            rtbReporteMerma.Clear();
        }

        private void cmbProductosMerma_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lee la lista actualizada de productos desde el archivo de texto
            List<Product> productos = GestionArchivo.LeerProductosTexto();

            // Busca en la lista el primer producto cuyo código coincida con el seleccionado en el ComboBox
            Product producto = productos.FirstOrDefault(
                p => p.Codigo == cmbProductosMerma.SelectedItem.ToString());

            // Si el producto fue encontrado
            if (producto != null)
            {
                // Asigna y muestra la cantidad de stock del producto en el campo de texto correspondiente
                txtStockSistema.Text = producto.Stock.ToString();
            }
        }

        private void btnCalcularMerma_Click(object sender, EventArgs e)
        {
            // Variables para almacenar las cantidades de stock del sistema y stock real convertido
            int stockSistema;
            int stockReal;

            // Valida si se ha seleccionado algún producto en el ComboBox
            if (cmbProductosMerma.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un producto.");
                return;
            }

            // Intenta convertir el stock registrado en el sistema a tipo entero y valida el formato
            if (!int.TryParse(txtStockSistema.Text, out stockSistema))
            {
                MessageBox.Show("Stock del sistema inválido.");
                return;
            }

            // Intenta convertir el stock físico ingresado por el usuario a tipo entero y valida el formato
            if (!int.TryParse(txtStockReal.Text, out stockReal))
            {
                MessageBox.Show("Ingrese un stock real válido.");
                return;
            }

            // Calcula la diferencia entre el stock del sistema y el stock real
            int diferencia = stockSistema - stockReal;

            // Limpia el contenido previo de reportes
            rtbReporteMerma.Clear();

            // Genera y escribe el encabezado de la información general del reporte
            rtbReporteMerma.AppendText("=== REPORTE DE MERMA ===\n");
            rtbReporteMerma.AppendText("Producto: " +
                cmbProductosMerma.SelectedItem.ToString() + "\n");

            rtbReporteMerma.AppendText("Stock Sistema: " +
                stockSistema + "\n");

            rtbReporteMerma.AppendText("Stock Real: " +
                stockReal + "\n\n");

            // Determina la conclusión del reporte según la diferencia obtenida
            if (diferencia < 0)
            {
                // Si la diferencia es menor a cero, indica que hay más stock físico del registrado en el sistema
                rtbReporteMerma.AppendText(
                    "Resultado: Excedente de " +
                    Math.Abs(diferencia) + " unidades.");
            }
            else if (diferencia == 0)
            {
                // Si la diferencia es cero, indica que el stock coincide perfectamente
                rtbReporteMerma.AppendText("Resultado: Sin merma.");
            }
            else
            {
                // Si es mayor a cero, existe una pérdida de productos
                rtbReporteMerma.AppendText(
                    "Merma detectada: " +
                    diferencia + " unidades.\n");

                // Valida si la merma sobrepasa un límite de tolerancia (10 unidades)
                if (diferencia > 10)
                {
                    rtbReporteMerma.AppendText(
                        "*** ALERTA CRÍTICA: Merma de gran margen ***");
                }
                else
                {
                    rtbReporteMerma.AppendText(
                        "Merma dentro del margen tolerable.");
                }
            }
        }

        private void rtbReporteMerma_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
