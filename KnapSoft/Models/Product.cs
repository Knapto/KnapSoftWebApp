using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace KnapSoft.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Column(TypeName = "longtext")]
        public string Name { get; set; } = string.Empty;
        [Column(TypeName = "longtext")]
        public string Description { get; set; } = string.Empty;
        [Column(TypeName = "longtext")]
        public string LargeDescription { get; set; } = string.Empty;
        public decimal Price { get; set; }

        [ValidateNever]
        public ICollection<SolutionProduct> SolutionProducts { get; set; } = new List<SolutionProduct>();
    }
}
