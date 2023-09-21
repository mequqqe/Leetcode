public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {

        //хэшсет это это математические операции,тут HashSet<int>(nums).Count
        //хэшсет получает сколько уникальных цифр в массвие,а тут  общее количество элемеонтом в массие  nums.Length
        //и они медлу собой сравнивается,если уникальный элемент меньше количестов элементов в массиве то озночает что есть повторяющиеся элементы
        return new HashSet<int>(nums).Count < nums.Length;
    }
}