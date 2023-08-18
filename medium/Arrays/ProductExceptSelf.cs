class ProductExceptSelf {
    public static int[] GetProductExceptSelf(int[] nums) {
        int length = nums.Length;

        int[] leftProduct = new int[length];
        int[] rightProduct = new int[length];
        int[] result = new int[length];

        leftProduct[length - 1] = 1;
        rightProduct[0] = 1;

        for(int i = 1; i < length; i++) {
            rightProduct[i] = nums[i - 1] * rightProduct[i - 1];
        }

        for(int i = length - 2; i > 0; i--) {
            leftProduct[i] = nums[i + 1] * leftProduct[i + 1];
        }

        for(int i = 0; i < length; i++) {
            result[i] = rightProduct[i] * leftProduct[i];
        }

        return result;
    }
}