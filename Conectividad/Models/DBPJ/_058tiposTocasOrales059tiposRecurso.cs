using System;
using System.Collections.Generic;

#nullable disable

namespace Conectividad.Models.DBPJ
{
    public partial class _058tiposTocasOrales059tiposRecurso
    {
        public int _058tipoTocaOralId { get; set; }
        public int _059tipoRecursoId { get; set; }

        public virtual _058tiposTocasOrale _058tipoTocaOral { get; set; }
        public virtual _059tiposRecurso _059tipoRecurso { get; set; }
    }
}
