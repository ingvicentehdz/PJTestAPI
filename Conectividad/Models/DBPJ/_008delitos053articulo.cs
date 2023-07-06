using System;
using System.Collections.Generic;

#nullable disable

namespace Conectividad.Models.DBPJ
{
    public partial class _008delitos053articulo
    {
        public int _008delitoId { get; set; }
        public int _053articuloId { get; set; }

        public virtual _008delito _008delito { get; set; }
        public virtual _053articulo _053articulo { get; set; }
    }
}
