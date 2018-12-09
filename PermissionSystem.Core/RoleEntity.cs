using System;
using Dapper.Contrib.Extensions;

namespace PermissionSystem.Core
{
    [Dapper.Contrib.Extensions.Table("Base_Role")]
    public class RoleEntity
    {
        public RoleEntity()
        {
            this.CreateDate = DateTime.Now;
            this.ModifyDate = DateTime.Now;
            this.IsValid = true;
        }
        [ExplicitKey]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Creator { get; set; }
        public DateTime CreateDate { get; set; }
        public int Modifier { get; set; }
        public DateTime? ModifyDate { get; set; }
        public bool IsValid { get; set; }
    }
}
