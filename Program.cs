namespace count;

    internal class Program
    {
    static void Main()
        {
        int number1, number2, number3, number4, number5;
        int sum, max, min, product;

        Console.WriteLine("Ваше первое число");
        number1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ваше второе число");
        number2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ваше третие число");
        number3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ваше четвёртое число");
        number4 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ваше пятое число");
        number5 = int.Parse(Console.ReadLine());

        sum = number1 + number2 + number3 + number4 + number5;

        max = number1;
        if (number2 > max) max = number2;
        if (number3 > max) max = number3;
        if (number4 > max) max = number4;
        if (number5 > max) max = number5;

        min = number1;
        if (number2 < min) min = number2;
        if (number3 < min) min = number3;
        if (number4 < min) min = number4;
        if (number5 < min) min = number5;

        product = number1 * number2 * number3 * number4 * number5;

        Console.WriteLine("\nСумма" + sum);
        Console.WriteLine("Максимум" + max);
        Console.WriteLine("Минимум" + min);
        Console.WriteLine("Умноженные вместе" + product);
    }
}
