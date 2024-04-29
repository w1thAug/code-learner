public class Day12
{
    public int[] Quiz01(int n, int[] slicer, int[] num_list) {
        // 1. 리스트 자르기
        List<int> answer = [];
        
        int a = slicer[0];
        int b = slicer[1];
        int c = slicer[2];
        
        switch(n){
            case 1: 
                for(int i = 0; i <= b; i++) answer.Add(num_list[i]);
                break;
                
            case 2:
                for(int i = a; i < num_list.Length; i++) answer.Add(num_list[i]);
                break;
                
            case 3: 
                for(int i = a; i <= b; i++) answer.Add(num_list[i]);
                break;
                
            case 4:
                for(int i = a; i <= b; i++) if(i % c == a % c) answer.Add(num_list[i]);
                break;
        }
        
        return [.. answer];
    }

    public int Quiz02(int[] num_list)
    {
        // 2. 첫 번째로 나오는 음수
        int answer = 0;
        bool foundAnswer = false;
        
        for(int i = 0 ; i < num_list.Length; i++){
            if(num_list[i] < 0 && !foundAnswer) {
                answer = i;
                foundAnswer = true;
            }
        }
            
        if(!foundAnswer)answer = -1;
        return answer;
    }

    public int[] Quiz03(int[] arr, int[,] intervals) 
    {
        // 3. 배열 만들기 3
        List<int> answer = [];
        List<int> TakeResult = [];
        
        for(int i = 0; i < 2 ; i++){
            TakeResult.Clear();
            TakeResult = arr.Take(intervals[i, 1] + 1).Skip(intervals[i, 0]).ToList();
            foreach(int j in TakeResult) answer.Add(j);
        }
        
        return [.. answer];
    }

    public int[] Quiz04(int[] arr)
    {
        //4. 2의 영역
        List<int> indices = [];
        List<int> answer = [];
        
        for(int i = 0; i < arr.Length; i++)
            if(arr[i] == 2) indices.Add(i);
        
        if(indices.Count != 0)
            answer = arr.ToList().Take(indices[indices.Count - 1] + 1).Skip(indices[0]).ToList();
        else answer.Add(-1);
        
        return [.. answer];
    }

    public int[] Quiz05(int[] arr, int[] query)
    {
        //5. 배열 조각하기
        for(int i = 0; i < query.Length; i++){
            if(i % 2 == 0) arr = arr.ToList().Take(query[i] + 1).ToArray();
            else arr = arr.ToList().Skip(query[i]).ToArray();
        }
        return arr;
    }
}