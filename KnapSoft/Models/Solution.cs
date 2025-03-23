using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace KnapSoft.Models
{
    public class Solution
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string LargeDescription { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public decimal MonthlyPrice { get; set; }

        [ValidateNever]
        public ICollection<SolutionProduct> SolutionProducts { get; set; } = new List<SolutionProduct>();
    }
}