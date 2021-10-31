using System.ComponentModel.DataAnnotations;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginRegistroUsuarios.Models
{
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Usuarios()
        {
            UsuarioId = 0;
            Username = string.Empty;
            Password = string.Empty;
        }
    }
}
