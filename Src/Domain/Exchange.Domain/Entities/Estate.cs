namespace Exchange.Domain.Entities
{
    public class Estate : BaseEntity
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
    }
}