using System;
using System.Collections.Generic;

#nullable disable

namespace Conectividad.Models.DBPJ
{
    public partial class _060tiposCategoriasPuesto
    {
        public _060tiposCategoriasPuesto()
        {
            _045puestos = new HashSet<_045puesto>();
            _068puestosOficiales = new HashSet<_068puestosOficiale>();
        }

        public int _060tipoCategoriaPuestoId { get; set; }
        public string _060nombre { get; set; }
        public bool _060activo { get; set; }
        public DateTime? _060fechaInicial { get; set; }
        public DateTime? _060fechaFinal { get; set; }

        public virtual ICollection<_045puesto> _045puestos { get; set; }
        public virtual ICollection<_068puestosOficiale> _068puestosOficiales { get; set; }
    }
}
