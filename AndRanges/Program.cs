//temp <= 0 -freezing cold
// > 0 < 10 -cold
// >= 10 < 15 -chilly
// >= 15 < 20 -warm
// >= 20 < 30 -hot
// >0 30 - boiling hot


Console.WriteLine("Please, enter the temperature:");
int temp = Int32.Parse(Console.ReadLine());

if (temp > 30) 
{
    Console.WriteLine("Boiling hot!");
}  
else if (temp < 30 && temp >= 20) 
{
    Console.WriteLine("Hot!");
}
else if (temp < 20 && temp >= 15) 
{
    Console.WriteLine("Warm!");
}
else if (temp < 15 && temp >= 10) 
{
    Console.WriteLine("Chilly!");
}
else if (temp < 10 && temp > 0) 
{
    Console.WriteLine("Cold!");
}
else if (temp < 0) 
{
    Console.WriteLine("Freezing cold!");
}