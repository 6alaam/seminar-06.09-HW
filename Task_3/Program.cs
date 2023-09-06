Console.Write("Введите число 1: ");
int n;
double Tret;

while (!int.TryParse(Console.ReadLine(), out n)) { Console.WriteLine("Это не число"); }

for (int i = 1; i<=n; i++)
{

Tret = Math.Pow(i,3);
System.Console.WriteLine(Tret);
}