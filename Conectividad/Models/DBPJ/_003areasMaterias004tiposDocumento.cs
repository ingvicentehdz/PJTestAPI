using System;
using System.Collections.Generic;

#nullable disable

namespace Conectividad.Models.DBPJ
{
    public partial class _003areasMaterias004tiposDocumento
    {
        public int _003areaMateriaId { get; set; }
        public int _004tipoDocumentoId { get; set; }

        public virtual _003areasMateria _003areaMateria { get; set; }
        public virtual _004tiposDocumento _004tipoDocumento { get; set; }
    }
}
