﻿using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //interface'in operasyonları public
    public interface IProductDal:IEntityRepository<Product>
    {
        
    }
}

//code refactoring