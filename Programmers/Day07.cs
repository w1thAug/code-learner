public class Day07
{
    public int[] Quiz01(int[] arr, int[,] queries) 
    {
        // 1. 수열과 구간 쿼리 4
        int[] answer = arr;
        
        for(int j = 0; j < queries.GetLength(0); j++){
            int s = queries[j, 0];
            int e = queries[j, 1];
            int k = queries[j, 2];
            
            for(int i = s; i <= e; i++)
                if(i % k == 0) answer[i] += 1;
        }
        
        return answer;
    }

    public int[] Quiz02(int l, int r)
    {
        // 2. 배열 만들기 2
        List<int> answer = [];
        
        for(int i = l; i <= r; i++){
            string tmp = i + "";
            int tmpLen = tmp.Length;
            
            foreach(Char c in tmp) 
                if(c == '0' || c == '5') tmpLen--;
            
            if(tmpLen == 0) answer.Add(Int32.Parse(tmp));
        }
        
        if(answer.Count == 0) answer.Add(-1);
        
        return [.. answer];
    }

    public int[] Quiz03(int start_num, int end_num) 
    {
        // 3. 카운트 업
        int[] answer = new int[end_num - start_num + 1];
        int idx = 0;
        
        for(int i = start_num; i <= end_num; i++) {
            answer[idx] = i;
            idx++;
        }
        
        return answer;
    }

    public int[] Quiz04(int n)
    {
        //4. 콜라츠 수열 만들기
        List<int> answer = [n];
        
        while(n > 1){
            if(n % 2 == 0) n /= 2;
            else n = 3*n + 1;     
            answer.Add(n);
        }

        return [.. answer];
    }

    public int[] Quiz05(int[] arr)
    {
        //5. 배열 만들기 4
        List<int> stk = [];
        int idx = 0;
        
        while(idx < arr.Length){
            if(stk.Count == 0 || stk[stk.Count - 1] < arr[idx]) {
                stk.Add(arr[idx]);
                idx++;
            }
            else if(stk[stk.Count - 1] >= arr[idx]) stk.RemoveAt(stk.Count - 1);
        }    
   
        return [.. stk];
    }
}