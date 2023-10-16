using System;
public class Solution
{
    public string[] FindRelativeRanks(int[] score)
    {
        string[] res = new string[score.Length];

        int[] sorted= (int[])score.Clone();

        Array.Sort(sorted,(x, y) => y.CompareTo(x));

        string[] ranks = new string[score.Length];

        for (int i = 0; i < score.Length; i++)
        {
            int rank = Array.IndexOf(sorted, score[i]) + 1;
            string rankStr;

            if (rank == 1)
                rankStr = "Gold Medal";
            else if (rank == 2)
                rankStr = "Silver Medal";
            else if (rank == 3)
                rankStr = "Bronze Medal";
            else
                rankStr = rank.ToString();

            ranks[i] = rankStr;
        }

        return ranks;
    }
}

