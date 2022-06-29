using Castle.MicroKernel.SubSystems.Conversion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Models
{
    public class DestinosViewModel
    {
        public int id { get; set; }

        public int? idRuta { get; set; }

        [StringLength(100)]
        public string Nombre { get; set; }

        [StringLength(5000)]
        public string Latitud { get; set; }

        [StringLength(5000)]
        public string Longitud { get; set; }

        [Column(TypeName = "money")]
        public decimal? Precio { get; set; }
    }
}
