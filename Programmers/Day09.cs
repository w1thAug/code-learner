public class Day09
{
    public int[] Quiz01(string[] intStrs, int k, int s, int l) 
    {
        // 1. 간단한 논리 연산
        List<int> answer = [];
        
        foreach(string str in intStrs){
            int i = int.Parse(str.Substring(s, l));
            if(i > k) answer.Add(i);
        }
        
        return [.. answer];
    }

    public string Quiz02(string[] my_strings, int[,] parts)
    {
        // 2. 부분 문자열 이어 붙여 문자열 만들기
        string answer = "";
        
        for(int i = 0; i < my_strings.Length; i++){
            int s = parts[i, 0];
            int e = parts[i, 1];
            
            answer += my_strings[i].Substring(s, e-s+1);
        }
        
        return answer;
    }

    public string Quiz03(string my_string, int n) 
    {
        // 3. 문자열의 뒤의 n글자
        return my_string.Substring(my_string.Length - n);
    }

    public string[] Quiz04(string my_string)
    {
        //4. 접미사 배열
        List<string> dupAnswer = [];
        
        int strLength = my_string.Length;
        
        for(int i = 0; i < strLength; i++)
            dupAnswer.Add(my_string.Substring(i));
        
        string[] answer = dupAnswer.Distinct().ToArray();
        Array.Sort(answer);
        
        return answer;
    }

    public int Quiz05(string my_string, string is_suffix)
    {
        //5. 접미사인지 확인하기
        List<string> dupSuffix = [];
        
        int strLength = my_string.Length;
        
        for(int i = 0; i < strLength; i++)
            dupSuffix.Add(my_string.Substring(i));
        
        string[] suffix = dupSuffix.Distinct().ToArray();
        if(suffix.Contains(is_suffix)) return 1;
        else return 0;
    }
}