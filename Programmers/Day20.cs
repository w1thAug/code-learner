public class Day20
{
    public int[] Quiz01(int[] arr) 
    {
        // 1. 배열의 길이를 2의 거듭제곱으로 만들기
        List<int> answer = new List<int>();

        int arrLen = arr.Length;
        int count = 0;
        bool isLower = true;

        while(isLower){
            if(arrLen > Math.Pow(2, count)) count++;
            else isLower = false;
        }

        foreach(int i in arr) answer.Add(i);
        for(int j = arrLen; j < Math.Pow(2, count); j++) answer.Add(0);
        return answer.ToArray();
    }

    public int Quiz02(int[] arr1, int[] arr2) {
        // 2. 배열 비교하기
        int answer = 0;
        int sub = arr1.Length - arr2.Length;
        if(sub > 0) answer = 1;
        else if(sub < 0) answer = -1;
        else {
            int sum1 = arr1.Sum();
            int sum2 = arr2.Sum();
            
            if(sum1 > sum2) answer = 1;
            else if(sum1 == sum2) answer = 0;
            else answer = -1;
        }
        return answer;
    }

    public int Quiz03(string[] strArr) {
        // 3. 문자열 묶기
        int[] strLen = new int[31];
        
        for(int i = 0; i < 31; i ++) strLen[i] = 0;
        
        foreach(string s in strArr){
            var tmp = strLen[s.Length];
            strLen[s.Length] = (tmp+=1);
        }
        
        return strLen.Max();
    }

    public int[] Quiz4(int[] arr, int n) {
        // 4. 배열의 길이에 따라 다른 연산하기
        int arrLen = arr.Length;
        
        if(arrLen % 2 == 0) 
            for(int i = 0; i < arrLen / 2; i++) arr[2*i + 1] += n;
        else
            for(int i = 0; i <= arrLen / 2; i++) arr[2*i] += n;
        
        return arr;
    }

    public int[] Quiz5(int[] num_list) {
        // 5. 뒤에서 5등까지
        return num_list.OrderBy(n => n).Skip(0).Take(5).ToArray();
    }
}