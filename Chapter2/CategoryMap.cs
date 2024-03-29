﻿namespace Chapter2
{
    using FluentNHibernate.Mapping;

    public class CategoryMap : ClassMap<Category>
    {
        public CategoryMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Description);
        }
    }
}