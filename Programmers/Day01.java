import java.util.Scanner;

public class Day01{
    public void Quiz01(){
        //1. 문자열 출력하기
        Scanner sc = new Scanner(System.in);
        String a = sc.next();
        System.out.println(a);
    }

    public void Quiz02(){
        //2. a와 b 출력하기
        Scanner sc = new Scanner(System.in);
        int a = sc.nextInt();
        int b = sc.nextInt();

        System.out.println("a = " + a);
        System.out.println("b = " + b);
    }

    public void Quiz03(){
        //3. 문자열 반복해서 출력하기
        Scanner sc = new Scanner(System.in);
        String str = sc.next();
        String answer = "";
        int n = sc.nextInt();
        
        for(int i = 0; i < n; i++) answer += str;
        System.out.println(answer);
    }

    public void Quiz04(){
        //4. 대소문자 바꿔서 출력하기
        Scanner sc = new Scanner(System.in);
        String a = sc.next();
        String answer = "";
        
        for(char x : a.toCharArray()){
            if(Character.isUpperCase(x)) x = Character.toLowerCase(x);
            else x = Character.toUpperCase(x);
            answer += x;
        }
        
        System.out.println(answer);
    }

    public void Quiz05(){
        //5. 특수문자 출력하기
        System.out.println("!@#$%^&*(\\'\"<>?:;");
    }
}