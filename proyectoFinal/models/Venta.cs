namespace proyectoFinal.models
{
    /// <summary>
    ///     Representa una venta (cabecera) con su cliente y la lista de productos vendidos.
    /// </summary>

    public class Venta
    {

        // Atributos
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public Cliente Cliente { get; set; }
        public List<DetalleVenta> Detalles { get; set; }

        // Constructor
        public Venta(int id, Cliente cliente)
        {
            Id = id;
            Cliente = cliente;
            Fecha = DateTime.Now;
            Detalles = new List<DetalleVenta>();
        }

        /// <summary>
        ///     Agrega un producto a la venta y descuenta su stock.
        ///     Devuelve true si se pudo agregar y false si no hay suficiente stock.
        /// </summary>

        public bool AgregarProducto(Producto producto, int cantidad)
        {
            if (producto.DescontarStock(cantidad) == false)
            {
                return false;
            }

            DetalleVenta detalle = new DetalleVenta(producto, cantidad);
            Detalles.Add(detalle);
            return true;
        }

        /// <summary>
        ///     Calcula el total de la venta sumando los subtotales de cada detalle.
        /// </summary>

        public decimal CalcularTotal()
        {
            decimal total = 0;

            foreach (DetalleVenta detalle in Detalles)
            {
                total = total + detalle.CalcularSubtotal();
            }

            return total;
        }

        /// <summary>
        ///     Muestra la venta completa en consola, como una factura sencilla.
        /// </summary>

        public void MostrarDatos()
        {
            Console.WriteLine("Venta #" + Id);
            Console.WriteLine("Fecha: " + Fecha);
            Console.WriteLine("Cliente: " + Cliente.Nombre);
            Console.WriteLine("Productos:");

            foreach (DetalleVenta detalle in Detalles)
            {
                detalle.MostrarDatos();
            }

            Console.WriteLine("Total: " + CalcularTotal());
        }
    }
}