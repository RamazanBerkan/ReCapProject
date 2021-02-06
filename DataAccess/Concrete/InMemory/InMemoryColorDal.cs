using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

using DataAccess.Abstract;

using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryColorDal : IColorDal
    {
        List<Color> _color;

        public InMemoryColorDal()
        {
            _color = new List<Color>
            {
                new Color{Id=1, ColorName="Gold",Price=510, Description="Mat"},
                new Color{Id=2, ColorName="White",Price=400, Description="Shiny"},
                new Color{Id=3, ColorName="Black",Price=465, Description="Mat"},

            };
        }

        public void Add(Color color)
        {
            _color.Add(color);
        }

        public void Delete(Color color)
        {
            Color deleteToColor= _color.SingleOrDefault(p => p.Id == color.Id);
            _color.Remove(deleteToColor);

        }

        public Color Get(Expression<Func<Color, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public List<Color> GetAll()
        {
            return _color;
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public List<Color> GetById(int id)
        {
            return _color.Where(p => p.Id == id).ToList();

        }

        public void Update(Color color)
        {
            Color updateColor = _color.SingleOrDefault(p => p.Id == color.Id);
            updateColor.ColorName = color.ColorName;
            updateColor.Description = color.Description;
            updateColor.Price = color.Price;
        }
    }
}
