public class Day11
{
    public int[] Quiz01(string my_string) {
        // 1. 문자 개수 세기
        int[] answer = new int[52];
        
        foreach(char c in my_string){
            if(char.IsUpper(c))
                answer[c-65] += 1;
            else answer[c-97+26] += 1;
        }
        
        return answer;
    }

    public int[] Quiz02(int n, int k)
    {
        // 2. 배열 만들기 1
        List<int> answer = [];
        
        for(int i = 0; i < (n/k); i++)
            answer.Add(k * (i+1));
        
        return [.. answer];
    }

    public string Quiz03(string my_string, int[] indices) 
    {
        // 3. 글자 지우기
        string answer = "";
        
        List<int> reverseIndices = new List<int>();
            
        for(int i = 0; i < my_string.Length; i++)
            if(!Array.Exists(indices, n => n == i)) reverseIndices.Add(i);


        foreach(int i in reverseIndices) answer += my_string[i] + "";
        
        return answer;
    }

    public int[] Quiz04(int start, int end_num)
    {
        //4. 카운트 다운
        List<int> answer = [];
        
        for(int i = start; i >= end_num; i--) answer.Add(i);
        
        return [.. answer];
    }

    public int Quiz05(int[] arr, int idx)
    {
        //5. 가까운 1 찾기
        int index = 0;
        return Array.FindIndex(arr,x => index++ >=idx && x == 1);
    }
}