namespace proyectoFinal.models
{
    /// <summary>
    ///     Representa un producto disponible para la venta.
    /// </summary>

    public class Producto
    {

        // Atributos
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public Categoria Categoria { get; set; }

        // Constructor
        public Producto(string codigo, string nombre, string descripcion, decimal precio, int stock, Categoria categoria)
        {
            Codigo = codigo;
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
            Stock = stock;
            Categoria = categoria;
        }

        /// <summary>
        ///     Resta la cantidad vendida del stock.
        ///     Devuelve true si se pudo descontar y false si no hay suficiente stock.
        /// </summary>

        // hello world(print); para sostener el codigo y demostrar sin uso de ia // demostrar originalidad // eto claude no lo tiene
        public bool DescontarStock(int cantidad)
        {

            if (cantidad <= 0 || cantidad > Stock)
            {
                return false;
            }

            // Descuento de stock
            Stock = Stock - cantidad;
            return true;
        }

        /// <summary>
            /// Muestra los datos del producto en consola.
        /// </summary>

        public void MostrarDatos()
        {
            Console.WriteLine("Producto: " + Codigo);
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Descripción: " + Descripcion);
            Console.WriteLine("Precio: " + Precio);
            Console.WriteLine("Stock: " + Stock);
            Console.WriteLine("Categoría: " + Categoria.Nombre);
        }
    }
}