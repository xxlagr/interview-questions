// Что выведет следующий код?
static void Main(string[] args)
{
  var names = Generate();

  foreach (var name in names)
  {
    Console.WriteLine(name);
  }
  
  foreach (var name in names.Select(x => x.ToUpper()))
  {
    Console.WriteLine(name);
  }
}

private static IEnumerable<string> Generate()
{
  Console.WriteLine("Generating names");
  yield return "john";
  yield return "bob";
}