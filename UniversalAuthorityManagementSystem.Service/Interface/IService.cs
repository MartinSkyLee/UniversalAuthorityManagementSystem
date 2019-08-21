using System;
using System.Collections.Generic;
using System.Text;

namespace UniversalAuthorityManagement.Service.Interface
{
    public interface IService<T>
    {
        bool Create(T t);

        bool Update(T t);

        bool Delete(T t);

        bool SaveChange();

        T GetSingle(int id);

        bool IsSpuerAdministrator(int userId);

        bool IsSystemAdmin(int userId, int appId);

        bool IsSystemAdmin(int userId);
    }
}
