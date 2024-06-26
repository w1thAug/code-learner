public class Day17
{
    public string Quiz01(string myString, string pat) 
    {
        // 1. 특정 문자열로 끝나는 가장 긴 부분 문자열 찾기
        int index = myString.LastIndexOf(pat) + pat.Length;
        return myString.Substring(0, index);
    }

    public string Quiz02(string myString, string pat) 
    {
        // 2. 문자열이 몇 번 등장하는지 세기
            int answer = 0;
            int index = -1;
            int prevIndex = myString.Length;

            while(index != prevIndex){
                var tmpString = myString.Substring(index + 1);
                prevIndex = index;
                index = tmpString.IndexOf(pat) + index + 1;
                if(index != prevIndex) answer += 1;
            }

        return answer;
    }

    public string[] Quiz03(string[] strArr) 
    {
        // 3. ad 제거하기
        List<string> answer = new List<string>();
        for(int i = 0; i < strArr.Length; i++)
            if(!strArr[i].Contains("ad")) answer.Add(strArr[i]);
        return answer.ToArray();
    }

    public string Quiz04(string my_string)
    {
        //4. 공백으로 구분하기 1
        return my_string.Split(' ');
    }

    public int Quiz05(string my_string)
    {
        //5. 공백으로 구분하기 2
        List<string> tmp = new List<string>();
        List<string> answer = new List<string>();
        List<int> notBlankIndex = new List<int>();

        tmp = my_string.Split(" ").ToList();

        for(int i = 0; i < tmp.Count; i++)
            if(!String.IsNullOrEmpty(tmp[i])) notBlankIndex.Add(i);

        foreach(int i in notBlankIndex) answer.Add(tmp[i]);
        return answer.ToArray();

        //return my_string.Split().Where(w => !string.IsNullOrWhiteSpace(w)).ToArray();
    }
}