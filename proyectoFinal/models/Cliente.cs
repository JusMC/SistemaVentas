namespace proyectoFinal.models

/// <summary>
///     Representa a un cliente que realiza las compras en el sistema.
/// </summary>

{
    public class Cliente : Persona
    {
        // Constructor
        public Cliente(int id, string nombre, string telefono, string correo)
            : base(id, nombre, telefono, correo)
        {
        }

        // Adaptación del método abstracto MostrarInformacion() para mostrar la información del cliente
        public override void MostrarInformacion()
        {
            Console.WriteLine("Cliente #" + Id);
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Teléfono: " + Telefono);
            Console.WriteLine("Correo: " + Correo);
        }
    }
}