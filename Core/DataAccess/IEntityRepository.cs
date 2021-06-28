using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks; 

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T:class,IEntity,new() /*Burada generic constraint kullanılmıştır.
                                                                 * Bu sayede T yerine yalnızca IEntity arayüzünü implemente
                                                                 * etmiş sınıflar gelebilir.IEntity de gelebilir di normalde.
                                                                 * Bunun önüne geçebilmek için de new() ifadesi filtreye eklenmiştir.
                                                                 * Bu sayede T yalnızca IEntity arayüzünü implemente etmiş new'lenebilir objelerdir.*/
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);//Buradaki null ifadesi bu çağırma işleminin
        //filtre vermeden de çalışabilmesini sağlar.
        /*Yukarıda bulunan kodda expression denilen yapı kullanılmıştır.Bu yapı sayesinde Business
         * katmanında bulunan PlaceManager içerisindeki List<T> GetAll() fonksiyonunun parantezleri içerisine
         * linq sorgusu yazarak filtreli ürün listeleyebiliyoruz.İşte puanı bilmem ne olan,kategorisi bir şey
         olan şeklinde...*/
        T Get(Expression<Func<T, bool>> filter);//Buradaki filter ifadesinde null yazmıyor bunun sebebi
        //bu ifadenin filtre vermeden kullanılamayacak olmasıdır.
        /*Yukarıdaki kod satırı tek bir nesnenin detaylarına gitmek için kullanılır.
         *Mesela bir mekanın detayları gibi...  
         */
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
