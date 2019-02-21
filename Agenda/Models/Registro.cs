using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Agenda.Models
{
    public class Registro
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required, DataType(DataType.PhoneNumber)]
        public string Numero { get; set; }
        public string Tipo { get; set; }
    }

}
