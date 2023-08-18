class TwoDMatrix {
    //74. Search a 2D Matrix

    public static bool SearchMatrix(int[][] matrix, int target) {
        int topRow = 0;
        int botRow = matrix.Length - 1;
        int colLength = matrix[0].Length;

        while(topRow <= botRow) {
            int currentRow = (botRow + topRow) / 2;
            if(target > matrix[currentRow][colLength - 1]) {
                topRow = currentRow + 1;
            }else if(target < matrix[currentRow][0]) {
                botRow = currentRow - 1;
            }else {
                break;
            }
        }

        if(!(topRow <= botRow)) {
            return false;
        }

        int leftPointer = 0;
        //
        int rightPointer = matrix[0].Length - 1;
        int row = (botRow + topRow) / 2;

        while(leftPointer <= rightPointer) {
            int mid = (leftPointer + rightPointer) / 2;
            if(target > matrix[row][mid]) {
                leftPointer = leftPointer + 1;
            }else if(target < matrix[row][mid]) {
                rightPointer = rightPointer - 1;
            }else if (matrix[row][mid] == target) {
                return true;
            }
        }
        return false;
    }
}