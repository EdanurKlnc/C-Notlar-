

 for (int i = 0; i<10; i++) 
{
DateTime simdi = DateTime.Now;
Console.WriteLine(simdi.Hour.ToString(format:"00") + ":"+ simdi.Minute.ToString(format:"00") + ":"+ simdi.Second.ToString(format:"00"));
    Thread.Sleep(millisecondsTimeout: 1000);
Console.Clear();
    Console.WriteLine($"{simdi.Hour:00}:{simdi.Minute:00}:{simdi.Second:00}");
    Console.WriteLine($"{ simdi:dd:MM:yyyy- HH:mm:ss}");
    Thread.Sleep(millisecondsTimeout: 1000);
    Console.Clear();


 }




 




