using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaAdopciones.Models
{
    public class Mascotas
    {
        [Key]
        public int MascotaID { get; set; }

        [Required, MinLength(1), Display(Name = "Nombre")]
        public  string nombre { get; set; }

        [Required, Display(Name ="Raza")]
        public string raza { get; set; }

        [Required, Display(Name = "Sexo")]
        public string sexo { get; set; }

        [Required, Display(Name = "Color")]
        public string color { get; set; }

        [Required, Display(Name = "Edad")]
        public int edad { get; set; }

        [Required, Display(Name = "Señas Particulares")]
        public string señas { get; set; }

        [Required, Display(Name = "Enfermedades")]
        public string enfermedad { get; set; }

        [Required, Display(Name = "Entrada al Control Animal")]
        public DateTime entradaCA { get; set; }

        [Display(Name = "Salida al Control Animal")]
        public DateTime salidaCA { get; set; }

        [Display(Name = "Vacunas")]
        public string vacunas { get; set; }

        
        public DateTime fecheEsterilizacion { get; set; }


        virtual public ICollection<Dueños> dueños { get; set; }
    }
}