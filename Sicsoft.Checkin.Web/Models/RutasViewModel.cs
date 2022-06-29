using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Models
{
    public class RutasViewModel
    {
        public int id { get; set; }

        public int? idFlotilla { get; set; }

        [StringLength(100)]
        public string Nombre { get; set; }

        [StringLength(100)]
        public string Origen { get; set; }

        [Column(TypeName = "money")]
        public decimal? Costos { get; set; }

        [Column(TypeName = "money")]
        public decimal? Km { get; set; }
    }
}
