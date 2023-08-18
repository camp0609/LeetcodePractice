class PalindromeNumber {

    public static bool IsPalindrome(int number) {
        if(number < 0) {
            return false;
        }
        int reverse = 0;
        while(number > 0) {
            reverse = reverse * 10 + (number % 10);
            number /= 10;
        }

        return reverse == number;
    }
}