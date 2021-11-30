// Дано: пять гирь с разным весом в случайном порядке.
// Найти: вес самой тяжелой гири.

int a = 24;
int b = 16;
int c = 4;
int d = 7;
int x = 32;

int max = a;
// if (a > max) max = a; лишняя строка кода т.к уже max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (x > max) max = x;

Console.Write("max = ");
Console.WriteLine(max);
