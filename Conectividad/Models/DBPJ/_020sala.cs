using System;
using System.Collections.Generic;

#nullable disable

namespace Conectividad.Models.DBPJ
{
    public partial class _020sala
    {
        public int _020salaId { get; set; }
        public string _020nombre { get; set; }
        public int? _009partidoJudicialId { get; set; }
        public int? _001areaId { get; set; }
        public bool _020activo { get; set; }
        public string _020ip { get; set; }
        public string _020ipdeTransmision { get; set; }
        public string _020puertoDeGrabacion { get; set; }
        public string _020puertoDeFinalizacion { get; set; }

        public virtual _001area _001area { get; set; }
        public virtual _009partidosJudiciale _009partidoJudicial { get; set; }
    }
}
