class ReverseNumber {

    public static int GetReverseNumber(int number) {
        int reverse = 0;
        while(number > 0) {
            reverse = reverse * 10 + (number % 10);
            number /= 10;
        }
        return reverse;
    }
}