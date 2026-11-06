using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Proyecto_Final.FrmRegistroProducto;

namespace Proyecto_Final
{
    public static class GestionArchivo
    {
        //Define de forma automática dónde se creará el bloc de notas
        private static string rutaArchivo = Path.Combine(Application.StartupPath, "productos.txt");

        // Método para sobrescribir el bloc de notas completo con la nueva lista de productos
        public static void SobreescribirProductos(List<Product> listaNueva)
        {
            try
            {
                // Abre el archivo en modo de sobrescritura
                using (StreamWriter sw = new StreamWriter(rutaArchivo, false))
                {
                    // Recorre cada producto en la lista para grabarlo en el archivo
                    foreach (Product p in listaNueva)
                    {
                        // Crea una cadena formateada con las propiedades del producto
                        string linea = $"{p.Codigo}|{p.Nombre}|{p.Clasificacion}|{p.EstadoFisico}|{p.PrecioCompra}|{p.PrecioVenta}|{p.Stock}|{p.FechaRegistro.ToShortDateString()}|{p.FechaCaducidad.ToShortDateString()}";

                        // Escribe la línea en el archivo de texto
                        sw.WriteLine(linea);
                    }
                }
            }
            catch (Exception ex)
            {
                // Muestra un mensaje en pantalla en caso de que ocurra algún error
                MessageBox.Show("Error al actualizar los productos: " + ex.Message);
            }
        }


        //GUARDAR (Escribe una línea nueva al final del archivo sin borrar lo anterior)
        public static void GuardarProductoTexto(Product p)
        {
            try
            {
                string linea = $"{p.Codigo}|{p.Nombre}|{p.Clasificacion}|{p.EstadoFisico}|{p.PrecioCompra}|{p.PrecioVenta}|{p.Stock}|{p.FechaRegistro.ToShortDateString()}|{p.FechaCaducidad.ToShortDateString()}";

                using (StreamWriter sw = new StreamWriter(rutaArchivo, true))
                {
                    sw.WriteLine(linea);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al guardar en el archivo");
            }
        }

        //LEER (Convierte el texto del archivo de nuevo en objetos que C# entienda)
        public static List<Product> LeerProductosTexto()
        {
            List<Product> lista = new List<Product>();

            // Si el archivo no existe todavía, devolvemos la lista vacía para que no se rompa el programa
            if (!File.Exists(rutaArchivo)) return lista;

            try
            {
                // Leemos todas las líneas del bloc de notas de un solo golpe
                string[] lineas = File.ReadAllLines(rutaArchivo);

                foreach (string linea in lineas)
                {
                    if (string.IsNullOrWhiteSpace(linea)) continue;

                    // Cortamos la línea cada vez que encontremos un '|'
                    string[] datos = linea.Split('|');

                    // Reconstruimos el producto posición por posición
                    Product p = new Product
                    {
                        Codigo = datos[0],
                        Nombre = datos[1],
                        Clasificacion = datos[2],
                        EstadoFisico = datos[3],
                        PrecioCompra = decimal.Parse(datos[4]),
                        PrecioVenta = decimal.Parse(datos[5]),
                        Stock = int.Parse(datos[6]),
                        FechaRegistro = DateTime.Parse(datos[7]),
                        FechaCaducidad = DateTime.Parse(datos[8])
                    };
                    lista.Add(p);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al leer el archivo");
            }

            return lista;
        }

        // Guarda una nueva clasificación en el archivo de texto en modo de adición (sin borrar el contenido anterior)
        public static void GuardarClasificacionTexto(string categoria)
        {
            try
            {
                // Define la ruta del archivo 'clasificaciones.txt' en el directorio de inicio de la aplicación
                string rutaClasificaciones = Path.Combine(Application.StartupPath, "clasificaciones.txt");
                
                // Abre el archivo usando StreamWriter; el parámetro 'true' indica que los nuevos datos se agregarán al final
                using (StreamWriter sw = new StreamWriter(rutaClasificaciones, true))
                {
                    // Escribe la nueva categoría en el archivo
                    sw.WriteLine(categoria);
                }
            }
            catch (Exception ex)
            {
                // Muestra un mensaje en pantalla en caso de que ocurra algún error
                MessageBox.Show("Error al guardar la clasificación: " + ex.Message);
            }
        }

        // LEER CLASIFICACIONES (Recupera todas las categorías guardadas)
        public static List<string> LeerClasificacionesTexto()
        {
            // Inicializa una lista vacía para almacenar las categorías
            List<string> lista = new List<string>();
            
            // Define la ruta del archivo 'clasificaciones.txt'
            string rutaClasificaciones = Path.Combine(Application.StartupPath, "clasificaciones.txt");

            // Si el archivo no existe, retorna la lista vacía inmediatamente
            if (!File.Exists(rutaClasificaciones)) return lista;

            try
            {
                // Lee todas las líneas del archivo
                string[] lineas = File.ReadAllLines(rutaClasificaciones);
                
                // Procesa cada línea leída
                foreach (string linea in lineas)
                {
                    // Verifica que la línea no esté vacía
                    if (!string.IsNullOrWhiteSpace(linea))
                    {
                        // Limpia los espacios y convierte a mayúsculas antes de agregar a la lista
                        lista.Add(linea.Trim().ToUpper());
                    }
                }
            }
            catch (Exception ex)
            {
                // Muestra un mensaje en caso de error en la lectura del archivo
                MessageBox.Show("Error al leer las clasificaciones: " + ex.Message);
            }
            
            // Retorna la lista resultante de clasificaciones
            return lista;
        }

        //SOBREESCRIBIR CLASIFICACIONES (Para cuando eliminemos una de la lista)
        public static void SobreescribirClasificaciones(List<string> listaNueva)
        {
            try
            {
                string rutaClasificaciones = Path.Combine(Application.StartupPath, "clasificaciones.txt");
                using (StreamWriter sw = new StreamWriter(rutaClasificaciones, false))
                {
                    foreach (string cat in listaNueva)
                    {
                        sw.WriteLine(cat);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al actualizar las clasificaciones");
            }
        }

    }
}

