using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Models
{
    public class LotesViewModel
    {
        public int id { get; set; }
        public int idEncabezado { get; set; }
        public string Tipo { get; set; }
        public string Lote { get; set; }
        public string ItemCode { get; set; }
        public int Cantidad { get; set; }
    }
}
