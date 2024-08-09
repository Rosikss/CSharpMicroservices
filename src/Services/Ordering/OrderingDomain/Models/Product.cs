using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderingDomain.Abstractions;

namespace OrderingDomain.Models
{
    public class Product : Entity<Guid>
    {
        public string Name { get; private set; } = default!;
        public decimal Price { get; private set; } = default!;

    }
}
