// Option = digits + carry so there are 4 values possible:

// 0 - diigt = 0, carry = 0
// 1 - digit = 1, carry = 0
// 2 - digit = 0, carry = 1
// 3 - digit = 1, carry = 1


public class Solution
{
    public string AddBinary(string a, string b)
    {
        Stack<char> stack = new();
        int n = Math.Max(a.Length, b.Length);

        int carry = 0;
        for (int index = 0; index < n; index++)
        {
            int option = 0;
            option += a.Length > index ? a[^(index + 1)] - '0' : 0;
            option += b.Length > index ? b[^(index + 1)] - '0' : 0;
            option += carry;

            char digit = (char)('0' + option % 2);
            carry = option / 2;

            stack.Push(digit);
        }

        if (carry == 1) stack.Push('1');

        return new string(stack.ToArray());
    }
}