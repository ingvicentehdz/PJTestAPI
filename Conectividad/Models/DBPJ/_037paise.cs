using System;
using System.Collections.Generic;

#nullable disable

namespace Conectividad.Models.DBPJ
{
    public partial class _037paise
    {
        public _037paise()
        {
            _011entidadesFederativas = new HashSet<_011entidadesFederativa>();
        }

        public int _037paisId { get; set; }
        public string _037nombre { get; set; }
        public string _037codigo { get; set; }
        public bool _037activo { get; set; }
        public string _037gentilicioMasculino { get; set; }
        public string _037gentilicioFemenino { get; set; }

        public virtual ICollection<_011entidadesFederativa> _011entidadesFederativas { get; set; }
    }
}
