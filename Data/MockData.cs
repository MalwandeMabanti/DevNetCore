using DevNetCore.Models;

namespace DevNetCore.Data
{
    public static class MockData
    {
        public static List<Employee> Employees()
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
                }
            };
        }
    }
}
