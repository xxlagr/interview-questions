// Что выведет следующий код?

class Program 
{ 
    struct S1 { public int X; }
    static void Main(string[] args)
    {
        var arr = new S1[] { new S1 { X = 1 } };
        arr[0].X++;
        Console.WriteLine(arr[0].X);

        var lst = new List<S1> { new S1 { X = 1 } };
        lst[0].X++;
        Console.WriteLine(lst[0].X);
    }
}