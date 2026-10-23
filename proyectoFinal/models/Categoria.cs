namespace proyectoFinal.models
{
    /// <summary>
    ///     Representa una categoría para agrupar productos.
    /// </summary>

    public class Categoria
    {
        
        // Atributos
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        // Constructor
        public Categoria(int id, string nombre, string descripcion)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
        }

        // Muestra los datos de la categoría en consola.
        public void MostrarDatos()
        {
            Console.WriteLine("Numero de categoria: " + Id);
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Descripción: " + Descripcion);
        }
    }
}