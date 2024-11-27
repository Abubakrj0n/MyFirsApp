// See https://aka.ms/new-console-template for more information

var day = Int32.Parse(Console.ReadLine());
var moth = Int32.Parse(Console.ReadLine());
int daysInMonth = 0;
switch (moth)
{
    case 1:case 3:case 5 :case 7:case 8:case 10:case 12:
        daysInMonth = 31; break;
    case 4: case 6:case 9: case 11:
        daysInMonth = 30;break;
    case 2:
        daysInMonth = 28;break;
    default:
        Console.WriteLine("Invalid month");
        return;
        
}

if (day < daysInMonth)
{
    day += 1;
}
else
{
    day = 1;
    moth += 1;
    if (moth>12)
    {
        moth = 1;
    }
}
Console.WriteLine($"Слейдуший день {day+ "." + moth}");