namespace problem_002_add_two_numbers;

public class ListNodeFactory
{
    public static ListNode CreateFromArray(int[] values)
    {
        Array.Reverse(values);

        ListNode current = null!;

        foreach (int value in values)
        {
            current = new ListNode(value, current);
        }

        return current!;
    }

    internal static ListNode CreateFromLong(long value)
    {
        var result = CreateArrayFromLong(value);
        return CreateFromArray(result);
    }

    internal static int[] CreateArrayFromLong(long value)
    {
        if (value == 0)
            return new int[1];

        var result = Array.Empty<int>();
        while (value > 0)
        {
            int current = (int)(value % 10);
            value /= 10;
            Array.Resize(ref result, result.Length + 1);
            result[^1] = current;
        }

        return result;
    }
}
