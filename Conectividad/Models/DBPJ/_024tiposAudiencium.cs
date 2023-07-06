using System;
using System.Collections.Generic;

#nullable disable

namespace Conectividad.Models.DBPJ
{
    public partial class _024tiposAudiencium
    {
        public _024tiposAudiencium()
        {
            _003areasMaterias024tiposAudiencia = new HashSet<_003areasMaterias024tiposAudiencium>();
        }

        public int _024tipoAudienciaId { get; set; }
        public string _024nombre { get; set; }
        public bool _024activo { get; set; }
        public int? _024tipoAudienciaIdSiop { get; set; }
        public int? _024tipoAudienciaIdEquitas { get; set; }
        public int? _002materiaId { get; set; }

        public virtual _002materia _002materia { get; set; }
        public virtual ICollection<_003areasMaterias024tiposAudiencium> _003areasMaterias024tiposAudiencia { get; set; }
    }
}
