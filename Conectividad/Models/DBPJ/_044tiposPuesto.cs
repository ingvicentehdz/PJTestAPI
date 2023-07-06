using System;
using System.Collections.Generic;

#nullable disable

namespace Conectividad.Models.DBPJ
{
    public partial class _044tiposPuesto
    {
        public _044tiposPuesto()
        {
            _045puestos = new HashSet<_045puesto>();
        }

        public int _044tipoPuestoId { get; set; }
        public string _044nombre { get; set; }
        public bool _044activo { get; set; }
        public DateTime _044fechaRegistro { get; set; }
        public int _044usuarioQuienRegistro001dbcuentas { get; set; }

        public virtual ICollection<_045puesto> _045puestos { get; set; }
    }
}
