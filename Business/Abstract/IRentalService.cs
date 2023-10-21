using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService 
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<Rental> GetById(int id);
        IResult RentTheCar(Rental rental);
        IResult ReturnTheCar(int id);
        IResult Delete(Rental rental);
        IResult Update(Rental rental);
    }
}
