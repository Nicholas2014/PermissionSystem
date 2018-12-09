using System;

namespace PermissionSystem.Core
{
    public class EntityBase
    {
        public EntityBase()
        {
            this.CreateDate = DateTime.Now;
            this.ModifyDate = DateTime.Now;
            this.IsValid = true;
        }
        public int Id { get; set; }
        public int Creator { get; set; }
        public DateTime CreateDate { get; set; }
        public int Modifier { get; set; }
        public DateTime? ModifyDate { get; set; }
        public bool IsValid { get; set; }
    }
}
