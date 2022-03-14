using System;

namespace catchnumbers
{
    class Program
    {
        static void Main(string[] args)
        { Random random = new Random();
            int[] numbers =new int [1]; // 처음에는 new int [0]라고 적었는데 new int [1]은 배열 한개를 의미 [2]는 두개 [0]은 0개다. 시작은 [0]번서 부터 시작하지만 배열 1개를 만들고 싶다면 1부터
                                   // 시작했어야 한다.)
            Console.WriteLine("수비수가 1부터 100까지 숫자를 하나 고릅니다.");
            numbers[0] =  random.Next(1,101); // 두번째에서는 배열을 사용하지 않았다. 배열에 문제가 있어 그랬다. 원인을 찾지는 못했다.
            int attack = 0;
            while (true)
            {
                Console.WriteLine("숫자를 입력하세요.");
                 attack= int.Parse(Console.ReadLine());
                
                if (numbers[0] > attack)
                {
                    Console.WriteLine("선택하신 숫자는 더 작은 숫자입니다.");
                    continue; // while 문의 처음으로 돌아가게 만들어준다.
                }
                if  (numbers[0] < attack)
                {
                    Console.WriteLine("선택하신 숫자는 더 작은 숫자입니다.");
                    continue; 
                }
                if  (numbers[0] == attack)
                {
                    Console.WriteLine("정답입니다.");
                    break;
                }
            }
           
         
        }
    }
}