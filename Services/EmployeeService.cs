namespace DevNetCore.Services
{
    using DevNetCore.Interfaces;
    using DevNetCore.Models;
    public class EmployeeService : IEmployeeService
    {
        public List<Employee> Employees()
        {
            return new List<Employee>()
            {
                new Employee()
                {
                    Id = 123,
                    Name = "Lionel",
                    Age = 35,

                },

                new Employee()
                {
                    Id = 456,
                    Name = "Cristiano",
                    Age = 37
                },

                new Employee()
                {
                    Id = 789,
                    Name = "Iniesta",
                    Age = 40
                },

                new Employee()
                {
                    Id = 987,
                    Name = "Xavi",
                    Age = 43
                },

                new Employee()
                {
                    Id = 654,
                    Name = "Busquets",
                    Age = 39
                },

                new Employee()
                {
                    Id = 321,
                    Name = "Ramos",
                    Age = 41
                },

                new Employee()
                {
                    Id = 012,
                    Name = "Rooney",
                    Age = 42
                },

                new Employee()
                {
                    Id = 345,
                    Name = "Puyol",
                    Age = 46
                },

                new Employee()
                {
                    Id = 678,
                    Name = "Bruno",
                    Age = 29
                },

                new Employee()
                {
                    Id = 876,
                    Name = "Haaland",
                    Age = 24
                },

                new Employee()
                {
                    Id = 543,
                    Name = "Mbappe",
                    Age = 23
                },

                new Employee()
                {
                    Id = 210,
                    Name = "Neymar",
                    Age = 31
                }
            };
        }
    }
}
