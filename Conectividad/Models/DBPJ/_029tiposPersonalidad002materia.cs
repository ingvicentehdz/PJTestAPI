using System;
using System.Collections.Generic;

#nullable disable

namespace Conectividad.Models.DBPJ
{
    public partial class _029tiposPersonalidad002materia
    {
        public int _029tipoPersonalidadId { get; set; }
        public int _002materiaId { get; set; }

        public virtual _002materia _002materia { get; set; }
        public virtual _029tiposPersonalidad _029tipoPersonalidad { get; set; }
    }
}
