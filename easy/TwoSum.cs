namespace TwoSums {

    class TwoSum {
        //return the indexes of the 2 numbers that sum to the sum
        public static int[] GetTwoSum(int[] nums, int sum) {
            int[] indexes = new int[2];
            Dictionary<int, int> numbersAndIndexes = new Dictionary<int, int>();

            for(int i = 0; i < nums.Length; i++) {
                int sumDifference = sum - nums[i];
                if(numbersAndIndexes.ContainsKey(sumDifference)) {
                    indexes[0] = i;
                    indexes[1] = numbersAndIndexes[sumDifference];
                }else {
                    numbersAndIndexes.Add(nums[i], i);
                }
            }
            return indexes;
        }
    }
}