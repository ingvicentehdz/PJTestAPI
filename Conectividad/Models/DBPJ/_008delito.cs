using System;
using System.Collections.Generic;

#nullable disable

namespace Conectividad.Models.DBPJ
{
    public partial class _008delito
    {
        public _008delito()
        {
            _008delitos013tiposDelitos = new HashSet<_008delitos013tiposDelito>();
            _008delitos053articulos = new HashSet<_008delitos053articulo>();
        }

        public int _008delitoId { get; set; }
        public string _008nombre { get; set; }
        public int? _008delitoIdMajat { get; set; }
        public int? _008delitoIdEquitas { get; set; }
        public int? _033tipoBienJuridicoId { get; set; }
        public string _008codigo { get; set; }
        public bool _008activo { get; set; }

        public virtual _033tiposBienJuridico _033tipoBienJuridico { get; set; }
        public virtual ICollection<_008delitos013tiposDelito> _008delitos013tiposDelitos { get; set; }
        public virtual ICollection<_008delitos053articulo> _008delitos053articulos { get; set; }
    }
}
