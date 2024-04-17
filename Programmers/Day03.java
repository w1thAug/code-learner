public class Day02{
    public String Quiz01(String str1, String str2){
        //1. 문자열 섞기
        String answer = "";
        for(int i = 0; i < str1.length(); i++){
            answer += str1.charAt(i);
            answer += str2.charAt(i);
        }
        return answer;
    }

    public String Quiz02(String[] arr){
        //2. 문자 리스트를 문자열로 반환하기
        String answer = "";
        for(int i = 0; i < arr.length; i++){
            answer += arr[i];
        }
        return answer;
    }

    public String Quiz03(String my_string, int k){
        //3. 문자열 곱하기
        String answer = "";
        while(k > 0){
            answer += my_string;
            k--;
        }
        return answer;
    }

    public int Quiz04(int a, int b){
        //4. 더 크게 합치기
        int ab = Integer.parseInt((Integer.toString(a) + Integer.toString(b)));
        int ba = Integer.parseInt((Integer.toString(b) + Integer.toString(a)));
        return ab > ba ? ab : ba;
    }

    public String Quiz05(int a, int b){
        //5. 두 수의 연산값 비교하기
        int ab = Integer.parseInt(a + "" + b);
        int ba = 2 * a * b;
        return Math.max(ab, ba);
    }
}