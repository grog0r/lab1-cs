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
        return -1;
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

    public void square(int x) //задача 27
    {
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < x; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
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
}