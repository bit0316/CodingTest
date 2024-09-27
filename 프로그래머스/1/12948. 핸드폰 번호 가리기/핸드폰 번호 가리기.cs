public class Solution
{
    public string solution(string phone_number)
    {
        int size = phone_number.Length - 4;
        char[] arr = phone_number.ToCharArray();
        string answer;
        
        for (int i = 0; i < size; ++i)
        {
            arr[i] = '*';
        }
        answer = new string(arr);
        
        return answer;
    }
}