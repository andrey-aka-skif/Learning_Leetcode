namespace problem_002_add_two_numbers;

public static class ListNodeExtentions
{
    public static long ToLong(this ListNode node)
    {
        long major = node.next != null ? node.next.ToLong() : 0;
        return (10 * major) + node.val;
    }
}
