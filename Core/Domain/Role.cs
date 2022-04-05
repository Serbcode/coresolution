namespace CoreSolution.Core.Domain
{
    #pragma warning disable CS8618
    public class Role
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public virtual ICollection<Employee> Employees {get; set;}
    }
    #pragma warning restore
}