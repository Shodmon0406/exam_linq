var employees = new List<Employee>
{
    new Employee { Name = "Alice", Department = "Sales", Salary = 50000
    },
    new Employee { Name = "Bob", Department = "IT", Salary = 60000 },
    new Employee { Name = "Charlie", Department = "Sales", Salary = 55000 },
    new Employee { Name = "Dave", Department = "IT", Salary = 65000 },
    new Employee { Name = "Eve", Department = "HR", Salary = 45000 }
};

var result = (from e in employees
    group e by e.Department
    into d
    select new
    {
        Department = d.Key,
        Count = d.Average(employee => employee.Salary)
    }).ToList();
result.ForEach(Console.WriteLine);