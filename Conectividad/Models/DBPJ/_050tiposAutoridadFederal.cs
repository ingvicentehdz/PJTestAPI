using System;
using System.Collections.Generic;

#nullable disable

namespace Conectividad.Models.DBPJ
{
    public partial class _050tiposAutoridadFederal
    {
        public _050tiposAutoridadFederal()
        {
            _049autoridadesFederales = new HashSet<_049autoridadesFederale>();
        }

        public int _050tipoAutoridadFederalId { get; set; }
        public string _050nombre { get; set; }
        public bool? _050activo { get; set; }

        public virtual ICollection<_049autoridadesFederale> _049autoridadesFederales { get; set; }
    }
}
