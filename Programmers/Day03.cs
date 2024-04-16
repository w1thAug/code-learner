public class Day03
{
    public string Quiz01(string str1, string str2) 
    {
        // 1. 문자열 섞기
        string answer = "";
        for(int i = 0; i < str1.Length; i++){
            answer += str1[i];
            answer += str2[i];
        }
        return answer;
    }

    public string Quiz02(string[] arr) 
    {
        // 2. 문자 리스트를 문자열로 변환하기
        string answer = "";
        foreach(string s in arr) answer += s;
        return answer;
    }

    public string Quiz03(string my_string, int k) 
    {
        // 3. 문자열 곱하기
        string answer = "";
        for(int i = 0; i < k; i++) answer += my_string;
        return answer;
    }

    public int Quiz04(int a, int b)
    {
        //4. 더 크게 합치기
        int aa = Int32.Parse(a.ToString() + b.ToString());
        int bb = Int32.Parse(b.ToString() + a.ToString());
        return aa >= bb ? aa : bb;
    }

    public int Quiz05(int a, int b)
    {
        //5. 두 수의 연산값 비교하기
        int aa = Int32.Parse($"{a}{b}");
        int bb = 2 * a * b;
        return Math.Max(aa, bb);
    }
}