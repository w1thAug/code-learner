public class Day01
{
    public void Quiz01()
    {
        //1. 문자열 출력하기

        Console.Clear();
        var str = Console.ReadLine();
        Console.WriteLine(str);
    }

    public void Quiz02()
    {
        //2. a와 b 출력하기
        Console.Clear();
        var s = Console.ReadLine();
        String[] input;

        if(s != null){
            input = s.Split(' ');

            int a = Int32.Parse(input[0]);
            int b = Int32.Parse(input[1]);

            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
        }
    }

    public void Quiz03()
    {
        //3. 문자열 반복해서 출력하기
        Console.Clear();
        var s = Console.ReadLine();
        String[] input;

        if(s != null){
            input = s.Split(' ');

            String s1 = input[0];
            int a = Int32.Parse(input[1]);
            
            String s2 = "";
            for(int i = 0 ; i < a ; i++) s2 += s1;
            
            Console.WriteLine(s2);
        }
    }

    public void Quiz04()
    {
        //4. 대소문자 바꿔서 출력하기
        Console.Clear();
        var s = Console.ReadLine();
        
        String result = "";
        
        if(s != null)
            foreach(char c in s) result += char.IsUpper(c)? char.ToLower(c) : char.ToUpper(c);
        
        Console.WriteLine(result);
    }

    public void Quiz05()
    {
        //5. 특수문자 출력하기
        Console.WriteLine("!@#$%^&*(\\\'\"<>?:;");
    }
    
    public static void Main()
    {
        Console.WriteLine("Test Index? : ");
        var idx = Console.ReadLine();
        Day01 d = new Day01();
        if(idx != null){
            switch(Int32.Parse(idx)){
                case 1 : d.Quiz01(); break;
                case 2 : d.Quiz02(); break;
                case 3 : d.Quiz03(); break;
                case 4 : d.Quiz04(); break;
                case 5 : d.Quiz05(); break;
        }

        }
    }
}