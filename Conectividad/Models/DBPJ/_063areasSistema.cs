using System;
using System.Collections.Generic;

#nullable disable

namespace Conectividad.Models.DBPJ
{
    public partial class _063areasSistema
    {
        public int _063areaSistemaId { get; set; }
        public int _001areaId { get; set; }
        public int _031sistemaId { get; set; }
        public bool _063activo { get; set; }
        public int? _063ordenArea { get; set; }

        public virtual _001area _001area { get; set; }
        public virtual _031sistema _031sistema { get; set; }
    }
}
