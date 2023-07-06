using System;
using System.Collections.Generic;

#nullable disable

namespace Conectividad.Models.DBPJ
{
    public partial class _032tiposSistema
    {
        public _032tiposSistema()
        {
            _031sistemas = new HashSet<_031sistema>();
        }

        public int _032tipoSistemaId { get; set; }
        public string _032nombre { get; set; }
        public bool? _032activo { get; set; }
        public string _032icono { get; set; }
        public string _032rutaDeAcceso { get; set; }

        public virtual ICollection<_031sistema> _031sistemas { get; set; }
    }
}
