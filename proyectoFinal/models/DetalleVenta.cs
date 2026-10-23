namespace proyectoFinal.models
{
    /// <summary>
    ///     Representa una línea de una venta: un producto, la cantidad y el precio.
    /// </summary>

    public class DetalleVenta
    {
        // Atributos
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }

        // Constructor
        public DetalleVenta(Producto producto, int cantidad)
        {
            Producto = producto;
            Cantidad = cantidad;

            // Se guarda el precio del momento de la venta, por si el precio del producto cambia después
            PrecioUnitario = producto.Precio;
        }

        /// <summary>
        ///     Calcula el subtotal de la línea (cantidad por precio unitario).
        /// </summary>

        public decimal CalcularSubtotal()
        {
            return Cantidad * PrecioUnitario;
        }

        /// <summary>
        ///     Muestra la línea de detalle en consola.
        /// </summary>

        public void MostrarDatos()
        {
            Console.WriteLine(Producto.Nombre + " x" + Cantidad + " a " + PrecioUnitario + " = " + CalcularSubtotal());
        }
    }
}