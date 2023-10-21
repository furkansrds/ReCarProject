using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(),Messages.RentalListed);
        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(re => re.RentalId == id));
        }

        public IResult RentTheCar(Rental rental)
        {
            var result = _rentalDal.Get(r => r.CarId == rental.CarId && r.ReturnDate == default);
            if (result == null)
            {
                _rentalDal.Add(rental);
                return new SuccessResult(rental.CarId + " : Araç kiralandı");
            }
            else
            {
                return new ErrorResult(rental.CarId + " : Araç kiralamaya uygun değil");
            }
        }

        public IResult ReturnTheCar(int id)
        {
            var result = _rentalDal.Get(r => r.CarId == id && r.ReturnDate == default);
            if (result != null)
            {
                result.ReturnDate = DateTime.Now;
                _rentalDal.Update(result);
                return new SuccessResult(result.CarId + " : Araç iade işlemi yapıldı.");
            }
            else
            {
                return new ErrorResult(result.CarId + " : Araba zaten elinizin altında.");
            }
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }
    }
}
