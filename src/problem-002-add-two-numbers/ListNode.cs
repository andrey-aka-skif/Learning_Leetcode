using static System.Net.Mime.MediaTypeNames;

namespace problem_002_add_two_numbers;

public class ListNode
{
    public int val { get; set; }
    public ListNode? next { get; set; }
    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || obj.GetType() != GetType())
            return false;

        var other = (ListNode)obj;

        return this.ToLong() == other.ToLong();
    }

    public override int GetHashCode()
    {
        if (next != null)
            return HashCode.Combine(val, next.GetHashCode());
        else
            return HashCode.Combine(val);
    }
}
