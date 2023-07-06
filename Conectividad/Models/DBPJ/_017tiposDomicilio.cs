using System;
using System.Collections.Generic;

#nullable disable

namespace Conectividad.Models.DBPJ
{
    public partial class _017tiposDomicilio
    {
        public _017tiposDomicilio()
        {
            _016domicilios = new HashSet<_016domicilio>();
        }

        public int _017tipoDomicilioId { get; set; }
        public string _017nombre { get; set; }
        public bool _017activo { get; set; }

        public virtual ICollection<_016domicilio> _016domicilios { get; set; }
    }
}
