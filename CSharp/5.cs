// Что выведет следующий код? 

var funcs = new List<Func<int>>(); 
for (int i = 0; i < 3; i++) funcs.Add(() => i);
foreach (var f in funcs) Console.WriteLine(f());