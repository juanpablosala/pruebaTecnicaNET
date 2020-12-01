using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PruebaTecnicaNET.Entities
{
    class Alumno
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public long Dni { get; set; }
        [Required]
        public string Domicilio { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Celular { get; set; }
        [Required]
        public DateTime Fecha_nac { get; set; }
        public bool Baja { get; set; }
        public List<AlumnoCurso> AlumnoCursos { get; set; }
    }
}
