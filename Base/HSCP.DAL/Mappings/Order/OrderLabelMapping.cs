﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Conan.Model;

namespace Conan.DAL
{
    public class OrderLabelMapping : EntityTypeConfiguration<OrderLabel>
    {
        public OrderLabelMapping()
        {
            HasKey(c => c.Id);
            Property(c => c.Id).IsRequired();
            ToTable("OrderLabel");
        }
    }
}
