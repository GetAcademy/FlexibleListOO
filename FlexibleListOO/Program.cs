/*

    pause til 13:00

 - lite fleksible arrayer i C#
 - => objektorientering
 - List<>
 - generics
 */

using FlexibleListOO;

var list = new List();
while (true)
{
    var numberStr = Console.ReadLine();
    var number = Convert.ToInt32(numberStr);
    list.Add(number);
    list.Show();
}

//var numbers = new int[4];
//var count = 0;
//while (true)
//{
//    var numberStr = Console.ReadLine();
//    var number = Convert.ToInt32(numberStr);
//    var index = count;
//    if (index >= numbers.Length)
//    {
//        var newNumbers = new int[numbers.Length*2];   
//        Array.Copy(numbers, newNumbers, numbers.Length);
//        numbers = newNumbers;
//    }
//    numbers[index] = number;
//    count++;

//    Console.WriteLine($"Count={count}");
//    foreach (var n in numbers)
//    {
//        Console.Write(n + " ");
//    }
//    Console.WriteLine();
//}