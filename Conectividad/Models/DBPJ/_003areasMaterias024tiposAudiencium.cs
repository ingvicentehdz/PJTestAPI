using System;
using System.Collections.Generic;

#nullable disable

namespace Conectividad.Models.DBPJ
{
    public partial class _003areasMaterias024tiposAudiencium
    {
        public int _003areaMateriaId { get; set; }
        public int _024tipoAudienciaId { get; set; }

        public virtual _003areasMateria _003areaMateria { get; set; }
        public virtual _024tiposAudiencium _024tipoAudiencia { get; set; }
    }
}
