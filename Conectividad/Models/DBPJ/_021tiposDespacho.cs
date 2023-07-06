using System;
using System.Collections.Generic;

#nullable disable

namespace Conectividad.Models.DBPJ
{
    public partial class _021tiposDespacho
    {
        public _021tiposDespacho()
        {
            _015despachos = new HashSet<_015despacho>();
        }

        public int _021tipoDespachoId { get; set; }
        public string _021nombre { get; set; }
        public bool _021activo { get; set; }

        public virtual ICollection<_015despacho> _015despachos { get; set; }
    }
}
