using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace KnapSoft.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }

        [ValidateNever]
        public ICollection<SolutionProduct> SolutionProducts { get; set; } = new List<SolutionProduct>();
    }
}
