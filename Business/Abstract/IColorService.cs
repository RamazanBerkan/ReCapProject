using System;
using System.Collections.Generic;

using System.Text;

using DataAccess.Abstract;

using Entities.Concrete;

namespace Business.Abstract
{
    
    public interface IColorService:IEntityService<Color>
    {

        Color GetClor(int id);

    }
}
