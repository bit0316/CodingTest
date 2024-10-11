public class Solution
{
    public string solution(string s)
    {
        char[] arr = s.ToLower().ToCharArray();
        int size = s.Length;
        string answer = "";
        
        arr[0] = char.ToUpper(arr[0]);
        for (int i = 1; i < size; ++i)
        {
            if (arr[i - 1] == ' ')
            {
                arr[i] = char.ToUpper(arr[i]);
            }
        }
        answer = new string(arr);
        
        return answer;
    }
}