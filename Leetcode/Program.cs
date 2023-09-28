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

        //послпе сортировки нахолим минимальный и макс значение
        int firstChoco = prices[0];
        int lastChoco = prices[1];

        int price = firstChoco + lastChoco;


        //тут уже  проверяете, можно ли купить эти две шоколадки,если можно то вернет остаток,
        //если нет то просто вернет деньги
        if (price <= money)
        {
            return money - price;
        }
        else
        {
            return money;
        }
    }
}