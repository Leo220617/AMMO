using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Models
{
    public class AdjuntosViewModel
    {
        public int id { get; set; }
        public int idEncabezado { get; set; }
        public string Tipo { get; set; }
        public string Base64 { get; set; }
        public string base64Img { get; set; }
        public bool Firma { get; set; }
    }
}
