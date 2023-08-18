class RemoveElement {
    public static int Remove(int[] nums, int val) {
        int count = 0;
        // Loop through all the elements of the array
        for (int i = 0; i < nums.Length; i++) {
            // If the element is not val
            if (nums[i] != val) {
                nums[count++] = nums[i];
            }
            Array.ForEach(nums, Console.Write);
            Console.WriteLine("");
        }
        return count;
    }
}