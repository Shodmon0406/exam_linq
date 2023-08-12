var list = new List<string>() { "Alice", "Anny", "Amy", "Dave", "Alex" };
var result = (from l in list
    where l.StartsWith("A") && l.EndsWith("A")
    select l).ToList();
result.ForEach(Console.WriteLine);

// metonistem ki rangi poyon knem neki sharty masala boloya talab kardest 
/*var list = new List<string>() { "Alice", "Anny", "Amy", "Dave", "Alex" };
var result = (from l in list
    where l.StartsWith("A") && l.ToUpper().EndsWith("A")
    select l).ToList();
result.ForEach(Console.WriteLine);*/
