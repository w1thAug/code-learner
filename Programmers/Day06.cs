public class Day06
{
    public int[] Quiz01(int[] num_list) 
    {
        // 1. 마지막 두 원소
        int lastIdx = num_list.Length - 1;
        int addElement = num_list[lastIdx] > num_list[lastIdx - 1] 
            ? num_list[lastIdx] - num_list[lastIdx - 1] : num_list[lastIdx] * 2;
                
        Array.Resize(ref num_list, lastIdx + 2);
        num_list[lastIdx + 1] = addElement;
        
        return num_list;
    }

    public int Quiz02(int n, string control)
    {
        // 2. 수 조작하기 1
        foreach(char c in control){
            switch(c){
                case 'w': n += 1; break;
                case 's': n -= 1; break;
                case 'd': n += 10; break;
                case 'a': n -= 10; break;
            }
        }
        return n;
    }

    public string Quiz03(int[] numLog) 
    {
        // 3. 수 조작하기 2
        string answer = "";
        
        for(int i = 1; i < numLog.Length; i++){
            switch(numLog[i] - numLog[i-1]){
                case 1 : answer += "w"; break;
                case -1 : answer += "s"; break;
                case 10 : answer += "d"; break;
                case -10 : answer += "a"; break;
            }
        }
        
        return answer;
    }

    public int[] Quiz04(int[] arr, int[,] queries)
    {
        //4. 수열과 구간 쿼리 3
        for(int i = 0; i < queries.GetLength(0); i++){
            int a = queries[i, 0];
            int b = queries[i, 1];

            (arr[b], arr[a]) = (arr[a], arr[b]);
        }
        return arr;
    }

    public int[] Quiz05(int[] arr, int[,] queries)
    {
        //5. 수열과 구간 쿼리 2
        
        int[] answer = new int[queries.GetLength(0)];
        
        for(int j = 0; j < queries.GetLength(0); j++){
            List<int> tmp = new List<int>();
            
            int s = queries[j, 0];
            int e = queries[j, 1];
            int k = queries[j, 2];
            
            for(int i = s; i < e + 1; i++) 
                if(arr[i] > k) tmp.Add(arr[i]);
            
            if(tmp.Count > 1) answer[j] = tmp.Min();
            else if(tmp.Count == 1) answer[j] = tmp[0];
            else answer[j] = -1;
        }
        
        return answer;
    }
}