public class Solution
{
    public int solution(int[] arr)
    {
        int answer = arr[0];
        
        foreach (int num in arr)
        {
            answer = GetLCM(answer, num, GetGCD(answer, num));
        }
        
        return answer;
    }
    
    public int GetGCD(int numA, int numB)
    {
        while (numB > 0)
        {
            (numA, numB) = (numB, numA % numB);
        }
        
        return numA;
    }
    
    public int GetLCM(int numA, int numB, int gcd)
    {
        return numA * numB / gcd;
    }
}