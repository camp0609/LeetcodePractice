using PrimeNumbers;
using TwoSums;
class Program {
    
    static void Main(string[] args) {
        // See https://aka.ms/new-console-template for more information
        Console.WriteLine("Hello, World!");
        PrimeNumber.isPrime();

        //int[] twoSumArray = new int[]{1, 3, 5, 9, 7};
        //int sum = 6;
        //int[] twoSumResult = TwoSum.GetTwoSum(twoSumArray, sum);

        //Array.ForEach(twoSumResult, Console.WriteLine);

        //Console.WriteLine(PalindromeNumber.IsPalindrome(356));
        //Console.WriteLine(RomanToIntager.GetIntFromRoman("MCMXCIV"));

        int[] nums = new int[]{1, 3, 5, 9, 7};
        RemoveElement.Remove(nums, 6);
        Console.WriteLine(Sqrt.getSqrt(1000));
    }
}
