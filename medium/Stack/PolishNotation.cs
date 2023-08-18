class PolishNotation {
    public static int getPolishNotationResult(string[] tokens) {
        if (tokens == null || tokens.Length == 0) {
            return -1;
        }

        int first;
        int second;
        Stack<int> stack = new Stack<int>();

        foreach (string token in tokens) {
            switch (token) {
                case "+":
                    stack.Push(stack.Pop() + stack.Pop());
                    break;

                case "-":
                    first = stack.Pop();
                    second = stack.Pop();

                    stack.Push(second - first);
                    break;

                case "*":
                    stack.Push(stack.Pop() * stack.Pop());
                    break;

                case "/":
                    first = stack.Pop();
                    second = stack.Pop();

                    stack.Push(second / first);
                    break;

                default:
                    stack.Push(Int32.Parse(token));
                    break;
            }
        }

        return stack.Pop();
    }
}