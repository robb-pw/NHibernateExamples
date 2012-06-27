namespace Chapter2
{
    public class Product
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public decimal UnitPrice { get; set; }
        public int ReorderLevel { get; set; }
        public virtual bool Discountinued { get; set; }
    }
}