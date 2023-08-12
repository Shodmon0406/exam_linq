var list = new List<string>() { "apple", "banana", "cherry", "date", "elderberry" };
var result = (from l in list
    orderby l.Length descending 
    select l).ToList();
result.ForEach(Console.WriteLine);