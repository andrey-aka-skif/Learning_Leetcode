namespace problem_002_add_two_numbers;

public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        long l1Value = l1.ToLong();
        long l2Value = l2.ToLong();

        return ListNodeFactory.CreateFromLong(l1Value + l2Value);
    }
}
