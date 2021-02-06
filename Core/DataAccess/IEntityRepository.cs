using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
//core katmanı başka katmanlardan referans almaz
namespace Core.DataAccess
{
    //generic constraint
    // class : referans tip olabilsir
    //IEntity : IEntity olabilir yada IEntity implemente eden bir nesne olabilir
    //new() : new'lenebilir olmalı
    public interface IEntityRepository<T> where T:class,IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter = null);//filtreli data getirir mesela ID ye göre getir
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
