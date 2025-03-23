namespace KnapSoft.Models.ViewModels
{
    public class ProductCheckbox
    {
        public int ProductId { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool IsSelected { get; set; }
    }
}