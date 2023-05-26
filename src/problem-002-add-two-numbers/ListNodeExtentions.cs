namespace problem_002_add_two_numbers;

public static class ListNodeExtentions
{
    public static int[] ToArray(this ListNode node)
    {
        int[] values = node.next != null ? node.next.ToArray() : Array.Empty<int>();
        Array.Resize(ref values, values.Length + 1);
        values[^1] = node.val;
        return values;
    }

    public static int[] Reverse(this int[] array)
    {
        Array.Reverse(array);
        return array;
    }
}
