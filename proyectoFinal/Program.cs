// Clase principal (Main)
using proyectoFinal.models;

Categoria bebidas = new Categoria(1, "Bebidas", "Refrescos y jugos");
Producto coca = new Producto("P001", "Coca-Cola", "Lata 355 ml", 800, 50, bebidas);
Producto jugo = new Producto("P002", "Jugo de naranja", "Botella 500 ml", 1200, 3, bebidas);

Cliente ana = new Cliente(1, "Ana Rojas", "8888-8888", "ana@correo.com");

Venta venta = new Venta(1, ana);
venta.AgregarProducto(coca, 2);

if (venta.AgregarProducto(jugo, 5) == false)
{
    Console.WriteLine("No hay suficiente stock de " + jugo.Nombre);
}

venta.MostrarDatos();