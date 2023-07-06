using System;
using System.Collections.Generic;

#nullable disable

namespace Conectividad.Models.DBPJ
{
    public partial class _025basesDeDato
    {
        public _025basesDeDato()
        {
            _031sistemas = new HashSet<_031sistema>();
        }

        public int _025baseDeDatosId { get; set; }
        public string _025nombre { get; set; }
        public string _025descripcion { get; set; }
        public bool? _025activo { get; set; }

        public virtual ICollection<_031sistema> _031sistemas { get; set; }
    }
}
