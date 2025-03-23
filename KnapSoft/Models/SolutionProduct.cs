using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.CodeAnalysis;

namespace KnapSoft.Models
{
    public class SolutionProduct
    {
        [ValidateNever]
        public int SolutionId { get; set; }
        [ValidateNever]
        public KnapSoft.Models.Solution Solution { get; set; } = default!;

        [ValidateNever]
        public int ProductId { get; set; }
        [ValidateNever]
        public Product Product { get; set; } = default!;
    }
}