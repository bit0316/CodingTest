using System;

public class Solution
{
    public string solution(string[] id_pw, string[,] db)
    {
        string answer = GetResult(id_pw, db);
        
        return answer;
    }
    
    public string GetResult(string[] id_pw, string[,] db)
    {
        int size = db.Length / 2;
        string result = "fail";
        
        for (int i = 0; i < size; ++i)
        {
            if (id_pw[0] == db[i, 0])
            {
                if (id_pw[1] == db[i, 1])
                {
                    return "login";
                }
                result = "wrong pw"; 
            }
        }
        return result;
    }
}