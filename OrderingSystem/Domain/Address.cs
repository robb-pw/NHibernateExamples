namespace OrderingSystem.Domain
{
    public class Address
    {
        public string Line1 { get; private set; }
        public string Line2 { get; private set; }
        public string ZipCode { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }

        public bool Equals(Address other)
        {
            if (ReferenceEquals(this, other)) return true;
            return Equals(other.Line1, Line1) &&
            Equals(other.Line2, Line2) &&
            Equals(other.ZipCode, ZipCode) &&
            Equals(other.City, City) &&
            Equals(other.State, State);
        }
        public override bool Equals(object obj)
        {
            return Equals(obj as Address);
        }
        public override int GetHashCode()
        {
            unchecked
            {
                var result = Line1.GetHashCode();
                result = (result * 397) ^ (Line2 != null ? Line2.GetHashCode() : 0);
                result = (result * 397) ^ ZipCode.GetHashCode();
                result = (result * 397) ^ City.GetHashCode();
                result = (result * 397) ^ State.GetHashCode();
                return result;
            }
        }
    }
}