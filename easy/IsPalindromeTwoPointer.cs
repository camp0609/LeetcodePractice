class IsPalindromeTwoPointer {

    public static bool IsPalindrome(string s) {
        string str = s.ToLower();
        int left=0, right = str.Length-1;

        while(left<right){
            //if any charater is other than letter or digit while moving from left
            if(!char.IsLetterOrDigit(str[left])){
                left++;
            }
             //if any charater is other than letter or digit while moving from right
            else if (!char.IsLetterOrDigit(str[right])){
                right--;
            }
             //if from both sides it is correct
            else{
                if(str[left]!= str[right]){
                    return false;
                }
                left++;
                right--;

            }
        }

        return true;
    }
}