namespace OrderingSystem.Domain
{
    using System.Collections.Generic;

    public class Customer : Entity<Customer>
    {
        private readonly List<Order> orders;
        public string CustomerIdentifier { get; private set; }
        public Name CustomerName { get; private set; }
        public Address Address { get; private set; }
        public IEnumerable<Order> Orders { get { return orders; } } 


        public void ChangeCustomerName(string firstName, string middleName, string lastName)
        {
            CustomerName = new Name(firstName, middleName, lastName);
        }
        public void PlaceOrder(LineInfo[] lineInfos, IDictionary<int, Product> products)
        {
            var order = new Order(this);
            foreach(var lineInfo in lineInfos)
            {
                var product = products[lineInfo.ProductId];
                order.AddProduct(this, product, lineInfo.Quantity);
            }

            orders.Add(order);
        }
    }
}