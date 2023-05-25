namespace problem_002_add_two_numbers;

public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        return ListNodeFactory.CreateFromInt(l1.ToInt() + l2.ToInt());
    }
}
