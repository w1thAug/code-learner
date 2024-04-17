public class Day04
{
    public int Quiz01(int num, int n) 
    {
        // 1. n의 배수
        int answer = num % n == 0 ? 1 : 0;
        return answer;
    }

    public int Quiz02(int number, int n, int m) 
    {
        // 2. 공배수
        int answer = number%n == 0 && number%m == 0 ? 1 : 0;
        return answer;
    }

    public int Quiz03(int n) 
    {
        // 3. 홀짝에 따라 다른 값 반환하기
        int answer = 0;
        while(n>0){
            answer += n%2==0 ? n*n : n;
            n -= 2;
        }
        return answer;
    }

    public int Quiz04(string ineq, string eq, int n, int m)
    {
        //4. 조건 문자열
        string s = ineq + eq;
        int answer = 0;
        switch(s){
            case "<=" : answer = n<=m ? 1 : 0; break;
            case "<!" : answer = n<m ? 1 : 0; break;
            case ">=" : answer = n>=m ? 1 : 0; break;
            case ">!" : answer = n>m ? 1 : 0; break;
        }
        return answer;
    }

    public int Quiz05(int a, int b, bool flag)
    {
        //5. flag에 따라 다른 값 반환하기
        int answer = flag ? a+b : a-b;
        return answer;
    }
}