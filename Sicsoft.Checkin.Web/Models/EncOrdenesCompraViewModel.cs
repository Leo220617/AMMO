using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Models
{
    public class EncOrdenesCompraViewModel
    {
        public int id { get; set; }
        public int idUsuarioAsignado { get; set; }
        public string CodigoProveedor { get; set; }
        public string NombreProveedor { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaRecibir { get; set; }
        public DateTime FechaRecibido { get; set; }
        public string Series { get; set; }
        public string DocNum { get; set; }
        public string Estado { get; set; }
        public string Status { get; set; }
        public int CantidadLineas { get; set; }
        public string Comentarios { get; set; }
        public bool Generar { get; set; }
        public bool procesadaSAP { get; set; }
        public string DocNumEntrega { get; set; }
        public List<DetOrdenesCompraViewModel> Detalle { get; set; }
        public List<AdjuntosViewModel> Adjuntos { get; set; }
        public List<LotesViewModel> Lotes { get; set; }
    }
}
