public class Solution {
    public bool IsValid(string s) {
        if (s.Length <= 1)
            return false;

        var stack = new Stack<char>();

        stack.Push(s[0]);
        for (int i = 1; i < s.Length; i++)
        {
            var currentChar = s[i];
            if (stack.Count == 0)
            {
                stack.Push(currentChar);
                continue;
            }

            if (stack.Peek() == '(' && currentChar == ')')
            {
                stack.Pop();
            }
            else if (stack.Peek() == '[' && currentChar == ']')
            {
                stack.Pop();
            }
            else if (stack.Peek() == '{' && currentChar == '}')
            {
                stack.Pop();
            }
            else
            {
                stack.Push(currentChar);
            }
        }

        return stack.Count == 0;
    }
}