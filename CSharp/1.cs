// Что выведет следующий код?

try
{  
	Console.WriteLine("In try");   
    throw new ApplicationException(); 
} 
catch
{  
	Console.WriteLine("In catch");
} 
finally
{   
	Console.WriteLine("In finally"); 
} 