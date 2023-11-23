using System.ComponentModel.DataAnnotations;

namespace UsuariosTest.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre debe tener como máximo 100 caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El correo es obligatorio.")]
        [EmailAddress(ErrorMessage = "Ingrese un correo electrónico válido.")]
        public string Correo { get; set; }

        [Range(1, 150, ErrorMessage = "La edad debe estar entre 1 y 150.")]
        public int Edad { get; set; }
    }
}

