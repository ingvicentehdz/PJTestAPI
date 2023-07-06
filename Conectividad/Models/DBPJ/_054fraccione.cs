using System;
using System.Collections.Generic;

#nullable disable

namespace Conectividad.Models.DBPJ
{
    public partial class _054fraccione
    {
        public _054fraccione()
        {
            _055incisos = new HashSet<_055inciso>();
        }

        public int _054fraccionId { get; set; }
        public string _054numero { get; set; }
        public string _054numeroRomano { get; set; }
        public string _054nombre { get; set; }
        public string _054descripcion { get; set; }
        public int _053articuloId { get; set; }
        public bool? _054activo { get; set; }

        public virtual _053articulo _053articulo { get; set; }
        public virtual ICollection<_055inciso> _055incisos { get; set; }
    }
}
