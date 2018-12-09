using System.Collections.Generic;

namespace PermissionSystem.Interfaces
{
    public interface IRoleService
    {
        /// <summary>
        /// 向指定角色添加用户
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="userIds"></param>
        /// <returns></returns>
        bool AddUsers(int roleId, List<int> userIds);
    }
}