public class Day15
{
    public int[] Quiz01(int[] arr) 
    {
        // 1. 조건에 맞게 수열 변환하기1
        List<int> answer = new List<int>();
        
        foreach(int i in arr){
            if(i >= 50 && i % 2 == 0) answer.Add(i / 2);
            else if(i < 50 && i % 2 == 1) answer.Add(i * 2);
            else answer.Add(i);
        }
        return answer.ToArray();
    }

    public int Quiz02(int[] arr) 
    {
        // 2. 조건에 맞게 수열 변환하기2
        int answer = 0;
        
            List<int> tmp1 = new List<int>();
            List<int> tmp2 = new List<int>();

            tmp1 = arr.ToList();
            
            bool isLoop = true;
            
            while(isLoop){
                foreach(int i in tmp1){
                    if(i >= 50 && i % 2 == 0) tmp2.Add(i / 2);
                    else if(i < 50 && i % 2 == 1) tmp2.Add(i*2 + 1);
                    else tmp2.Add(i);
                }

                if(tmp1.SequenceEqual(tmp2)) {
                    isLoop = false;
                }
                else{
                    tmp1.Clear();
                    foreach(int i in tmp2) tmp1.Add(i);
                    tmp2.Clear();
                    answer++;
                }
            }
        
        return answer; 
    }

    public int Quiz03(int[] num_list) 
    {
        // 3. 1로 만들기
        int answer = 0;
        
        foreach(int i in num_list){

            int num = i;
            
            while(num > 1){
                answer++;
                if(num % 2 == 0) num = num / 2;
                else num = (num-1) /2;
            }
        }
        return answer;
    }

    public int Quiz04(int[] num_list)
    {
        //4. 길이에 따른 연산
        int answer = 0;
        if(num_list.Length >= 11)
            foreach(int i in num_list) answer += i;
        
        else
        {
            answer += 1;
            foreach(int i in num_list) answer *= i;
        }

        return answer;
    }

    public int Quiz05(string myString, string pat)
    {
        //5. 원하는 문자열 찾기
        if(myString.ToUpper().Contains(pat.ToUpper())) return 1;
        else return 0;
    }
}