using System;
using System.Collections.Generic;

#nullable disable

namespace Conectividad.Models.DBPJ
{
    public partial class _001area
    {
        public _001area()
        {
            _001areas058tiposTocasOrales = new HashSet<_001areas058tiposTocasOrale>();
            _003areasMateria = new HashSet<_003areasMateria>();
            _020salas = new HashSet<_020sala>();
            _040tiposDepartamentosAreas = new HashSet<_040tiposDepartamentosArea>();
            _063areasSistemas = new HashSet<_063areasSistema>();
        }

        public int _001areaId { get; set; }
        public string _001nombre { get; set; }
        public string _001alias { get; set; }
        public string _001abreviatura { get; set; }
        public int? _001areaIdEquitas { get; set; }
        public int? _001areaIdMajat { get; set; }
        public int? _001areaEvaluacionesId { get; set; }
        public int? _001areaIdArchivo { get; set; }
        public int? _009partidoJudicialId { get; set; }
        public int? _010municipioId { get; set; }
        public bool _001activo { get; set; }
        public string _001correoElectronico { get; set; }

        public virtual _009partidosJudiciale _009partidoJudicial { get; set; }
        public virtual _010municipio _010municipio { get; set; }
        public virtual ICollection<_001areas058tiposTocasOrale> _001areas058tiposTocasOrales { get; set; }
        public virtual ICollection<_003areasMateria> _003areasMateria { get; set; }
        public virtual ICollection<_020sala> _020salas { get; set; }
        public virtual ICollection<_040tiposDepartamentosArea> _040tiposDepartamentosAreas { get; set; }
        public virtual ICollection<_063areasSistema> _063areasSistemas { get; set; }
    }
}
