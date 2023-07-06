using System;
using System.Collections.Generic;

#nullable disable

namespace Conectividad.Models.DBPJ
{
    public partial class _008delitos013tiposDelito
    {
        public int _008delitoId { get; set; }
        public int _013tipoDelitoId { get; set; }

        public virtual _008delito _008delito { get; set; }
        public virtual _013tiposDelito _013tipoDelito { get; set; }
    }
}
