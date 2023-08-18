class SearchInsertPosition {
    public static int GetInsertPosition(int[] nums, int target) {
        int low = 0;
        int high = nums.Length - 1;

        while(low <= high){
            int mid = low + (high - low) / 2;
            if(target == nums[mid]){
                return mid;
            }else if(target < nums[mid]){
                high = mid - 1;
            }else{
                low = mid + 1;
            }
        }
        return low;
    }
}