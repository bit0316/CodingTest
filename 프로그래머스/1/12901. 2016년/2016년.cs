public class Solution
{
    public string solution(int a, int b)
    {
        string[] week = new string[] { "SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT" };
        int[] day = { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        string answer = "";
        int total = 4;
        
        for (int i = 1; i < a; ++i)
        {
            total += day[i];
        }
        total += b;
        answer = week[total % 7];
        
        return answer;
    }
}