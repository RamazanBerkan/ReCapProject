using System;
using System.Collections.Generic;
using System.Text;

using Core.Entities;

namespace Entities.Concrete
{
   public class Color :IEntity
    {
        public int Id { get; set; }
        public string ColorName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}
