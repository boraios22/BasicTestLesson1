internal class Program
{
    private static void Main(string[] args)
    {

    INPUT_NUM1:
        Console.Write("Enter number1:");
        var stringNum1 = Console.ReadLine();
        int num1;

        if (string.IsNullOrWhiteSpace(stringNum1))
        {
            goto INPUT_NUM1;
        }

        //try {
        //    num1 = int.Parse(stringNum1);
        //} catch (Exception e) {
        //    Console.WriteLine(e.ToString());
        //    goto INPUT_NUM1;
        //}

        if (!int.TryParse(stringNum1, out num1))
        {
            goto INPUT_NUM1;
        }

    INPUT_NUM2:
        Console.Write("Enter number2:");
        var stringNum2 = Console.ReadLine();
        int num2;

        if (string.IsNullOrWhiteSpace(stringNum2))
        {
            goto INPUT_NUM2;
        }
        if (!int.TryParse(stringNum2, out num2))
        {
            goto INPUT_NUM2;
        }

    INPUT_NUM3:
        Console.Write("Enter number3:");
        var stringNum3 = Console.ReadLine();
        int num3;

        if (string.IsNullOrWhiteSpace(stringNum3))
        {
            goto INPUT_NUM3;
        }
        if (!int.TryParse(stringNum3, out num3))
        {
            goto INPUT_NUM3;
        }


        var sum = num1 + num2 + num3;
        var product = num1 * num2 * num3;
        //var min = Math.Min(num3, Math.Min(num1, num2));
        var min = Math.Min(num1, num2);
        min = Math.Min(min, num3);

        var max = Math.Max(num3, Math.Max(num1, num2));


        Console.WriteLine("Sum: " + sum);

        Console.WriteLine($"Product: {product}");

        Console.WriteLine(String.Format("Min: {0}", min));
        Console.WriteLine(String.Format("Max: {0}", max));
        Console.WriteLine(String.Format("Min: {0}, Max: {1}",min, max));

        Console.ReadKey();
    }
}