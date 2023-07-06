using System;
using System.Collections.Generic;

#nullable disable

namespace Conectividad.Models.DBPJ
{
    public partial class _058tiposTocasOrale
    {
        public _058tiposTocasOrale()
        {
            _001areas058tiposTocasOrales = new HashSet<_001areas058tiposTocasOrale>();
            _058tiposTocasOrales059tiposRecursos = new HashSet<_058tiposTocasOrales059tiposRecurso>();
        }

        public int _058tipoTocaOralId { get; set; }
        public string _058nombre { get; set; }
        public bool _058activo { get; set; }

        public virtual ICollection<_001areas058tiposTocasOrale> _001areas058tiposTocasOrales { get; set; }
        public virtual ICollection<_058tiposTocasOrales059tiposRecurso> _058tiposTocasOrales059tiposRecursos { get; set; }
    }
}
