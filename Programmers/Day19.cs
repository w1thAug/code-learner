public class Day19
{
    public int[] Quiz01(string myStr) 
    {
        // 1. 세 개의 구분자
        List<string> answer = new List<string>();
        string str = "";
        
        foreach(char c in myStr){
            if(c == 'a' || c == 'b' || c == 'c') {
                if(str != "") answer.Add(str);
                str = "";
            }
            else str += c + "";
        }
        if(str != "") answer.Add(str);
        
        if(answer.Count < 1) answer.Add("EMPTY"); 
        return answer.ToArray();
    }

    public int[] Quiz02(int[] arr) 
    {
        // 2. 배열의 원소만큼 추가하기
        List<int> answer = new List<int>();
        
        for(int i = 0; i < arr.Length; i++){
            for(int j = 0; j < arr[i]; j++)
                answer.Add(arr[i]);
        }
        return answerToArray();
    }

    public int[] Quiz03(int[] arr, bool[] flag) 
    {
        // 3. 빈 배열에 추가, 삭제하기
        List<int> answer = new List<int>();
        
        for(int i = 0; i < arr.Length; i++){
            if(flag[i])
                for(int j = 0; j < arr[i] * 2; j++) answer.Add(arr[i]);
            else
                for(int k = 0; k < arr[i]; k++) answer.RemoveAt(answer.Count - 1);
        }
        
        return answer.ToArray();
    }

    public int[] Quiz04(int[] arr) {
        // 4. 배열 만들기 6
        List<int> stk = new List<int>();
        for(int i = 0; i < arr.Length; i++){
            if(stk.Count == 0) stk.Add(arr[i]);
            else{
                if(stk[stk.Count-1] == arr[i]) stk.RemoveAt(stk.Count-1);
                else stk.Add(arr[i]);
            }
        }
        
        if(stk.Count == 0) stk.Add(-1);
        return stk.ToArray();
    }

public int[] Quiz05(int[] arr, int k) {
        // 5. 무작위로 K개의 수 뽑기
        List<int> result = new List<int>();
        int[] answer = new int[]{};
        
        foreach(int i in arr)
            if(!result.Contains(i)) result.Add(i);
        
        int count = result.Count;
        
        if(count <= k) {
            for(int j = 0; j < k-count; j++) result.Add(-1);
            answer = result.ToArray();
        }
        else
            answer = result.ToArray().Take(k).ToArray();
        
        
        return answer;
    }
}