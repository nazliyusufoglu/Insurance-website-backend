using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface IMusteriTableService
    {
        IDataResult<MusteriTable> GetByTCKN(string TCKN);
        IDataResult<List<MusteriTable>> GetList();
        IDataResult<List<MusteriTable>>GetListByTCKN(string TCKN);
        IResult Add(MusteriTable MusteriTable);
        IResult Delete(MusteriTable MusteriTable);
        IResult Update(MusteriTable MusteriTable);
    }
}
