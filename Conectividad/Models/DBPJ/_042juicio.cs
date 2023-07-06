using System;
using System.Collections.Generic;

#nullable disable

namespace Conectividad.Models.DBPJ
{
    public partial class _042juicio
    {
        public _042juicio()
        {
            _046tramites = new HashSet<_046tramite>();
        }

        public int _042juicioId { get; set; }
        public string _042nombre { get; set; }
        public string _042naturaleza { get; set; }
        public int? _043colorCaratulaId { get; set; }
        public int? _002materiaId { get; set; }
        public bool? _042activo { get; set; }

        public virtual _002materia _002materia { get; set; }
        public virtual _043coloresCaratula _043colorCaratula { get; set; }
        public virtual ICollection<_046tramite> _046tramites { get; set; }
    }
}
