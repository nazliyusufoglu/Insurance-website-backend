﻿using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using Entities.Concrete;


namespace DataAccess.Abstract
{
    public interface IMusteriTableDal : IEntityRepository<MusteriTable>
    {
    }
}
