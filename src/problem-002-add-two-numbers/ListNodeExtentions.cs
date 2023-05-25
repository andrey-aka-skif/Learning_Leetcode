namespace problem_002_add_two_numbers;

public static class ListNodeExtentions
{
    public static int ToInt(this ListNode node)
    {
        int major = node.next != null ? node.next.ToInt() : 0;
        return 10 * major + node.val;
    }
}
