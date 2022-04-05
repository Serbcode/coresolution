using CoreSolution.Core.Domain;

namespace CoreSolution.DataAccess
{
    public static class FakeData
    {
        public static IEnumerable<Role> Roles {
            get {
                return new List<Role>() {
                    new Role() { RoleId = 1, RoleName = "Admin" },
                    new Role() { RoleId = 2, RoleName = "Partner" }
                };
            }
        }

        public static IEnumerable<Employee> Employees => new List<Employee>() 
        {
            new Employee() { 
                EmployeeId = 1,                
                FirstName = "Scott", 
                LastName = "Hanselmann", 
                Email = "scott@email.de", 
                Roles = Roles.Where(r => r.RoleId == 1).ToList()
            },
            new Employee() { 
                EmployeeId = 2,
                FirstName = "Andy", 
                LastName = "Irvine", 
                Email = "irvine@hotmail.com", 
                Roles = Roles.Where(r => r.RoleId == 2).ToList()
            }
        };

    }
}