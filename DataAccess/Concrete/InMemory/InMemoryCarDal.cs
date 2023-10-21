using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId = 1, BrandId =1 , ColorId = 1 ,CarName = "BMW" , DailyPrice = 500 , ModelYear = DateTime.Now , Description = "null"},
                new Car{CarId = 2, BrandId =1 , ColorId = 2 ,CarName = "Mercedes" ,DailyPrice = 500 , ModelYear = DateTime.Now , Description = "null"},
                new Car{CarId = 3, BrandId =2 , ColorId = 1 ,CarName = "Ford", DailyPrice = 400 , ModelYear = DateTime.Now , Description = "null"},
                new Car{CarId = 4, BrandId =3 , ColorId = 2,CarName = "Fiat", DailyPrice = 1200 , ModelYear = DateTime.Now , Description = "null"},
            };
        }


        public void Add(Car car)
        {
            if (car != null)
            {
                _cars.Add(car);
            }
        }

        public void Delete(Car car)
        {
            Car carDelete = _cars.FirstOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public List<Car> GetAllByCategory(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }

        public Car GetById(int id)
        {
            return _cars.FirstOrDefault(c => c.CarId == id);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carUpdate.BrandId = car.BrandId;
            carUpdate.ColorId = car.ColorId;
            carUpdate.DailyPrice = car.DailyPrice;
            carUpdate.Description = car.Description;
        }
    }
}
