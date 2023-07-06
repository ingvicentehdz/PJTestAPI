using System;
using System.Collections.Generic;

#nullable disable

namespace Conectividad.Models.DBPJ
{
    public partial class _055inciso
    {
        public int _055incisoId { get; set; }
        public string _055letraOnumero { get; set; }
        public string _055nombre { get; set; }
        public int _054fraccionId { get; set; }
        public bool? _055activo { get; set; }

        public virtual _054fraccione _054fraccion { get; set; }
    }
}
