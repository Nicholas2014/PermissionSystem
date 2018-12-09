using System;
using System.ComponentModel;

namespace PermissionSystem.Core.Enums
{
    [Flags]
    [Description("资源默认动作")]
    public enum DefaultAction
    {
        [Description("浏览")]
        View = 1,
        [Description("新建")]
        Create = 2,
        [Description("编辑")]
        Edit = 4,
        [Description("删除")]
        Delete = 8
    }
}