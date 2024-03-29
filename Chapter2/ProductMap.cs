﻿namespace Chapter2
{
    using FluentNHibernate.Mapping;

    public class ProductMap : ClassMap<Product>
    {
        public ProductMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Description);
            Map(x => x.UnitPrice);
            Map(x => x.ReorderLevel);
            Map(x => x.Discountinued);
            References(x => x.Category);
        }
    }
}