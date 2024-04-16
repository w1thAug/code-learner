import java.util.Scanner;

public class Day02{
    public void Quiz01(){
        //1. 덧셈식 출력하기
        Scanner sc = new Scanner(System.in);
        int a = sc.nextInt();
        int b = sc.nextInt();

        System.out.println(a + " + "+ b + " = " +(a + b));
    }

    public void Quiz02(){
        //2. 문자열 붙여서 출력하기
        Scanner sc = new Scanner(System.in);
        String a = sc.next();
        String b = sc.next();
        
        System.out.println(a+b);
    }

    public void Quiz03(){
        //3. 문자열 돌리기
        Scanner sc = new Scanner(System.in);
        String a = sc.next();
        
        for(int i = 0 ; i < a.length(); i++)
            System.out.println(a.charAt(i));
    }

    public void Quiz04(){
        //4. 홀짝 구분하기
        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt();
        System.out.println(n + (n%2==0 ? " is even" : " is odd"));
    }

    public String Quiz05(String my_string, String overwrite_string, int s){
        //5. 특수문자 출력하기
        String answer = "";
        answer = my_string.substring(0, s) + overwrite_string 
            + my_string.substring(s + overwrite_string.length());
        return answer;
    }
}