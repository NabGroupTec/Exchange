namespace Exchange.Domain.Entities
{
    public class PerlerDocuments : BaseEntity
    {
        public string Title { get; set; }
        public BankAccount BankAccount { get; set; }
        public int BankId { get; set; }
    }
}