public class Day13
{
    public int[] Quiz01(int[] num_list, int n) {
        // 1. n번째 원소부터
        return num_list.ToList().Skip(n-1).ToArray();
    }

    public int[] Quiz02(int[] num_list, int n)
    {
        // 2. 순서 바꾸기
        int[] tmp1 = num_list.ToList().Skip(n).ToArray();
        int[] tmp2 = num_list.ToList().Take(n).ToArray();
        
        int[] answer = tmp1.Concat(tmp2).ToArray();
        
        return answer;
    }

    public string[] Quiz03(string[] str_list) 
    {
        // 3. 왼쪽 오른쪽
        string[] answer = [];
        bool isCharFound = false;
        
        int idxL = Array.IndexOf(str_list, "l");
        int idxR = Array.IndexOf(str_list, "r");
        
        for(int i = 0; i < str_list.Length; i++){
            if(!isCharFound){
                if(str_list[i] == "l") {
                    answer = str_list.ToList().Take(idxL).ToArray();
                    isCharFound = true;
                }
                else if(str_list[i] == "r"){
                    answer = str_list.ToList().Skip(idxR + 1).ToArray();
                    isCharFound = true;
                }
            }
        }
        return answer;
    }

    public int[] Quiz04(int[] num_list, int n)
    {
        //4. n번째 원소까지
        int[] answer = [];
        answer = num_list.ToList().Take(n).ToArray();
        
        return answer;
    }

    public int[] Quiz05(int[] num_list, int n)
    {
        //5. n개 간격의 원소들
        List<int> answer = [];
        int intervalCount = 0;
        
        for(int i = 0; i < num_list.Length; i++){
            if(intervalCount == 0) answer.Add(num_list[i]);
            intervalCount++;
            if(intervalCount == n) intervalCount = 0;
        }
        
        return [.. answer];
    }
}