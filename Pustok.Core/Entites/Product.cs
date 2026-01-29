using Pustok.Core.Entites.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pustok.Core.Entites
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }=string.Empty;
        public string Description { get; set; }=string.Empty;
        public string ImagePath { get; set; }=string.Empty;
        public decimal Price { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; } = null!;
    }
}
