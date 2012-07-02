﻿namespace Chapter2
{
    public class Product
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual Category Category { get; set; }
        public virtual decimal UnitPrice { get; set; }
        public virtual int ReorderLevel { get; set; }
        public virtual bool Discountinued { get; set; }
    }
}