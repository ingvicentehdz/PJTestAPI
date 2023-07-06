using System;
using System.Collections.Generic;

#nullable disable

namespace Conectividad.Models.DBPJ
{
    public partial class _053articulo
    {
        public _053articulo()
        {
            _008delitos053articulos = new HashSet<_008delitos053articulo>();
            _054fracciones = new HashSet<_054fraccione>();
        }

        public int _053articuloId { get; set; }
        public string _053numero { get; set; }
        public string _053nombre { get; set; }
        public string _053encabezado { get; set; }
        public string _053pie { get; set; }
        public bool? _053activo { get; set; }

        public virtual ICollection<_008delitos053articulo> _008delitos053articulos { get; set; }
        public virtual ICollection<_054fraccione> _054fracciones { get; set; }
    }
}
