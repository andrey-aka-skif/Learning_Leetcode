namespace problem_002_add_two_numbers;

public class ListNode
{
    public int Val { get; set; }
    public ListNode? Next { get; set; }
    public ListNode(int val = 0, ListNode? next = null)
    {
        Val = val;
        Next = next;
    }

    public int ToInt()
    {
        int major = Next != null ? Next.ToInt() : 0;
        return 10 * major + Val;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || obj.GetType() != GetType())
            return false;

        var other = (ListNode)obj;

        return ToInt() == other.ToInt();
    }

    public override int GetHashCode()
    {
        if (Next != null)
            return HashCode.Combine(Val, Next.GetHashCode());
        else
            return HashCode.Combine(Val);
    }
}
