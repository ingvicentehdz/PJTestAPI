using System;
using System.Collections.Generic;

#nullable disable

namespace Conectividad.Models.DBPJ
{
    public partial class _013tiposDelito
    {
        public _013tiposDelito()
        {
            _008delitos013tiposDelitos = new HashSet<_008delitos013tiposDelito>();
        }

        public int _013tipoDelitoId { get; set; }
        public string _013nombre { get; set; }
        public string _013codigo { get; set; }
        public bool _013activo { get; set; }

        public virtual ICollection<_008delitos013tiposDelito> _008delitos013tiposDelitos { get; set; }
    }
}
