using System;
using System.Collections.Generic;

#nullable disable

namespace Conectividad.Models.DBPJ
{
    public partial class _040tiposDepartamentosArea
    {
        public _040tiposDepartamentosArea()
        {
            _040tiposDepartamentosAreas045puestos = new HashSet<_040tiposDepartamentosAreas045puesto>();
        }

        public int _040tipoDepartamentoAreaId { get; set; }
        public int _001areaId { get; set; }
        public int? _039tipoDepartamentoId { get; set; }

        public virtual _001area _001area { get; set; }
        public virtual _039tiposDepartamento _039tipoDepartamento { get; set; }
        public virtual ICollection<_040tiposDepartamentosAreas045puesto> _040tiposDepartamentosAreas045puestos { get; set; }
    }
}
