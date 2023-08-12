var list = new List<int>() { 5, 8, 12, 15, 20, 25, 30 };
var result = (from l in list
    orderby l descending
    select l).Take(3).ToList();
result.ForEach(Console.WriteLine);