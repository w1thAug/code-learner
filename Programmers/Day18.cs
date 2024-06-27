public class Day18
{
    public int[] Quiz01(string myString) 
    {
        // 1. x 사이의 개수
        List<int> answer = new List<int>();
        int count = 0;

        foreach(char c in myString){
            if(c == 'x') {
                answer.Add(count);
                count = 0;
            }
            else count++;
        }

        answer.Add(count);
        return answer.ToArray();

        //return myString.Split('x').Select(x => x.Length).ToArray();
    }

    public string[] Quiz02(string myString) 
    {
        // 2. 문자열 잘라서 정렬하기
        return myString.Split("x").Where(x=> x.Length > 0).OrderBy(x=>x).ToArray();
    }

    public string[] Quiz03(string binomial) 
    {
        // 3. 간단한 식 계산하기
        string[] binomialList = binomial.Split(" ");

        int answer = 0;
        int a = Int32.Parse(binomialList[0]);
        int b = Int32.Parse(binomialList[2]);
        
        switch(binomialList[1]){
            case "+" : answer = a + b; break;
            case "-" : answer = a - b; break;
            case "*" : answer = a * b; break;
        }

        return answer;
    }

    public string Quiz04(string myString, string pat)
    {
        //4. 문자열 바꿔서 찾기
        string reverseStr = "";
        foreach(char c in myString) {
            if(c == 'A') reverseStr += "B";
            else reverseStr += "A";
        }
        return reverseStr.Contains(pat) ? 1 : 0;
    }

    public int Quiz05(string rny_string)
    {
        //5. rny_string
        return rny_string.Replace("m", "rn");
    }
}