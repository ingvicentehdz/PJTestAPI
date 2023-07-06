using System;
using System.Collections.Generic;

#nullable disable

namespace Conectividad.Models.DBPJ
{
    public partial class _004tiposDocumento
    {
        public _004tiposDocumento()
        {
            _003areasMaterias004tiposDocumentos = new HashSet<_003areasMaterias004tiposDocumento>();
            _004tiposDocumento059tiposRecursos = new HashSet<_004tiposDocumento059tiposRecurso>();
        }

        public int _004tipoDocumentoId { get; set; }
        public string _004descripcion { get; set; }
        public int? _004tipoDocumentoIdEquitas { get; set; }
        public int? _004tipoDocumentoIdMajat { get; set; }
        public bool _004documentoPrincipal { get; set; }
        public bool? _004activo { get; set; }

        public virtual ICollection<_003areasMaterias004tiposDocumento> _003areasMaterias004tiposDocumentos { get; set; }
        public virtual ICollection<_004tiposDocumento059tiposRecurso> _004tiposDocumento059tiposRecursos { get; set; }
    }
}
