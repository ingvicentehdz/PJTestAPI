using System;
using System.Collections.Generic;

#nullable disable

namespace Conectividad.Models.DBPJ
{
    public partial class _059tiposRecurso
    {
        public _059tiposRecurso()
        {
            _004tiposDocumento059tiposRecursos = new HashSet<_004tiposDocumento059tiposRecurso>();
            _058tiposTocasOrales059tiposRecursos = new HashSet<_058tiposTocasOrales059tiposRecurso>();
        }

        public int _059tipoRecursoId { get; set; }
        public string _059nombre { get; set; }
        public bool _059activo { get; set; }

        public virtual ICollection<_004tiposDocumento059tiposRecurso> _004tiposDocumento059tiposRecursos { get; set; }
        public virtual ICollection<_058tiposTocasOrales059tiposRecurso> _058tiposTocasOrales059tiposRecursos { get; set; }
    }
}
