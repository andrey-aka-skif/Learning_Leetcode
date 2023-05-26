namespace problem_002_add_two_numbers;

public class ListNodeFactory
{
    public static ListNode CreateFromArray(int[] values)
    {
        Array.Reverse(values);

        ListNode current = null!;

        foreach (int value in values)
            current = new ListNode(value, current);

        return current!;
    }
}
