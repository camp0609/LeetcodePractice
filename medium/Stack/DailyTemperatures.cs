class DailyTemperatures {
    public static int[] getDailyTemperatures(int[] temperatures) {
        //739. Daily Temperatures
        //given array of temps return array with index is number of days until day with higher temp
        int[] res = new int[temperatures.Length];  

			Stack<int> stack = new Stack<int>();

			stack.Push(0);

			for (int i = 1; i < temperatures.Length; i++)
			{
				while (stack.Count != 0 && temperatures[stack.Peek()] < temperatures[i])
				{
					int idx = stack.Pop();
                    res[idx] = i - idx;
				}
				stack.Push(i);
			}

			return res;
    }
}