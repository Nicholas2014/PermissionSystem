namespace PermissionSystem.Core
{
    [Dapper.Contrib.Extensions.Table("Base_Action")]
    public class ActionEntity : EntityBase
    {
        public int ResourceId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsEnable { get; set; }
    }
}
