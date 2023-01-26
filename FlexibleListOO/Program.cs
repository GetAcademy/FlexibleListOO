/*

 - lite fleksible arrayer i C#
 - => objektorientering
 - generics
 - List<>

Pause til 13:28
 */

using FlexibleListOO;

var numbers = new FlexibleListOO.List<int>();
//Console.WriteLine(numbers[0]);
//while (true)
//{
//    var numberStr = Console.ReadLine();
//    var number = Convert.ToInt32(numberStr);
//    numbers.Add(number);
//    numbers.Show();
//}

//var strings = new FlexibleListOO.List<string>();
//while (true)
//{
//    var text = Console.ReadLine();
//    strings.Add(text);
//    strings.Show();
//}

var strings = new System.Collections.Generic.List<string>();
Console.WriteLine(strings[0]);
while (true)
{
    var text = Console.ReadLine();
    strings.Add(text);
    //strings.Show();
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