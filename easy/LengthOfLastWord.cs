class LengthOfLastWord {
    public static int getLengthOfLastWord(string s) {
        int lengthOfLastWord = 0;

        for(int i = s.Length - 1; i >= 0; i--) {
            if(s[i] != ' ') {
                lengthOfLastWord++;
            }else {
                if(lengthOfLastWord > 0) {
                    return lengthOfLastWord;
                }
            }
        }
        return lengthOfLastWord;
    }
}