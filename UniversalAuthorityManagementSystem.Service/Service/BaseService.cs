using UniversalAuthorityManagement.Models.DBEntities;
using UniversalAuthorityManagement.Service.Interface;

namespace UniversalAuthorityManagement.Service.Service
{
    public class BaseService<T> : IService<T> where T : class
    {
        protected UniversalAuthorityManagementContext _dbContext;
        public BaseService(UniversalAuthorityManagementContext dbContext)
        {
            _dbContext = dbContext;
        }
        public bool Create(T t)
        {
            _dbContext.Add(t);
            return SaveChange();
        }

        public bool Update(T t)
        {
            _dbContext.Update(t);
            return SaveChange();
        }

        public bool Delete(T t)
        {
            _dbContext.Remove(t);
            return SaveChange();
        }

        public bool SaveChange()
        {
            return (_dbContext.SaveChanges() >= 0);
        }

        public T GetSingle(int id)
        {
            return _dbContext.Find<T>(id);
        }
    }
}
