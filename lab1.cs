using System;

public class methods
{
    public double fraction(double x) //задача 1
    {
        return x - (int)x;
    }

    public int charToNum(char x) //задача 3
    {
        if (x >= '0' && x <= '9')
        {
            return x - '0';
        }
        return 0;
    }

    public bool is2Digits(int x) //задача 5
    {
        return x >= 10 && x <= 99 || x <= -10 && x >= -99;
    }

    public bool isInRange(int a, int b, int num) //задача 7
    {
        int min = Math.Min(a, b);
        int max = Math.Max(a, b);
        return num >= min && num <= max;
    }

    public bool isEqual(int a, int b, int c) //задача 9
    {
        return a == b && b == c;
    }

    public int abs(int x) //задача 11
    {
        if (x < 0)
        {
            return -x;
        }
        else
        {
            return x;
        }
    }

    public bool is35(int x) //задача 13
    {
        bool div3 = x % 3 == 0;
        bool div5 = x % 5 == 0;
        return (div3 || div5) && !(div3 && div5);
    }

    public int max3(int x, int y, int z) //задача 15
    {
        int max = x;
        if (y > max)
        {
            max = y;
        }
        if (z > max)
        {
            max = z;
        }
        return max;
    }

    public int sum2(int x, int y) //задача 17
    {
        int sum = x + y;
        if (sum >= 10 && sum <= 19)
        {
            return 20;
        }
        return sum;
    }

    public string day(int x) //задача 19
    {
        switch (x)
        {
            case 1: return "понедельник";
            case 2: return "вторник";
            case 3: return "среда";
            case 4: return "четверг";
            case 5: return "пятница";
            case 6: return "суббота";
            case 7: return "воскресенье";
            default: return "это не день недели";
        }
    }

    public string ListNums(int x) //задача 21
    {
        string s = "";
        for (int i = 0; i <= x; i++)
        {
            s += i + " ";
        }
        return s;
    }

    public string chet(int x) //задача 23
    {
        string s1 = "";
        for (int i = 0; i <= x; i += 2)
        {
            s1 += i + " ";
        }
        return s1;
    }

    public int numLen(long x) //задача 25
    {
        int k = 0;
        while (x > 0)
        {
            k += 1;
            x /= 10;
        }
        return k;
    }

    // ПРОВЕРКИ НА ВВОД
    public double readDouble(string inp) //проверка ввода числа
    {
        Console.Write(inp);
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out double result))
            {
                return result;
            }
            Console.Write("Неверный ввод, введите число: ");
        }
    }

    public char readChar(string inp) //проверка ввода цифры
    {
        Console.Write(inp);
        while (true)
        {
            string input = Console.ReadLine();
            if (input != null && input.Length == 1 && input[0] >= '0' && input[0] <= '9')
            {
                return input[0];
            }
            Console.Write("Неверный ввод, введите ОДНУ цифру от 0 до 9: ");
        }
    }

    public int readInt(string inp) //проверка ввода целого числа
    {
        int result;
        Console.Write(inp);
        while (!int.TryParse(Console.ReadLine(), out result))
        {
            Console.Write("Неверный ввод, введите целое число: ");
        }
        return result;
    }

    public int readIntInRange(string inp, int min, int max) //проверка ввода целого числа в диапазоне
    {
        int result;
        Console.Write(inp);
        while (!int.TryParse(Console.ReadLine(), out result) || result < min || result > max)
        {
            Console.Write($"Ошибка ввода, введите целое число от {min} до {max}: ");
        }
        return result;
    }


    public static void Main(string[] args) //ОСНОВНОЙ МЕТОД
    {
        methods method = new methods();

        // Задача 1
        Console.WriteLine("Задача 1. Нахождение дробной части вещественного числа.");
        double num = method.readDouble("Введите вещественное число: ");
        double dotPart = method.fraction(num);
        Console.WriteLine($"Дробная часть числа {num} = {dotPart}");
        Console.WriteLine();

        // Задача 3
        Console.WriteLine("Задача 3. Преобразование введенного символа.");
        char digitChar = method.readChar("Введите цифру от 0 до 9: ");
        int digit = method.charToNum(digitChar);
        Console.WriteLine($"Символ '{digitChar}' преобразован в число: {digit}");
        Console.WriteLine();

        // Задача 5
        Console.WriteLine("Задача 5. Проверка на двузначность числа.");
        int num1 = method.readInt("Введите целое число: ");
        bool isTwoDigit = method.is2Digits(num1);
        Console.WriteLine($"Число {num1} является двузначным числом: {isTwoDigit}");
        Console.WriteLine();

        // Задача 7
        Console.WriteLine("Задача 7. Проверка на принадлежность числа заданному диапазону.");
        int a1 = method.readInt("Введите первую границу диапазона: ");
        int b1 = method.readInt("Введите вторую границу диапазона: ");
        int num2 = method.readInt("Введите число для проверки его принадлежности к заданному диапазону: ");
        bool inRange = method.isInRange(a1, b1, num2);
        Console.WriteLine($"Число {num2} входят в заданный диапазон: {inRange}");
        Console.WriteLine();

        // Задача 9
        Console.WriteLine("Задача 9. Проверка равенства введенных чисел.");
        int a2 = method.readInt("Введите первое число:");
        int b2 = method.readInt("Введите второе число:");
        int c2 = method.readInt("Введите третье число:");
        bool eq = method.isEqual(a2, b2, c2);
        Console.WriteLine($"Числа {a2}, {b2}, {c2} равны: {eq}");
        Console.WriteLine();

        // Задача 11
        Console.WriteLine("Задача 11. Получение модуля числа.");
        int value = method.readInt("Введите число: ");
        int absValue = method.abs(value);
        Console.WriteLine($"Модуль числа {value} = {absValue}");
        Console.WriteLine();

        // Задача 13
        Console.WriteLine("Задача 13. Проверка делится ли число на 3 или 5, но не на оба.");
        int value1 = method.readInt("Введите число:");
        bool is35Res = method.is35(value1);
        Console.WriteLine($"Число {value1} делится на 3 или на 5, но не на оба: {is35Res}");
        Console.WriteLine();

        // Задача 15
        Console.WriteLine("Задача 15. Нахождение максимального числа из трех введенных чисел.");
        int a3 = method.readInt("Введите первое число: ");
        int b3 = method.readInt("Введите второе число: ");
        int c3 = method.readInt("Введите третье число: ");
        int maxi = method.max3(a3, b3, c3);
        Console.WriteLine($"Максимальное число из чисел {a3}, {b3}, {c3} = {maxi}");
        Console.WriteLine();

        // Задача 17
        Console.WriteLine("Задача 17. Получение суммы двух чисел (с условием).");
        int x1 = method.readInt("Введите первое число: ");
        int y1 = method.readInt("Введите второе число: ");
        int sumRes = method.sum2(x1, y1);
        Console.WriteLine($"Результат суммы чисел {x1} и {y1} согласно условию задачи: {sumRes}");
        Console.WriteLine();

        // Задача 19
        Console.WriteLine("Задача 19. Получение дня недели по введенному номеру.");
        int dayNumber = method.readIntInRange("Введите номер дня недели (1,7):", 1, 7);
        string dayName = method.day(dayNumber);
        Console.WriteLine($"День недели соответствующий введенному номеру ({dayNumber}): {dayName} ");
        Console.WriteLine();

        // Задача 21
        Console.WriteLine("Задача 21. Получение строки, содержащей все числа от 0 до введенного числа (включительно).");
        int peak1 = method.readInt("Введите целое число: ");
        string sequence1 = method.ListNums(peak1);
        Console.WriteLine($"Строка, содержащая все числа от 0 до {peak1}: {sequence1}");
        Console.WriteLine();

        // Задача 23
        Console.WriteLine("Задача 23. Получение строки, содержащей все ЧЕТНЫЕ числа от 0 до введенного числа (включительно).");
        int peak2 = method.readInt("Введите целое число: ");
        string sequence2 = method.ListNums(peak2);
        Console.WriteLine($"Строка, содержащая все ЧЕТНЫЕ числа от 0 до {peak2}: {sequence2}");
        Console.WriteLine();

        // Задача 25
        Console.WriteLine("Задача 25. Получение количества знаков в веденном числе.");
        int u = method.readInt("Введите целое число: ");
        int result1 = method.numLen(u);
        Console.WriteLine($"Количество знаков в числе {u} = {result1}");
        Console.WriteLine();
    }
}