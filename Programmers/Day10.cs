public class Day10
{
    public string Quiz01(string my_string, int n) {
        // 1. 문자열의 앞의 n글자
        return my_string[..n];
    }

    public int Quiz02(string my_string, string is_prefix)
    {
        // 2. 접두사인지 확인하기
        List<string> prefix = new List<string>();
        
        for(int i = 0; i < my_string.Length; i++)
            prefix.Add(my_string.Substring(0, i));
        
        if(prefix.Contains(is_prefix)) return 1;
        else return 0;
    }

    public string Quiz03(string my_string, int s, int e) 
    {
        // 3. 문자열 뒤집기
        string reverse = "";
        
        for(int i = e; i >= s; i--)
            reverse += my_string[i] + "";

        string answer = string.Concat(my_string.AsSpan(0, s), reverse, my_string.AsSpan(e + 1));
        return answer;
    }

    public string Quiz04(string my_string, int m, int c)
    {
        //4. 세로 읽기
        string answer = "";
        
        int strLeng = my_string.Length;
        int rest = (strLeng % m >= c ? 1 : 0);
        
        for(int i = 0; i < strLeng / m + rest; i++)
            answer += my_string[m*i + c - 1] + "";
        
        return answer;
    }

    public string Quiz05(int q, int r, string code)
    {
        //5. qr code
        string answer = "";
        
        for(int i = 0; i < code.Length; i++)
            if(i % q == r) answer += code[i] + "";
        
        return answer;
    }
}