using System;
namespace Playground;
class myClass
{
    public void sayHello()
    {
        Console.WriteLine("Hello from the playground!");
    }

    public void TestConversions()
    {
        int age = 30;            // Integer
        double price = 9.99;     // Decimal number
        bool isActive = true;    // Boolean
        char grade = 'A';        // Single character
        string name = "Alice";   // Text

        Console.WriteLine($"Age: {age}.");

        string strNum = "100";
        int convertedNum = Convert.ToInt32(strNum);
        Console.WriteLine($"ConvertedNum: {convertedNum}");

    }

    public void ArraysLookLikeObjs()
    {
        int[] numbers = { 1, 2, 3, 4 };
        Console.WriteLine(numbers[0]); // Output: 1

    }
}