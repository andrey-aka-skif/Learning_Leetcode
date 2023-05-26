namespace problem_002_add_two_numbers;

public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode firstNode = null!;
        ListNode prevNode = null!;
        ListNode currentL1 = l1;
        ListNode currentL2 = l2;
        int shift = 0;

        while (true)
        {
            if (currentL1 == null && currentL2 == null && shift == 0)
                break;

            int newRawVal = shift;

            if (currentL1 != null)
                newRawVal += currentL1.val;

            if (currentL2 != null)
                newRawVal += currentL2.val;

            int newVal = newRawVal % 10;
            shift = newRawVal / 10;

            var node = new ListNode(newVal);

            if (prevNode == null)
                firstNode = node;
            else
                prevNode.next = node;

            prevNode = node;

            currentL1 = currentL1 != null ? currentL1.next : null;
            currentL2 = currentL2 != null ? currentL2.next : null;
        }

        return firstNode;
    }
}
