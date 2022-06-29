using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Models
{
    public class DetOrdenesCompraViewModel
    {
        public int id { get; set; }
        public int idEncabezado { get; set; }
        public int NumLinea { get; set; }
        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public decimal Cantidad { get; set; }
        public decimal CantidadRecibido { get; set; }
        public string Ubicacion { get; set; }
    }
}
