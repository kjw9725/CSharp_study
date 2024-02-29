namespace CSharp
{
     class Program
    {
        enum Choice
        {
            //가위바위보 0: 가위, 1: 바위, 2: 보
            // enum으로 선언했을때는 (int)Choice.SCISSOR 이런식으로 호출하고 static안에 선언했을때는 SCISSOR 이런식으로 표기
            ROCK = 1,
            PAPER = 2,
            SCISSOR = 0
        }
        static void Main(string[] args)
        {
            Console.WriteLine("switch, if문");
            Console.WriteLine("0: 가위, 1: 바위, 2: 보");
            Random rand = new Random();
            int aiChoice = rand.Next(0, 3);
            int choice = Convert.ToInt32(Console.ReadLine());


            // switch, if문 활용
            switch (aiChoice)
            {
                case (int)Choice.SCISSOR: 
                    Console.WriteLine("상대는 가위입니다");
                    break;
                case (int)Choice.ROCK:
                    Console.WriteLine("상대는 바위입니다");
                    break;
                case (int)Choice.PAPER:
                    Console.WriteLine("상대는 보입니다");
                    break;
            }

            if (choice == aiChoice)
            {
                Console.WriteLine("무승부 입니다");
            }
            else if (choice == (int)Choice.ROCK && aiChoice == (int)Choice.SCISSOR)
            {
                Console.WriteLine("이겼습니다");
            }

            else if (choice == (int)Choice.ROCK && aiChoice == (int)Choice.PAPER)
            {
                Console.WriteLine("졌습니다");
            }

            else if (choice == (int)Choice.SCISSOR && aiChoice == (int)Choice.ROCK)
            {
                Console.WriteLine("졌습니다");
            }
            else if (choice == (int)Choice.SCISSOR && aiChoice == (int)Choice.PAPER)
            {
                Console.WriteLine("이겼습니다");
            }
            else if (choice == (int)Choice.PAPER && aiChoice == (int)Choice.ROCK)
            {
                Console.WriteLine("이겼습니다");
            }
            else
            {
                Console.WriteLine("졌습니다");
            }


            //while
            Console.WriteLine("while문");
            int count = 5;

            while(count > 0)
            {
                Console.WriteLine("Hello World");
                count--;
            }

            //거울아 거울아
            string answer;
            do
            {
                Console.WriteLine("강사님은 잘생기셨나요(y/n)");
                answer = Console.ReadLine();
            } while (answer != "y");

            Console.WriteLine("정답입니다");

            // 메소드 함수
            // 한정자 반환형식 이름(매개변수목록){}

            // 한정자
            // - 가시성 한정자: 외부에서 접근 가능한지 여부 결정 ex) public, private, protected, internal등
            // - 기타 한정자: static = 정적 함수, virtual = 가상 함수

            // 반환 형식
            // void: 어떤값을 반환(return)하지 않을때 사용
            // ref: 객체(object)나 배열(array)같은 참조유형을 반환할때 사용
            // int: 특정 값을 계산하거나 그 값을 반환할때
            // 참조형식 반환: 클래스, 구조체, 배열등의 참조형식을 반환 (따로 반환형식을 기입하지않는다)
            static int Add(int a, int b)
            {
                return a + b;
            }
            Console.WriteLine(Add(1, 2));// Program.Add(); 둘다 가능



            //구구단
            Console.WriteLine("구구단");

            for(int i = 2; i < 10; i++)
            {
                for(int j =1; j < 10; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i *j}");
                }
            }

            // 별 찍기
            Console.WriteLine("별 찍기");
            for(int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }

            //Factorial
            // 5! = 5 * 4 * 3 * 2 * 1
            Console.WriteLine("Factorial 메서드");

            static int Factorial(int n)
            {
                int result = 1;
                for(int i = 1; i <= n; i++)
                {
                    result = result * i;
                }
                return result;
            }

            int ret = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Factorial(ret));
        }
    }
}
