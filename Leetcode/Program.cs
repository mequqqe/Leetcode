public class Solution
{
    public int BuyChoco(int[] prices, int money)
    {
        //сортируется массив по алгоримту вставки
        for (int i = 1; i < prices.Length; i++)
        {
            var key = prices[i];
            var j = i - 1;
            while (j >= 0 && prices[j] > key)
            {
                prices[j + 1] = prices[j];
                j--;
            }
            prices[j + 1] = key;
        }

        //послпе сортировки нахолим минимальный и макс значение,
        //если сортирован то можно просто получить первый и послдений массив
        int firstChoco = prices[0];
        int lastChoco = prices[prices.Length - 1];

        int price = firstChoco + lastChoco;


        //тут уже  проверяете, можно ли купить эти две шоколадки,если можно то вернет остаток,
        //если нет то просто вернет деньги
        if (price <= money)
        {
            return money - price;
        }
        else
        {
            //FIX обновил метод так он не проходил еще один кейс,
            //пробела в том что бы он покупал только минимальный и максимальный,а другие цены не проверял


            // Дополнительная проверка для других пар шоколадок
            for (int i = 0; i < prices.Length; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
                {
                    int currentPrice = prices[i] + prices[j];
                    if (currentPrice <= money)
                    {
                        return money - currentPrice;
                    }
                }
            }
            return money;
        }
    }
}