using System;
using System.Collections.Generic;

#nullable disable

namespace Conectividad.Models.DBPJ
{
    public partial class _011entidadesFederativa
    {
        public _011entidadesFederativa()
        {
            _010municipios = new HashSet<_010municipio>();
        }

        public int _011entidadFederativaId { get; set; }
        public string _011nombre { get; set; }
        public string _011codigo { get; set; }
        public int? _037paisId { get; set; }
        public bool? _011activo { get; set; }

        public virtual _037paise _037pais { get; set; }
        public virtual ICollection<_010municipio> _010municipios { get; set; }
    }
}
