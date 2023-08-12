﻿List<Person> people = new List<Person>
{
    new Person { Name = "Alice", Age = 20 },
    new Person { Name = "Bob", Age = 30 },
    new Person { Name = "Charlie", Age = 20 },
    new Person { Name = "Dave", Age = 30 },
    new Person { Name = "Eve", Age = 20 }
};

var result = (from p in people
    group p by p.Age
    into age
    select new
    {
        Age = age.Key,
        Count = age.Count()
    }).ToList();
result.ForEach(Console.WriteLine);