public class Solution
{
    public string solution(string s)
    {
        int size = s.Length;
        char[] arr = s.ToCharArray();
        string answer = "";
        int index = 0;
        
        for (int i = 0; i < size; ++i)
        {
            if (arr[i] == ' ')
            {
                index = 0;
                continue;
            }
            
            arr[i] = index++ % 2 == 0 ? char.ToUpper(arr[i]) : char.ToLower(arr[i]);
        }
        answer = new string(arr);
        
        return answer;
    }
}