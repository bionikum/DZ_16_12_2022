// По целочисленным координатам вершин треугольника (x1,y1), (x2,y2) и (x3,y3) 
// требуется вычислить его площадь.

// Входные данные
// Входной файл INPUT.TXT содержит 6 целых чисел x1,y1,x2,y2,x3,y3 – 
// координаты вершин треугольника. Все числа не превышают 106 по абсолютной величине.

// Выходные данные
// В выходной файл OUTPUT.TXT выведите точное значение площади заданного 
// треугольника.

// Примеры

// №	INPUT.TXT	      OUTPUT.TXT
// 1	2 1 2 4 6 1	      6
// 2	0 0 0 3 3 0	      4.5

Console.Clear();

Console.Write("Введите x1: ");
var x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y1: ");
var y1 = Convert.ToDouble(Console.ReadLine());


Console.Write("Введите x2: ");
var x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y2: ");
var y2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите x3: ");
var x3 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y3: ");
var y3 = Convert.ToDouble(Console.ReadLine());


var a = Math.Sqrt(Math.Pow((y2 - y1), 2) + Math.Pow((x2 - x1), 2));
var b = Math.Sqrt(Math.Pow((y2 - y3), 2) + Math.Pow((x2 - x3), 2));
var c = Math.Sqrt(Math.Pow((y3 - y1), 2) + Math.Pow((x3 - x1), 2));

var p = (a + b + c) / 2;

var S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

S = Math.Round(S, 2);
Console.WriteLine($"Площадь заданного треугольника: {S}");

