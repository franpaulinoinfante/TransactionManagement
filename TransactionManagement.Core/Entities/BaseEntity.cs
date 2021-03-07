﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionManagement.Core.Entities
{
    public class BaseEntity<Tkey>
    {
        public Tkey Id { get; private set; }

        public BaseEntity(Tkey id)
        {
            Id = id;
        }
    }
}
