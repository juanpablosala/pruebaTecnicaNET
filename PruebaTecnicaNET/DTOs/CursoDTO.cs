using PruebaTecnicaNET.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnicaNET.DTOs
{
    class CursoDTO
    {
        public int Id { get; set; }
    
        public int EstadoCursoId { get; set; }

        public void MapToModel(Curso curso)
        {
            curso.EstadoCursoId = EstadoCursoId;
        }
    }
}
