Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int i =0;
int m=500;
int [] array=new int[90];//не понял как создать пустой массив, поэтому сделал так
if (a>100) {
while (a>0) {
int d=a%10;
a=a/10;
array[i]=d;
i=i+1;
}
Console.WriteLine(array[i-3]);
} 
else Console.WriteLine("третьей цифры нет");