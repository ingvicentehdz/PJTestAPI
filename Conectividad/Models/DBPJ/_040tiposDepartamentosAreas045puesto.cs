using System;
using System.Collections.Generic;

#nullable disable

namespace Conectividad.Models.DBPJ
{
    public partial class _040tiposDepartamentosAreas045puesto
    {
        public int _040tipoDepartamentoAreaId { get; set; }
        public int _045puestoId { get; set; }

        public virtual _040tiposDepartamentosArea _040tipoDepartamentoArea { get; set; }
        public virtual _045puesto _045puesto { get; set; }
    }
}
