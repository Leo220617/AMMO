using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Models
{
    public class ListasCorreosViewModel
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public List<DetListaCorreoViewModel> Detalle { get; set; }
    }
}
