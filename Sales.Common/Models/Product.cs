
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Common.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class Product
    {
        //para claves primarios
        [Key]
        public int ProductoID { get; set; }
        [Required]
        public string Descripcion { get; set; }
        public Decimal Price { get; set; }
        public bool IsAvailable { get; set; }
        //Es para mostrar la hora de acuerdo al pais
        public DateTime PublishOn { get; set; }
    }
}
