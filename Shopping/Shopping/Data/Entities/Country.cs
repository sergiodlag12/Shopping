﻿using System.ComponentModel.DataAnnotations;

namespace Shopping.Data.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [Display(Name="País")]
        [MaxLength(50, ErrorMessage ="El campo {0} deb tener máximo {1} caracteres.")]
        [Required(ErrorMessage ="Elcampo {0} es obligatorio.")]
        public string Name { get; set; }
    }
}
