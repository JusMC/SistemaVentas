namespace proyectoFinal.models

/// <summary>
///     Clase base abstracta para las personas que usarán el sistema (como clientes y administradores).
/// </summary>

{
    public abstract class Persona
    {
        // Atributos
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }

        // Constructor
        public Persona(int id, string nombre, string telefono, string correo)
        {
            Id = id;
            Nombre = nombre;
            Telefono = telefono;
            Correo = correo;
        }

        // Métodos

            // Función abstracta que muestra la info de la persona, cada clase hija lo adapta a su manera
            public abstract void MostrarInformacion();
    }
}