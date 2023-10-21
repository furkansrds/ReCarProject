using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car , CarContext>, ICarDal 
    {
       public List<CarDetailDto> GetCarDetails()
        {
            using (CarContext carContext = new CarContext())
            {
                var result = from c in carContext.Cars
                             join b in carContext.Brands
                             on c.CarId equals b.BrandId
                             join co in carContext.Colors
                             on c.ColorId equals co.ColorId
                             select new CarDetailDto()
                             {
                                 CarId = c.CarId,
                                 CarName = c.CarName,
                                 BrandName = b.BrandName,
                                 ColorName = co.ColorName,
                                 DailyPrice = c.DailyPrice
                             };
                return result.ToList();
            }
        }
    }
}
