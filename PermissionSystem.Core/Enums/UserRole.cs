using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermissionSystem.Core.Enums
{
    [Flags]
    [Description("用户角色")]
    public enum UserRole
    {
        [Description("学生")]
        Student = 1,
        [Description("老师")]
        Teacher = 2,
        [Description("家长")]
        Parent = 4,
        [Description("学校管理员")]
        SchoolAdmin = 0x10,
        [Description("教育局管理员")]
        EduAdmin = 0x11,
        [Description("系统管理员")]
        SysAdmin = 0x12
    }
}
