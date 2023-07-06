using System;
using System.Collections.Generic;

#nullable disable

namespace Conectividad.Models.DBPJ
{
    public partial class _001areas058tiposTocasOrale
    {
        public int _001areaId { get; set; }
        public int _058tipoTocaOralId { get; set; }

        public virtual _001area _001area { get; set; }
        public virtual _058tiposTocasOrale _058tipoTocaOral { get; set; }
    }
}
