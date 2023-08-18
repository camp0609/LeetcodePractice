using System.Collections;

class ValidParentheses {
    
    public static bool IsValidParentheses(string parentheses) {
        Stack<char> stack = new Stack<char>();

        foreach(char c in parentheses) {
            if(c == '[') {
                stack.Push(']');
            }
            else if(c == '{') {
                stack.Push('}');
            }
            else if(c == '(') {
                stack.Push(')');
            }
            else if(stack.Count == 0 || stack.Pop() != c) {
                return false;
            }
        }
        return stack.Count == 0;
    }
}