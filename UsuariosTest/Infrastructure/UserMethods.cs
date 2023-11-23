using UsuariosTest.Models;

namespace UsuariosTest.Infrastructure
{
    public class UserMethods
    {
        private readonly List<Usuario>? usuarios;
        public Usuario? CrearUsuario(string nombre, string correo, int edad)
        {

            // Validaciones simples
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(correo))
            {
                Console.WriteLine("Error: Nombre y correo son obligatorios.");
                return null;
            }

            if (edad < 0 || edad > 150)
            {
                Console.WriteLine("Error: La edad debe estar entre 0 y 150.");
                return null;
            }

            Usuario nuevoUsuario = new Usuario
            {
                Nombre = nombre,
                Correo = correo,
                Edad = edad
            };

            usuarios.Add(nuevoUsuario);

            Console.WriteLine($"Usuario creado: {nombre} ({correo}), Edad: {edad}");
            return nuevoUsuario;
        }
    }
}
