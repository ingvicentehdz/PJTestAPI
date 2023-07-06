using System;
using System.Collections.Generic;

#nullable disable

namespace Conectividad.Models.DBPJ
{
    public partial class _004tiposDocumento059tiposRecurso
    {
        public int _004tipoDocumentoId { get; set; }
        public int _059tipoRecursoId { get; set; }

        public virtual _004tiposDocumento _004tipoDocumento { get; set; }
        public virtual _059tiposRecurso _059tipoRecurso { get; set; }
    }
}
