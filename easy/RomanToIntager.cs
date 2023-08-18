class RomanToIntager {

    public static int GetIntFromRoman(string roman) {
        Dictionary<char, int> romanMap = new Dictionary<char, int>();
        romanMap.Add('I', 1);
        romanMap.Add('V', 5);
        romanMap.Add('X', 10);
        romanMap.Add('L', 50);
        romanMap.Add('C', 100);
        romanMap.Add('D', 500);
        romanMap.Add('M', 1000);

        int length = roman.Length;

        int num = romanMap[roman[length - 1]];

        for(int i = length - 2; i >= 0; i--) {
            if(romanMap[roman[i]] < romanMap[roman[i + 1]]) {
                num -= romanMap[roman[i]];
            }else {
                num += romanMap[roman[i]];
            }
        }
        return num;
    }
}