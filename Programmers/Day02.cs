public class Day02
{
    public void Quiz01()
    {
        //1. 덧셈식 출력하기
        Console.Clear();
        var s = Console.ReadLine();
        string[] input;

        if(s!=null){
            input = s.Split(' ');

            int a = Int32.Parse(input[0]);
            int b = Int32.Parse(input[1]);

            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        }
    }

    public void Quiz02()
    {
        //2. 문자열 붙여서 출력하기
        Console.Clear();
        var s = Console.ReadLine();
        String[] input;

        if(s != null){
            input = s.Split(' ');

            String s1 = input[0];
            String s2 = input[1];

            Console.WriteLine(s1 + s2);
        }
    }

    public void Quiz03()
    {
        //3. 문자열 돌리기
        Console.Clear();
        var s = Console.ReadLine();
        
        if(s!=null)
            foreach(Char c in s) Console.WriteLine(c);
    }

    public void Quiz04()
    {
        //4. 홀짝 구분하기
        Console.Clear();
        var s = Console.ReadLine();

        if(s != null){
            int a = Int32.Parse(s);        
            string result = a.ToString() + (a%2== 0 ? " is even" : " is odd");
            
            Console.WriteLine(result);
        }
    }

    public string Quiz05(string my_string, string overwrite_string, int s)
    {
        //5. 문자열 겹쳐쓰기
        string answer = my_string.Substring(0, s) + overwrite_string + my_string.Substring(s + overwrite_string.Length);
        return answer;
    }
}