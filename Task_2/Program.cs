System.Console.WriteLine("введите первую координату точки 1 по X ");
double xa = int.Parse(Console.ReadLine());

System.Console.WriteLine("введите вторую координату точки 1 по Y ");
double ya = int.Parse(Console.ReadLine());

System.Console.WriteLine("введите вторую координату точки 1 по Z ");
double za = int.Parse(Console.ReadLine());

System.Console.WriteLine("введите первую координату точки 2 по  X");
double xb = int.Parse(Console.ReadLine());

System.Console.WriteLine("введите вторую координату точки  2 по Y ");
double yb = int.Parse(Console.ReadLine());

System.Console.WriteLine("введите вторую координату точки 2 по Z ");
double zb = int.Parse(Console.ReadLine());



double result = Math.Sqrt((xa - xb) * (xa - xb) + (ya - yb) * (ya - yb) + (za - zb) * (za - zb));  // формула вычисления расстояния
System.Console.WriteLine($"Расстояние между точками  = {result}");
