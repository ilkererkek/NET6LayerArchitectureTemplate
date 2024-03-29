﻿using Entity.Abstract.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete.Entity
{
    public class BaseEntity : IEntity
    {
        public BaseEntity()
        {
            Id = new Guid();
            CreatedAt = DateTime.UtcNow.AddHours(3);
            UpdatedAt = DateTime.UtcNow.AddHours(3);
        }

        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
