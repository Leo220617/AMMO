using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WMS.Models
{
    public class ChoferesViewModel
    {
        public int id { get; set; }

        [StringLength(150)]
        public string Nombre { get; set; }

        [StringLength(15)]
        public string Cedula { get; set; }

        [StringLength(15)]
        public string Telefono { get; set; }

        public string Foto { get; set; }

        [StringLength(1)]
        public string Estado { get; set; }
        public string base64 { get; set; }
    }
}
