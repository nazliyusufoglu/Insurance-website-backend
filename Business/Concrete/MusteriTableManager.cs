using Business.Abstract;
using Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;
using Business.Contents;

namespace Business.Concrete
{
    public class MusteriTableManager : IMusteriTableService
    {
        private IMusteriTableDal _musteritableDal;

        public MusteriTableManager(IMusteriTableDal musteriTableDal)
        {
            _musteritableDal = musteriTableDal;
        }

        public IResult Add(MusteriTable musteriTable)
        {
            _musteritableDal.Add(musteriTable);
            return new SuccessResult(Messages.MusteriAdded);
        }

        public IResult Delete(MusteriTable musteriTable)
        {
            _musteritableDal.Delete(musteriTable);
            return new SuccessResult(Messages.MusteriDeleted);
        }

        public IDataResult<MusteriTable> GetByTCKN(string TCKN)
        {
            return new SuccessDataResult<MusteriTable>(_musteritableDal.Get(p => p.TCKN == TCKN));
        }

        public IDataResult<List<MusteriTable>> GetList()
        {
            return new SuccessDataResult<List<MusteriTable>>(_musteritableDal.GetList().ToList());
        }

        public IDataResult<List<MusteriTable>> GetListByTCKN(string TCKN)
        {
            return new SuccessDataResult<List<MusteriTable>>(_musteritableDal.GetList(p => p.TCKN == TCKN).ToList());
        }

        public IResult Update(MusteriTable musteriTable)
        {
            _musteritableDal.Update(musteriTable);
            return new SuccessResult(Messages.MusteriUpdated);
        }
    }
}