using System;
using System.Collections.Generic;

#nullable disable

namespace Conectividad.Models.DBPJ
{
    public partial class _022dependenciasPublica
    {
        public _022dependenciasPublica()
        {
            _015despachos = new HashSet<_015despacho>();
        }

        public int _022dependenciaPublicaId { get; set; }
        public string _022nombre { get; set; }
        public bool _022activo { get; set; }

        public virtual ICollection<_015despacho> _015despachos { get; set; }
    }
}
