using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaAdopciones.Models
{
    public class Dueños
    {
        [Key]
        public int DueñoID { get; set; }

        [Required, MinLength(1), Display(Name ="Nombre")]
        public string nombre { get; set; }

        [Required, Display(Name ="Apellido Paterno")]
        public string apellidoP { get; set; }

        [Required, Display(Name = "Apellido Materno")]
        public string apellidoM { get; set; }

        [Required, Display(Name = "Edad")]
        public int edad { get; set; }

        [Required, Display(Name = "Ciudad")]
        public string ciudad { get; set; }

        [Required, Display(Name = "Teléfono")]
        public string telefono { get; set; }

        [Required, Display(Name = "Domicilio")]
        public string domicilio { get; set; }


        public int MascotasID { get; set; }
        virtual public Mascotas mascotas { get; set; }
    }
}