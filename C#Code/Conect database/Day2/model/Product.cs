using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcademyShope.model
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? Description { get; set; }
        public int ProductId { get; set; }

        [ForeignKey(nameof(categoryId))]
        public Category category {get; set; }
        public int categoryId { get; set; }

        public string HasDiscount { get; set; }

        public int price { get; set; }
        public int quntity { get; set; }
    }
}
