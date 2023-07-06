using System;
using System.Collections.Generic;

#nullable disable

namespace Conectividad.Models.DBPJ
{
    public partial class _018telefono
    {
        public int _018telefonoId { get; set; }
        public string _018numero { get; set; }
        public string _018extension { get; set; }
        public int? _019tipoTelefonoId { get; set; }
        public int? _016domicilioId { get; set; }

        public virtual _016domicilio _016domicilio { get; set; }
        public virtual _019tiposTelefono _019tipoTelefono { get; set; }
    }
}
