var list = new List<int>() { 1, 5, 8, 12, 15, 20 };
var result = (from l in list
    where l % 2 != 0
    select l).Sum();
Console.WriteLine(result);