using System;
using System.Collections.Generic;

#nullable disable

namespace Conectividad.Models.DBPJ
{
    public partial class _009partidosJudiciale
    {
        public _009partidosJudiciale()
        {
            _001areas = new HashSet<_001area>();
            _010municipios = new HashSet<_010municipio>();
            _020salas = new HashSet<_020sala>();
        }

        public int _009partidoJudicialId { get; set; }
        public string _009nombre { get; set; }
        public bool _009activo { get; set; }

        public virtual ICollection<_001area> _001areas { get; set; }
        public virtual ICollection<_010municipio> _010municipios { get; set; }
        public virtual ICollection<_020sala> _020salas { get; set; }
    }
}
