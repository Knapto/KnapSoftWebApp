namespace KnapSoft.Models.ViewModels
{
    public class SolutionViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public decimal MonthlyPrice { get; set; }

        public List<ProductCheckbox> Products { get; set; } = new();
    }
}
