namespace Algorithms;

public interface ISearch
{
    bool Contains(int target);
}

public class BinarySearch : ISearch
{
    private readonly int[] _array;

    public BinarySearch(int[] array)
    {
        _array = array;
    }

    public bool Contains(int target)
    {
        var low = 0;
        var high = _array.Length - 1;

        while (low <= high)
        {
            var middle = (low + high) / 2;
            var middleElement = _array[middle];
            if (target == middleElement)
                return true;

            if (target < middleElement)
                high = middle - 1;
            else
                low = middle + 1;
        }

        return false;
    }
}