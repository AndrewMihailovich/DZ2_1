Console.Write("Введите трёхзначное число ");
int chislo = Convert.ToInt32(Console.ReadLine());
if (chislo > 99 && chislo < 1000)
{
    Console.Write("Вторая цифра -> " + (chislo / 10) % 10);
}
else
{
  Console.Write(chislo + " - не трёхзначное число, введите число от 100 до 999"); 
}