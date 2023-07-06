using System;
using System.Collections.Generic;

#nullable disable

namespace Conectividad.Models.DBPJ
{
    public partial class _039tiposDepartamento
    {
        public _039tiposDepartamento()
        {
            _040tiposDepartamentosAreas = new HashSet<_040tiposDepartamentosArea>();
        }

        public int _039tipoDepartamentoId { get; set; }
        public string _039nombre { get; set; }
        public bool _039activo { get; set; }

        public virtual ICollection<_040tiposDepartamentosArea> _040tiposDepartamentosAreas { get; set; }
    }
}
