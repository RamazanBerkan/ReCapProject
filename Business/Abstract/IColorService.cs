﻿using System;
using System.Collections.Generic;

using System.Text;

using DataAccess.Abstract;

using Entities.Concrete;

namespace Business.Abstract
{
    
    public interface IColorService
    {
        List<Color> GetAll();
        List<Color> GetById(int id);
        void Add(Color color );
        void Delete(Color color);
        void Update(Color color);


    }
}