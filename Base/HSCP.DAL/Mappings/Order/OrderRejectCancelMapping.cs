﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Conan.Model;

namespace Conan.DAL
{
    public class OrderRejectCancelMapping : EntityTypeConfiguration<OrderRejectCancel>
    {
        public OrderRejectCancelMapping()
        {
            HasKey(c => c.Id);
            Property(c => c.Id).IsRequired();
            ToTable("OrderRejectCancel");
        }
    }
}
