using System;
using System.Collections.Generic;

#nullable disable

namespace Conectividad.Models.DBPJ
{
    public partial class _019tiposTelefono
    {
        public _019tiposTelefono()
        {
            _018telefonos = new HashSet<_018telefono>();
        }

        public int _019tipoTelefonoId { get; set; }
        public string _019nombre { get; set; }
        public bool _019activo { get; set; }

        public virtual ICollection<_018telefono> _018telefonos { get; set; }
    }
}
