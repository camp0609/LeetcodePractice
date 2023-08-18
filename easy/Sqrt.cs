class Sqrt {
    public static int getSqrt(int x) {
        int low = 1;
        int high = x;
        while(low < high) {
            int mid = low + (high - low) / 2;
            if(mid <= x / mid && (mid + 1) > x / (mid + 1)) { // use mid = x/mid instead of mid*mid = x to avoid overflow
                return mid;
            }else if(mid > x / mid) {
                high = mid - 1;
            }else {
                low = mid + 1;
            }
        }
        return low;
    }
}