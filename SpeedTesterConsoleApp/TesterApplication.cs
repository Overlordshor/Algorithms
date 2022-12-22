using Algorithms;

namespace SpeedTesterConsoleApp;

public class TesterApplication
{
    private readonly ITimer _timer;

    private int[]? _array;
    private int _target;

    public TesterApplication(ITimer timer)
    {
        _timer = timer;
    }

    public void Configure()
    {
        _array = ReadArray();
        _target = ReadTarget();
    }

    public void Start()
    {
        if (_array == null || !_array.Any())
            throw new NullReferenceException($"{nameof(_array)} not found");

        BinarySearch();
        ContainsSearch();
        LinqAnySearch();
        LinqFirstOrDefaultSearch();
    }

    private void BinarySearch()
    {
        _timer.Start();

        var search = new BinarySearch(_array);
        var contains = search.Contains(_target);
        WriteLineResult(nameof(BinarySearch), contains, _timer.Result());
    }

    private void LinqFirstOrDefaultSearch()
    {
        _timer.Start();
        var contains = _target == _array.FirstOrDefault(x => x == _target);
        WriteLineResult(nameof(LinqFirstOrDefaultSearch), contains, _timer.Result());
    }

    private void LinqAnySearch()
    {
        _timer.Start();
        var contains = _array.Any(x => x == _target);
        WriteLineResult(nameof(LinqAnySearch), contains, _timer.Result());
    }

    private void ContainsSearch()
    {
        _timer.Start();
        var contains = _array.Contains(_target);
        WriteLineResult(nameof(ContainsSearch), contains, _timer.Result());
    }


    private int[] ReadArray()
    {
        const int max = 1000000;
        var array = new int[max];
        for (var i = 0; i < max - 1; i++)
            array[i] = i;

        return array;
    }

    private int ReadTarget()
    {
        return 10000000;
    }


    private void WriteLineResult(string searchName, bool result, long elapsedTicks)
    {
        Console.WriteLine(searchName);
        Console.WriteLine(result);
        Console.WriteLine(elapsedTicks);
    }
}