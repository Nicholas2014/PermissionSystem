using Dapper.Contrib.Extensions;
using PermissionSystem.Core;
using System;
using System.Linq;

namespace PermissionSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var s = 0x00;
                s = 0x01;


                ListRole();

                Console.WriteLine("===创建角色测试===\r\n输入角色名称：");
                var roleName = Console.ReadLine();
                CreateRole(roleName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.ReadKey();
        }

        static void CreateRole(string roleName)
        {
            using (var conn = DapperManager.GetConnection())
            {
                var maxId = 1;
                var role = new RoleEntity()
                {
                    Id = maxId,
                    Name = roleName
                };

                var roles = conn.GetAll<RoleEntity>().ToList();
                if (roles.Any())
                {
                    maxId = roles.Max(r => r.Id);
                    role.Id = maxId << 1;
                }

                conn.Insert(role);
                Console.WriteLine($"insert role: {roleName} => succeed!");
                ListRole();
            }
        }

        static void ListRole()
        {
            using (var conn = DapperManager.GetConnection())
            {
                foreach (var item in conn.GetAll<RoleEntity>())
                {
                    Console.WriteLine($"{item.Id,-10}{item.Name,-10}");
                }
            }
        }
    }
}
