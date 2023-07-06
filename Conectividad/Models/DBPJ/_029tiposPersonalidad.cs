using System;
using System.Collections.Generic;

#nullable disable

namespace Conectividad.Models.DBPJ
{
    public partial class _029tiposPersonalidad
    {
        public _029tiposPersonalidad()
        {
            _029tiposPersonalidad002materia = new HashSet<_029tiposPersonalidad002materia>();
        }

        public int _029tipoPersonalidadId { get; set; }
        public string _029nombre { get; set; }
        public int? _029tipoPersonalidadIdMajat { get; set; }
        public int? _029tipoPersonalidadId53equitas { get; set; }
        public bool _029activo { get; set; }

        public virtual ICollection<_029tiposPersonalidad002materia> _029tiposPersonalidad002materia { get; set; }
    }
}
