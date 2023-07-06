using System;
using System.Collections.Generic;

#nullable disable

namespace Conectividad.Models.DBPJ
{
    public partial class _003areasMateria
    {
        public _003areasMateria()
        {
            _003areasMaterias004tiposDocumentos = new HashSet<_003areasMaterias004tiposDocumento>();
            _003areasMaterias024tiposAudiencia = new HashSet<_003areasMaterias024tiposAudiencium>();
        }

        public int _003areaMateriaId { get; set; }
        public int _001areaId { get; set; }
        public int _002materiaId { get; set; }

        public virtual _001area _001area { get; set; }
        public virtual _002materia _002materia { get; set; }
        public virtual ICollection<_003areasMaterias004tiposDocumento> _003areasMaterias004tiposDocumentos { get; set; }
        public virtual ICollection<_003areasMaterias024tiposAudiencium> _003areasMaterias024tiposAudiencia { get; set; }
    }
}
