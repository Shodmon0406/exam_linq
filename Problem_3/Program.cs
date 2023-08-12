var list = new List<string>() { "Alice", "Anny", "Amy", "Dave", "Alex" };
var result = (from l in list
    where l.StartsWith("A") && l.EndsWith("A")
    select l).ToList();
result.ForEach(Console.WriteLine);