using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PruebaTecnicaNET.Entities
{
    class Curso
    {
        public int Id { get; set; }
        [Required]
        public string Denominacion { get; set; }
        public string Descripcion { get; set; }
        public bool Baja { get; set; }
        public int EstadoCursoId { get; set; }
        public EstadoCurso EstadoCurso { get; set; }
        public List<AlumnoCurso> AlumnoCursos { get; set; }
     
    }
}
