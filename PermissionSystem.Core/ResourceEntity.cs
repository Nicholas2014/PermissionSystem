namespace PermissionSystem.Core
{
    [Dapper.Contrib.Extensions.Table("Base_Resource")]
    public class ResourceEntity : EntityBase
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public int Order { get; set; }
        public int DefaultAction { get; set; }
        public bool DefaultActionOnly { get; set; }
    }
}
