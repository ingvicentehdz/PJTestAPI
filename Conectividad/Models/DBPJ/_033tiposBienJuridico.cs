using System;
using System.Collections.Generic;

#nullable disable

namespace Conectividad.Models.DBPJ
{
    public partial class _033tiposBienJuridico
    {
        public _033tiposBienJuridico()
        {
            _008delitos = new HashSet<_008delito>();
        }

        public int _033tipoBienJuridicoId { get; set; }
        public string _033nombre { get; set; }
        public string _033codigo { get; set; }
        public bool? _033activo { get; set; }

        public virtual ICollection<_008delito> _008delitos { get; set; }
    }
}
