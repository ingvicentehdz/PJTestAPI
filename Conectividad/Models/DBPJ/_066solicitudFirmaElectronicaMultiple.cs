using System;
using System.Collections.Generic;

#nullable disable

namespace Conectividad.Models.DBPJ
{
    public partial class _066solicitudFirmaElectronicaMultiple
    {
        public _066solicitudFirmaElectronicaMultiple()
        {
            _067usuariosFirmaElectronicaMultiples = new HashSet<_067usuariosFirmaElectronicaMultiple>();
        }

        public long _066multifirmaId { get; set; }
        public string _066descripcion { get; set; }
        public DateTime _066fechaDeSolicitud { get; set; }
        public string _066rutaDeDocumentoAfirmar { get; set; }
        public string _066rutaDeDocumentoFirmado { get; set; }
        public int? _066areaId { get; set; }

        public virtual ICollection<_067usuariosFirmaElectronicaMultiple> _067usuariosFirmaElectronicaMultiples { get; set; }
    }
}
