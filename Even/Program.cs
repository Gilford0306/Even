//Задание 7
//Пользователь вводит с клавиатуры два числа. Нужно 
//показать все четные числа в указанном диапазоне. Если 
//границы диапазона указаны неправильно требуется про-
//извести нормализацию границ. Например, пользователь 
//ввел 20 и 11, требуется нормализация, после которой 
//начало диапазона станет равно 11, а конец 20.


int k;
do
{
    Console.WriteLine("Input first number ");
    int num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Input second number ");
    int num2 = int.Parse(Console.ReadLine());
    if (num1 > num2)
    {
        int temp = num1;
        num1 = num2;
        num2 = temp;
    }
    Console.Write("All even number from " + num1 +" to "+num2+": ");
    for (int i = num1; i < num2 + 1; i++)
    {
        if (i % 2 == 0)
        {
            Console.Write(i+"  ");
        }
    }
    Console.WriteLine(" ");
    Console.WriteLine("Input key - 1 - to continue, 0 - to exit");
    k = int.Parse(Console.ReadLine());
} while (k == 1);
return;
