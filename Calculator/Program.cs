using System.ComponentModel.Design;
using System.Runtime.InteropServices;

double oper;
double num1;
double num2;
double ans;

do
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\n            Введите тип операции: ");
    Console.ResetColor();
    Console.WriteLine("(1) - Сложение двух чисел.");
    Console.WriteLine("(2) - Вычитание первого числа из второго.");
    Console.WriteLine("(3) - Перемножить два числа.");
    Console.WriteLine("(4) - Разделить первое на второе.");
    Console.WriteLine("(5) - Возвести в степень N первое число.");
    Console.WriteLine("(6) - Найти квадратный корень из числа.");
    Console.WriteLine("(7) - Найти 1% от числа");
    Console.WriteLine("(8) - Найти факториал из числа");
    Console.WriteLine("(9) - Выйти из программы");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Окно ввода: ");
    Console.ResetColor();
    oper = Convert.ToDouble(Console.ReadLine());
    switch (oper)
    {
        case 1:
            Console.Write("Введите первое слагаемое: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе слагаемое: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            ans = num1 + num2;
            Console.WriteLine("Сумма выражения: " + num1 + " + " + num2 + " = " + ans + "");
            break;

        case 2:
            Console.Write("Введите уменьшаемое: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите вычитаемое: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            ans = num1 - num2;
            Console.WriteLine("Разность выражения: " + num1 + " - " + num2 + " = " + ans + "");
            break;

        case 3:
            Console.Write("Введите первый множитель: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второй множитель: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            ans = num1 * num2;
            Console.WriteLine("Произведение выражения: " + num1 + " * " + num2 + " = " + ans + "");
            break;

        case 4:
            Console.Write("Введите числитель: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите знаменатель: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            if (num2 == 0)
            {
                Console.WriteLine("Разделить на ноль нельзя!");
            }
            else
            {
                ans = num1 / num2;
                Console.WriteLine("Частное выражения: " + num1 + " - " + num2 + " = " + ans + "");
            }
            break;

        case 5:
            Console.Write("Введите число, которое вы будете возводить в степень: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите степень: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            ans = Math.Pow(num1, num2);
            Console.WriteLine("Ответ выражения: " + num1 + "^" + num2 + " = " + ans + "");
            break;

        case 6:
            Console.Write("Введите подкоренное выражение: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            ans = Math.Sqrt(num1);
            Console.WriteLine("Произведение выражения: " + "√" + num1 + " = " + ans + "");
            break;

        case 7:
            Console.Write("Введите число: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            ans = num1 * 0.01;
            Console.WriteLine("1% от числа " + num1 + " = " + ans + "");
            break;

        case 8:
            Console.Write("Введите число, из которого вы будете вычеслять факториал: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            int facl = 1;
            while (i <= num1)
            {
                facl = facl * i;
                i++;
            }
            Console.WriteLine("Факториал числа " + num1 + " равен " + facl + "");
            break;

        default:
            if (oper == 9)
                continue;
            else
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n               Данной операции нет в списке! Попробуйте снова:");
                Console.ResetColor();
            break;

    }
}
while (oper != 9);



