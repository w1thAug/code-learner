public class Day05
{
    public string Quiz01(string code) 
    {
        // 1. 코드 처리하기
        string ret = "";
        int mode = 0;
        
        for(int i = 0; i < code.Length; i++){
            if(mode == 0){
                if(code[i].ToString() == "1") mode = 1;
                else { if(i % 2 == 0) ret += code[i]; }
            } else {
                if(code[i].ToString() == "1") mode = 0;
                else { if(i % 2 == 1) ret += code[i]; }
            }
        }
        
        if(ret == "") return "EMPTY";
        else return ret;
    }

    public int Quiz02(int a, int d, bool[] included) 
    {
        // 2. 등차수열의 특정한 항만 더하기
        int answer = 0;
        for(int i = 0; i < included.Length; i++){
            if(included[i]) answer += a + d * i;
        }
        return answer;
    }

    public int Quiz03(int a, int b, int c) 
    {
        // 3. 주사위 게임 2
        int answer;
        
        if (a==b && b==c) answer = (a + b + c) * (a*a + b*b + c*c) * (a*a*a + b*b*b + c*c*c);
        else if(a==b || b==c || a==c) answer = (a + b + c) * (a*a + b*b + c*c);
        else answer = a + b + c;
        
        return answer;
    }

    public int Quiz04(int[] num_list)
    {
        //4. 원소들의 곱과 합
        int a = 1;
        int b = 0;
        
        for(int i = 0; i < num_list.Length; i++){
            a *= num_list[i];
            b += num_list[i];
        }
        
        return a > b*b ? 0 : 1;
    }

    public int Quiz05(int[] num_list)
    {
        //5. 이어 붙인 수
        string odd = "";
        string even = "";
        
        for(int i = 0; i < num_list.Length; i++){
            if(num_list[i] % 2 == 1) odd += num_list[i].ToString();
            else even += num_list[i].ToString();
        }
        
        return Int32.Parse(odd) + Int32.Parse(even);
    }
}