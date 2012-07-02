namespace OrderingSystem.Domain
{
    using System;

    public abstract class Entity<T> where T : Entity<T>
    {
        private int? oldHashCode;

        public Guid Id { get; private set; }

        public override bool Equals(object obj)
        {
            var other = obj as T;
            if (other == null) return false;

            var thisIsNew = Equals(Id, Guid.Empty);
            var otherIsNew = Equals(other.Id, Guid.Empty);

            if (thisIsNew && otherIsNew)
                return ReferenceEquals(this, other);

            return Id.Equals(other.Id);
        }

        public override int GetHashCode()
        {
            if (oldHashCode.HasValue)
                return oldHashCode.Value;

            var thisIsNew = Equals(Id, Guid.Empty);
            if (thisIsNew)
            {
                oldHashCode = base.GetHashCode();
                return oldHashCode.Value;
            }

            return Id.GetHashCode();
        }

        public static bool operator ==(Entity<T> lhs, Entity<T> rhs)
        {
            return Equals(lhs, rhs);
        }

        public static bool operator !=(Entity<T> lhs, Entity<T> rhs)
        {
            return !Equals(lhs, rhs);
        }
    }
}