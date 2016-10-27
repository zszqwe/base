﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Conan.Model;

namespace Conan.DAL
{
    public class OrderExtMapping : EntityTypeConfiguration<OrderExt>
    {
        public OrderExtMapping()
        {
            HasKey(c => c.Id);
            Property(c => c.Id).IsRequired();
            ToTable("OrderExt");
        }
    }
}
