using System.Collections.Generic;

namespace PermissionSystem.Interfaces
{
    public interface ICommonService<T>
    {
        int Create(T entity);
        bool Edit(T entity);
        bool Delete(int id);
        List<T> GetListByPage(string condition, out int total, int pageIndex = 1, int pageSize = 10);
    }
}