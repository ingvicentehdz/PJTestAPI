using System;
using System.Collections.Generic;

#nullable disable

namespace Conectividad.Models.DBPJ
{
    public partial class _068puestosOficiale
    {
        public _068puestosOficiale()
        {
            _045puestos = new HashSet<_045puesto>();
        }

        public int _068puestoOficialId { get; set; }
        public string _068nombre { get; set; }
        public string _068clave { get; set; }
        public int? _060tipoCategoriaPuestoId { get; set; }
        public bool _068activo { get; set; }

        public virtual _060tiposCategoriasPuesto _060tipoCategoriaPuesto { get; set; }
        public virtual ICollection<_045puesto> _045puestos { get; set; }
    }
}
