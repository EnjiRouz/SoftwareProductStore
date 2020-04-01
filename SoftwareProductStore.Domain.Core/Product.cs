namespace SoftwareProductStore.Domain.Core
{
    /// <summary>
    /// Продукт, выставленный на продажу
    /// Имеет уникальный идентификатор, имя и цену
    /// </summary>
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}