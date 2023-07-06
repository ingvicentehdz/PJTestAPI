using System;
using System.Collections.Generic;

#nullable disable

namespace Conectividad.Models.DBPJ
{
    public partial class _031sistema
    {
        public _031sistema()
        {
            _063areasSistemas = new HashSet<_063areasSistema>();
        }

        public int _031sistemaId { get; set; }
        public string _031nombre { get; set; }
        public string _031abreviatura { get; set; }
        public string _031descripcion { get; set; }
        public int _032tipoSistemaId { get; set; }
        public int? _025baseDeDatosId { get; set; }
        public string _031rutaDeAcceso { get; set; }
        public bool? _031activo { get; set; }
        public bool _031puedeModificarseSusPermisos { get; set; }

        public virtual _025basesDeDato _025baseDeDatos { get; set; }
        public virtual _032tiposSistema _032tipoSistema { get; set; }
        public virtual ICollection<_063areasSistema> _063areasSistemas { get; set; }
    }
}
