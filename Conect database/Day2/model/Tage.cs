using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conect_data_base.model
{
    internal class Tage
    {
        public int id { get; set; }
        public int discription { get; set; }
        public string name { get; set; }

        [ForeignKey("ProductId")]
        public int ProductId { get; set; }


    } 
}
