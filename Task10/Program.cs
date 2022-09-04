Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int remains1 = a%100;
int remains2 = a%10;
int b = (remains1-remains2)/10;
Console.WriteLine(b);