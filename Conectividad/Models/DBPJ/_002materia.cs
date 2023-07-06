using System;
using System.Collections.Generic;

#nullable disable

namespace Conectividad.Models.DBPJ
{
    public partial class _002materia
    {
        public _002materia()
        {
            _003areasMateria = new HashSet<_003areasMateria>();
            _024tiposAudiencia = new HashSet<_024tiposAudiencium>();
            _029tiposPersonalidad002materia = new HashSet<_029tiposPersonalidad002materia>();
            _042juicios = new HashSet<_042juicio>();
        }

        public int _002materiaId { get; set; }
        public string _002nombre { get; set; }
        public int? _002materiaIdEquitas { get; set; }
        public int? _002materiaIdMajat { get; set; }
        public bool? _002activo { get; set; }

        public virtual ICollection<_003areasMateria> _003areasMateria { get; set; }
        public virtual ICollection<_024tiposAudiencium> _024tiposAudiencia { get; set; }
        public virtual ICollection<_029tiposPersonalidad002materia> _029tiposPersonalidad002materia { get; set; }
        public virtual ICollection<_042juicio> _042juicios { get; set; }
    }
}
