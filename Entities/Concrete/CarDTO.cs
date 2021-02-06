using System;
using System.Collections.Generic;
using System.Text;

using Entities.Abstract;

namespace Entities.Concrete
{
   public class CarDTO:IEntity
    {
        public int CarModelYear { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }

    }
}
