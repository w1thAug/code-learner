public class Day15
{
    public string Quiz01(string myString) 
    {
        // 1. 대문자로 바꾸기
        return myString.ToUpper();
    }

    public string Quiz02(string myString) 
    {
        // 2. 소문자로 바꾸기
        return myString.ToLower();
    }

    public string[] Quiz03(stringp[ strArr]) 
    {
        // 3. 배열에서 문자열 대소문자 변환하기
        List<string> answer = new List<string>();
        for(int i = 0; i < strArr.Length; i++){
            if(i%2==1) answer.Add(strArr[i].ToUpper());
            else answer.Add(strArr[i].ToLower());
        }
        return answer.ToArray();
    }

    public string Quiz04(string myString)
    {
        //4. A 강조하기
        string answer = "";
        foreach(char c in myString){
            if(c == 'a' || c == 'A') answer += "A";
            else answer += c.ToString().ToLower();
        }
        return answer;
    }

    public int Quiz05(string my_string, string alp)
    {
        //5. 특정한 문자를 대문자로 바꾸기
        string answer = "";
        foreach(char c in my_string){
            if(c.ToString() == alp) answer += c.ToString().ToUpper();
            else answer += c;
        }
        return answer;
    }
}