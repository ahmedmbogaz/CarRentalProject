using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public class EfEntityRepositoryBase<TEntity,TContext>:IEntityRepository<TEntity>
        where TEntity:class,IEntity, new()
        where TContext:DbContext,new()
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext()) //context ağır bir şey oldugu için bunu yaparız ve garbac kollekter
                                                                      //hemen siler (personmanslı olur)
            {
                var addedEntity = context.Entry(entity); // referansı yakala
                addedEntity.State = EntityState.Added; // o aslında eklenecek bir nesne
                context.SaveChanges(); // ve şimdi ekle
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext()) //context ağır bir şey oldugu için bunu yaparız ve garbac kollekter
                                                                      //hemen siler (personmanslı olur)
            {
                var deletedEntity = context.Entry(entity); // referansı yakala
                deletedEntity.State = EntityState.Deleted; // o aslında eklenecek bir nesne
                context.SaveChanges(); // ve şimdi ekle
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().FirstOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext()) // buraya ne yazarsak yazalım bize datayı getirecek
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public List<TEntity> GetById(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext()) //context ağır bir şey oldugu için bunu yaparız ve garbac kollekter
                                                                      //hemen siler (personmanslı olur)
            {
                var updatedEntity = context.Entry(entity); // referansı yakala
                updatedEntity.State = EntityState.Modified; // o aslında eklenecek bir nesne
                context.SaveChanges(); // ve şimdi ekle
            }
        }
    }
}
