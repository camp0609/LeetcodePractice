class RemoveDuplicate {
    public static int RemoveDuplicates(int[] nums) {
        int slowPointer = 0;
        for(int i = 1; i < nums.Length; i++) {
            if(nums[slowPointer] != nums[j]) {
                nums[++i] = nums[j];
            }
        }
        return slowPointer + 1;
    }
}