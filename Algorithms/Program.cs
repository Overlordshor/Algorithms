using System.Diagnostics;
using Algorithms;

var array = ReadArray();
var target = ReadTarget();

var timer = new Stopwatch();
timer.Start();
var contains = BinarySearch();
timer.Stop();

Console.WriteLine("BinarySearch");
Console.WriteLine(contains);
Console.WriteLine(timer.ElapsedTicks);

timer = new Stopwatch();
timer.Start();
contains = array.Contains(target);
timer.Stop();

Console.WriteLine("array.Contains");
Console.WriteLine(contains);
Console.WriteLine(timer.ElapsedTicks);

timer = new Stopwatch();
timer.Start();
contains = array.Any(x => x == target);
timer.Stop();

Console.WriteLine("array.Any");
Console.WriteLine(contains);
Console.WriteLine(timer.ElapsedTicks);

timer = new Stopwatch();
timer.Start();
var a = array.FirstOrDefault(x => x == target);
contains = a == target;
timer.Stop();

Console.WriteLine("FirstOrDefault");
Console.WriteLine(contains);
Console.WriteLine(timer.ElapsedTicks);


int[] ReadArray()
{
    const int max = 1000000;
    var array = new int[max];
    for (var i = 0; i < max - 1; i++)
        array[i] = i;

    return array;
}

int ReadTarget()
{
    return 10000000;
}

bool BinarySearch()
{
    var search = new BinarySearch(array);
    return search.Contains(target);
}