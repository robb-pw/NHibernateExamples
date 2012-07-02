namespace OrderingSystem.Domain
{
    public class LineItem : Entity<LineItem>
    {
        public Order Order { get; private set; }
        public Product Product { get; private set; }
        public int Quantity { get; private set; }
        public decimal UnitPrice { get; private set; }
        public decimal Discount { get; private set; }

        public LineItem(Order order, int quantity, Product product)
        {
            Order = order;
            Quantity = quantity;
            Product = product;
            UnitPrice = product.UnitPrice;

            if (quantity >= 10)
                Discount = 0.5m;
        }
    }
}