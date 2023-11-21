namespace CODEKATAGOGO
{
        internal class Program
        {
                static void Main(string[] args)
                {
                        Console.WriteLine("Hello, World!");
                }
                public int 숫자비교(int num1, int num2)
                {
                        return num1 == num2 ? 1 : -1;
                }
                public int 두수의합(int num1, int num2)
                {
                        return num1 + num2;
                }
                public int 두수의차(int num1, int num2)
                {
                        int answer = 0;
                        return answer;
                }
                public int 두수의곱(int num1, int num2)
                {
                        return num1 * num2;
                }
                public int 두수의나눗셈(int num1, int num2)
                {
                        return (int)((num1 / (float)num2) * 1000);
                }
                public string 짝수와홀수(int num)
                {
                        return num % 2 == 0 ? "Even" : "Odd";
                }
                public int 자릿수더하기(int n)
                {
                        return n.ToString().Select(x => int.Parse(x.ToString())).Sum();
                }
                public int 짝수의합(int n)
                {
                        int answer = 0;
                        for (int i = 0; i <= n; i++)
                        {
                                if (i % 2 == 0) answer += i;
                        }
                        return answer;
                }
                public int 약수의합(int n)
                {
                        int x = 0;
                        for (int i = 1; i <= n; i++)
                        {
                                if (n % i == 0) x += i;
                        }
                        return x;
                }
                public double 평균구하기(int[] arr)
                {
                        return arr.Average();
                }
                public double 배열의평균값(int[] numbers)
                {
                        return numbers.Average();
                }
                public int 나머지가1이되는수찾기(int n)
                {
                        for (int i = 1; i < n; i++)
                        {
                                if (n % i == 1) return i;
                        }
                        return n;
                }
                public int 몫구하기(int num1, int num2)
                {
                        return (int)num1 / num2;
                }
                public int 나이출력(int age)
                {
                        int answer = 2023 - age;
                        return answer;
                }
                public int 각도기(int angle)
                {
                        if (angle < 90) return 1;
                        else if (angle == 90) return 2;
                        else if (angle < 180) return 3;
                        else return 4;
                }
                public long[] x만큼간격있는n개의숫자(int x, int n)
                {
                        var answer = new long[n];
                        for (int i = 0; i < n; i++)
                        {
                                answer[i] = x * (i + 1);
                        }
                        return answer;
                }
                public int[] 자연수뒤집어배열로만들기(long n)
                {
                        return n.ToString().Select(x => int.Parse(x.ToString())).Reverse().ToArray();
                }
                public int 문자열정수로바꾸기(string s)
                {

                        if (int.TryParse(s, out int result)) s.Remove(0, 1); //의미가 없네 ㅋㅋ 

                        return int.Parse(s);
                }
                public long 정수제곱근판별(long n)
                {
                        long x = (long)Math.Sqrt(n);
                        return x * x == n ? ++x * x : -1;
                }
        }
}