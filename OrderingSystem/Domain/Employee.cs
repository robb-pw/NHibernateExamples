namespace OrderingSystem.Domain
{
    public class Employee : Entity<Employee>
    {
        public Name Name { get; private set; }
    }
}