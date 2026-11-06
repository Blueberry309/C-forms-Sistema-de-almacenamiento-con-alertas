using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public static class Validacion
    {
        // Valida si un texto está vacío o contiene únicamente espacios en blanco
        public static bool ValidarTextoVacio(string texto, string nombreCampo)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                // Muestra un mensaje advirtiendo qué campo está vacío
                MessageBox.Show($"El campo '{nombreCampo}' no puede estar vacío.");
                return false;
            }
            return true;
        }

        // Valida que el valor de stock ingresado sea un número entero no negativo
        public static bool ValidarStock(string textoStock, out int stockValido)
        {
            stockValido = 0;

            // Intenta convertir el texto a número entero y verifica que sea mayor o igual a cero
            if (!int.TryParse(textoStock, out stockValido) || stockValido < 0)
            {
                MessageBox.Show("El Stock debe ser un número entero mayor o igual a cero.");
                return false;
            }
            return true;
        }

        // Valida que el precio ingresado sea un número decimal no negativo
        public static bool ValidarPrecio(string textoPrecio, string nombreCampo, out decimal precioValido)
        {
            precioValido = 0;

            // Intenta convertir el texto a decimal y verifica que sea mayor o igual a cero
            if (!decimal.TryParse(textoPrecio, out precioValido) || precioValido < 0)
            {
                MessageBox.Show($"El '{nombreCampo}' debe ser un número decimal mayor o igual a cero.");
                return false;
            }
            return true;
        }

        // Valida que se haya seleccionado un elemento en un control ComboBox
        public static bool ValidarSeleccionCombo(int selectedIndex, string nombreCampo)
        {
            // Un índice de -1 significa que no hay ningún elemento seleccionado
            if (selectedIndex == -1)
            {
                MessageBox.Show($"Por favor, seleccione una opción en '{nombreCampo}'");
                return false;
            }
            return true;
        }
    }
}
