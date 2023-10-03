public class Solution
{
    public int CountWords(string[] words1, string[] words2)
    {
        //var merge = words1.Intersect(words2);

        //foreach (var word in words1)
        //{
        //    if (dict1.ContainsKey(word))
        //    {
        //        dict1[word]++;
        //    }
        //    else
        //    {
        //        dict1[word] = 1;
        //    }
        //}

        //foreach (var word in words2)
        //{
        //    if (dict2.ContainsKey(word))
        //    {
        //        dict2[word]++;
        //    }
        //    else
        //    {
        //        dict2[word] = 1;
        //    }
        //}


        int count = 0;

        var t = words1.GroupBy(x => x).Where(g => g.Count() == 1).Select(g => g.Key);
        var k = words2.GroupBy(x => x).Where(g => g.Count() == 1).Select(g => g.Key);

        var merge = t.Intersect(k);

        count = merge.Count();

        return count;
    }
}