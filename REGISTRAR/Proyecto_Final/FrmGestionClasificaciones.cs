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
    public partial class FrmGestionClasificaciones : Form
    {
        // Referencia al ComboBox del formulario principal para sincronizar las clasificaciones
        private ComboBox cmbOrigen;

        // Constructor que recibe como parámetro el ComboBox principal para cargar y sincronizar datos
        public FrmGestionClasificaciones(ComboBox comboBoxPrincipal)
        {
            InitializeComponent();
            
            // Asigna el ComboBox recibido a la variable miembro local
            this.cmbOrigen = comboBoxPrincipal;
            
            // Copia los elementos del ComboBox del formulario principal al ListBox local
            foreach (var item in cmbOrigen.Items)
            {
                lstClasificaciones.Items.Add(item);
            }
        }

        private void FrmGestionClasificaciones_Load(object sender, EventArgs e)
        {

        }

        private void Button_Añadir_C_Click(object sender, EventArgs e)
        {
            // Obtiene el texto ingresado, remueve espacios y lo convierte a mayúsculas
            string nueva = Nueva_Clasificacion.Text.Trim().ToUpper();

            // Valida que el campo no esté vacío o contenga únicamente espacios
            if (string.IsNullOrWhiteSpace(nueva))
            {
                MessageBox.Show("Por favor, ingrese un nombre de clasificación.");
                return;
            }

            // Recorre los elementos existentes para evitar agregar una clasificación duplicada
            foreach (var item in lstClasificaciones.Items)
            {
                if (item.ToString().Trim().ToUpper() == nueva)
                {
                    MessageBox.Show("Esta clasificación ya existe en el sistema.");
                    return;
                }
            }

            // Guardar en las listas visuales en tiempo real
            lstClasificaciones.Items.Add(nueva);
            cmbOrigen.Items.Add(nueva);

            // ¡NUEVO! Guardar físicamente en el archivo de texto
            GestionArchivo.GuardarClasificacionTexto(nueva);

            Nueva_Clasificacion.Clear();
            Nueva_Clasificacion.Focus();
        }

        private void Button_Quitar_Click(object sender, EventArgs e)
        {
            // Valida que haya un elemento seleccionado para eliminar
            if (lstClasificaciones.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecciona una clasificación de la lista antes de intentar quitarla.");
                return;
            }
            
            // Obtiene el elemento seleccionado y lo elimina de ambas listas
            string seleccionado = lstClasificaciones.SelectedItem.ToString();
            lstClasificaciones.Items.Remove(seleccionado);
            cmbOrigen.Items.Remove(seleccionado);

            // Reconstrucción del archivo .txt sin la categoría eliminada
            List<string> listaActualizada = new List<string>();
            foreach (var item in lstClasificaciones.Items)
            {
                listaActualizada.Add(item.ToString());
            }
            GestionArchivo.SobreescribirClasificaciones(listaActualizada);
        }

        private void Button_Aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
