public class Day14
{
    public int Quiz01(int[] num_list) {
        // 1. 홀수 vs 짝수
        int oddSum = 0;
        int evenSum = 0;
        
        for(int i = 0; i < num_list.Length; i++){
            if(i%2==0) evenSum += num_list[i];
            else oddSum += num_list[i];
        }
        
        return oddSum >= evenSum ? oddSum : evenSum;
    }

    public string[] Quiz02(string[] names)
    {
        // 2. 5명씩
        List<string> answer = new List<string>();
        
        for(int i = 0; i < names.Length; i++)
            if(i % 5 == 0) answer.Add(names[i]);
        
        return answer.ToArray();
    }

    public string[] Quiz03(string[] todo_list, bool[] finished) 
    {
        // 3. 할 일 목록
        List<string> answer = new List<string>();
        
        for(int i = 0; i < finished.Length; i++)
            if(!finished[i]) answer.Add(todo_list[i]);
        
        return answer.ToArray();
    }

    public int Quiz04(int[] numbers, int n)
    {
        //4. n보다 커질 때까지 더하기
        int answer = 0;
        for(int i = 0; i < numbers.Length; i++){
            answer += numbers[i];
            if(answer > n) break;
        }
        return answer;
    }

    public int[] Quiz05(int[] arr, int[,] queries)
    {
        //5. 수열과 구간 쿼리 1
        for(int i = 0; i < queries.GetLength(0); i++){
            for(int j = queries[i,0]; j<= queries[i,1]; j++) arr[j] += 1;
        }
        return arr;
    }
}