public class Day08
{
    public bool Quiz01(bool x1, bool x2, bool x3, bool x4) 
    {
        // 1. 간단한 논리 연산
        bool answer = (x1 || x2) && (x3 || x4);
        return answer;
    }

    public int Quiz02(int a, int b, int c, int d)
    {
        // 2. 주사위 게임 3
        int answer = 0;
        List<int> inputList = [a, b, c, d];
        List<int> countList = inputList.Distinct().ToList();
        
        switch(countList.Count){
            case 1: answer = a * 1111; break;
            case 2: 
                int p2 = countList[0];
                int q2 = countList[1];

                int pCount = inputList.Where(n => n == p2).Count();
                
                if(pCount == 3) answer = (10 * p2 + q2) * (10 * p2 + q2);
                else if(pCount == 2) answer = (p2 + q2) * Math.Abs(p2 - q2);
                else answer = (10 * q2 + p2) * (10 * q2 + p2);
                break;
                
            case 3: 
                List<int> duplication = inputList.GroupBy(x => x).Where(n => n.Count() > 1)
                                    .Select(x => x.Key).ToList();
                int p3 = duplication[0];
                
                countList.Remove(p3);
                int q3 = countList[0];
                int r3 = countList[1];
                
                answer = q3 * r3;
                break;
            case 4: answer = inputList.Min(); break;
        }
        
        return answer;
    }

    public string Quiz03(string my_string, int[] index_list) 
    {
        // 3. 글자 이어 붙여 문자열 만들기
        string answer = "";
        foreach(int i in index_list) answer += my_string[i];
        return answer;
    }

    public int Quiz04(string number)
    {
        //4. 9로 나눈 나머지
        int answer = 0;
        for(int i = 0; i < number.Length; i++) answer += int.Parse(number[i] + "");
        answer %= 9;
        return answer;
    }

    public string Quiz05(string my_string, int[,] queries)
    {
        //5. 문자열 여러 번 뒤집기
        for(int i = 0; i < queries.GetLength(0); i++){
            
                string reverse = "";
                
                int s = queries[i, 0];
                int e = queries[i, 1];

                for(int j = e; j >= s; j--) reverse += my_string[j];
                
                my_string = my_string.Substring(0, s) + reverse + my_string.Substring(e + 1);
        }
        
        return my_string;
    }
}