using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnicaNET.Entities
{
    class AlumnoCurso
    {
        public int AlumnoId { get; set; }
        public int CursoId { get; set; }
        public int EstadoCursoId { get; set; }
        public Alumno Alumno { get; set; }
        public Curso Curso { get; set; }
      
    }
}
