using System;

public class Solution
{
    public string solution(string[] cards1, string[] cards2, string[] goal)
    {
        string answer = IsValid(cards1, cards2, goal) ? "Yes" : "No";
        
        return answer;
    }
    
    public bool IsValid(string[] cardsA, string[] cardsB, string[] goal)
    {
        int sizeA = cardsA.Length;
        int sizeB = cardsB.Length;
        int sizeG = goal.Length;
        int indexA = 0;
        int indexB = 0;
        string[] arr = new string[sizeG];
        
        for (int i = 0; i < sizeG; ++i)
        {
            if (indexA < sizeA && cardsA[indexA] == goal[i])
            {
                goal[i] = cardsA[indexA++];
            }
            else if (indexB < sizeB && cardsB[indexB] == goal[i])
            {
                goal[i] = cardsB[indexB++];
            }
            else
            {
                return false;
            }
        }
        return true;
    }
}