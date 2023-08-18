class Stocks {
    //121. Best Time to Buy and Sell Stock
    public static int MaxProfit(int[] prices) {
        int lowestPricedDay = Int32.MaxValue;
        int greatestProfit = 0;

        for(int i = 0; i < prices.Length; i++) {
            if(prices[i] < lowestPricedDay) {
                lowestPricedDay = prices[i];
            }

            int currentProfit = prices[i] - lowestPricedDay;
            if(currentProfit > greatestProfit) {
                greatestProfit = currentProfit;
            }
        }

        return greatestProfit;

    }
}