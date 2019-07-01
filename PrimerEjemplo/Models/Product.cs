using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrimerEjemplo.Models
{
    public class Product
    {
        [Key]
        public int condigo { set; get; }
        public string nombre { set; get; }
        public string descripcion { set; get; }
        public decimal precio { set; get; }
        public DateTime ultimaCompra { set; get; }
        public int unidadesInventario { set; get; }
    }
}