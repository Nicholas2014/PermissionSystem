namespace PermissionSystem.Interfaces
{
    public interface IUserService
    {
        /// <summary>
        /// 给用户分配角色
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        bool AssignRoles(int userId);

    }
}