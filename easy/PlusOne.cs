class PlusOne {
    public static int[] getPlusOne(int[] number) {
        for(int i = 0; i < number.Length; i++) {
            if(number[i] < 9) {
                number[i]++;
                return number;
            }
            number[i] = 0;
        }
        int[] newNumber = new int[number.Length + 1];
        newNumber[0] = 1;
        return newNumber;
    }
}