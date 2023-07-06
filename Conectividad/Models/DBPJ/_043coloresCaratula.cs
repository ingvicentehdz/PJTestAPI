using System;
using System.Collections.Generic;

#nullable disable

namespace Conectividad.Models.DBPJ
{
    public partial class _043coloresCaratula
    {
        public _043coloresCaratula()
        {
            _042juicios = new HashSet<_042juicio>();
        }

        public int _043colorCaratulaId { get; set; }
        public string _043nombre { get; set; }
        public DateTime? _043fechaInicio { get; set; }
        public DateTime? _043fechaTermino { get; set; }
        public string _043hexadecimal { get; set; }

        public virtual ICollection<_042juicio> _042juicios { get; set; }
    }
}
