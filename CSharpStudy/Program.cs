namespace CSharpStudy
{
    internal class Program
    {
        public enum AAA
        {
            가위 = 0,
            바위 = 1,
            보 = 2
        }
        static void Main(string[] args)
        {
            //Console.Write("당신의 이름은 무엇입니까?");
            //string name = Console.ReadLine();
            //Console.Write("당신의 나이는 얼마입니까?");
            //string age = Console.ReadLine();
            //Console.Write("당신의 성별은 무엇입니까?");
            //string male = Console.ReadLine();
            //Console.WriteLine("당신의 이름이 {0}이고, 나이는 {1}이며, " +
            //    "성별은 {2}가 맞습니까?", name, age, male);

            //변수 선언
            int iA;
            //변수의 정의
            int iB = 0;
            //변수 대입
            iA = 15;

            //Console.Write("첫번째 숫자를 입력해주세요 : ");
            //iA = int.Parse(Console.ReadLine());
            ////int.TryParse(Console.ReadLine(), out iA);
            //Console.Write("두번째 숫자를 입력해주세요 : ");
            //iB = int.Parse(Console.ReadLine());
            ////변수의 덧셈
            //int iC = iA + iB;
            //Console.WriteLine("iA + iB = {0}", iC);
            ////변수의 뺄셈
            //iC = iA - iB;
            //Console.WriteLine("iA - iB = {0}", iC);
            ////변수의 곱셈
            //iC = iA * iB;
            //Console.WriteLine("iA X iB = {0}", iC);
            ////변수의 나눗셈
            //iC = iA / iB;
            //Console.WriteLine("iA / iB = {0}", iC);
            ////변수의 나머지
            //iC = iA % iB;
            //Console.WriteLine("iA % iB = {0}", iC);


            //Console.Write("첫번째 숫자를 입력해주세요 : ");
            //float fA = float.Parse(Console.ReadLine());
            //Console.Write("두번째 숫자를 입력해주세요 : ");
            //float fB = float.Parse(Console.ReadLine());
            ////변수의 덧셈
            //float fC = fA + fB;
            //Console.WriteLine("fA + fB = {0:f2}", fC);
            ////변수의 뺄셈
            //fC = fA - fB;
            //Console.WriteLine("fA - fB = {0:f2}", fC);
            ////변수의 곱셈
            //fC = fA * fB;
            //Console.WriteLine("fA X fB = {0:f2}", fC);
            ////변수의 나눗셈
            //fC = fA / fB;
            //Console.WriteLine("fA / fB = {0:f2}", fC);
            ////변수의 나머지
            //fC = fA % fB;
            //Console.WriteLine("fA % fB = {0:f2}", fC);

            //배열의 선언, 정의
            //int[] integers = new int[10];
            //int[] integers = new int[3]
            //{
            //    1,2,3
            //};

            //배열 대입
            //integers[0] = 15;
            //integers[1] = integers[0];
            //integers[2] = integers[0] + integers[1];

            //int sum = integers[0] + integers[1] + integers[2];
            //float avg = sum / integers.Length;

            //2차원 배열            
            //int[,] counts = new int[3, 10];

            //int[] scores = new int[3];
            //Console.Write("당신의 국어점수를 입력해주세요 : ");
            //scores[0] = int.Parse(Console.ReadLine());
            //Console.Write("당신의 영어점수를 입력해주세요 : ");
            //scores[1] = int.Parse(Console.ReadLine());
            //Console.Write("당신의 수학점수를 입력해주세요 : ");
            //scores[2] = int.Parse(Console.ReadLine());
            //float average = (scores[0] + scores[1] + scores[2]) / (float)scores.Length;
            //Console.WriteLine("당신의 평균 점수는 {0:f2}입니다.");

            int iD = 1;

            //증감 연산자
            //Console.WriteLine("iD의 값은 {0}", iD++);

            //iD += 1;
            //iD = iD + 1;
            //Sum(1, 5);

            //Console.Write("두 개의 자연수 중에서 큰 수를 알아냅니다.\n첫번째 자연수를 입력해주세요 :");         
            //InputIntegers(out int first, out int second);
            //Console.Write("둘 중 더 큰 자연수는 {0}입니다", Max(first, second));

            //Console.Write("두 개의 자연수 중에서 작은 수를 알아냅니다.\n첫번째 자연수를 입력해주세요 :");
            //InputIntegers(out first, out second);
            //Console.Write("둘 중 더 작은 자연수는 {0}입니다", Min(first, second));

            /*
            int iE = 5;
            int iF = 10;
            int iG = 11;
            if(iE == iF)
            {
                Console.WriteLine("iE와 iF는 같습니다.");
            }
            else
            {
                Console.WriteLine("iE와 iF는 다릅니다.");
            }           

            if (iE > iF)
            {
                Console.WriteLine("iE가 더 큽니다.");
            }
            else if(iE == iF)
            {
                Console.WriteLine("iE는 iF와 같습니다.");
            }
            else
            {
                Console.WriteLine("iE가 더 작습니다.");
            }
            */

            //if(!(iE == iF) & iE > iG )
            //{
            //    Console.WriteLine("iE와 iF가 다르고 iE가 iG보다 큽니다.");
            //}

            //if(iE == iG | iE < iG)
            //{
            //    Console.WriteLine("iE와 iF가 같을수도 있고 iE가 iG보다 작을 수도 있습니다.");
            //}

            Console.WriteLine("가위바위보 게임 스타트");
            Console.Write("게임을 몇번 하시겠습니까? : ");
            int count = int.Parse(Console.ReadLine());
            for(int i = 0; i < count; i++)
            {
                Game();
            }
        }


        /// <summary>
        /// 두개의 정수를 더한다.
        /// </summary>
        /// <param name="a">첫번째 정수</param>
        /// <param name="b">두번째 정수</param>
        /// <returns>결과값</returns>
        static int Sum(int a, int b)
        {
            return a + b;
        }

        static void Run()
        {
            Console.WriteLine("Run");
        }
        /// <summary>
        /// 둘 중에 더 큰 값을 반환한다.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int Max(int a, int b)
        {
            if(a == b) return a;
            if(a > b)  return a;
            return b;
        }

        static int Min(int a, int b)
        {
            if (a == b) return a;
            if (a < b) return a;
            return b;
        }

        static void InputIntegers(out int first, out int second)
        {
            first = int.Parse(Console.ReadLine());
            Console.Write("첫번째 자연수를 입력해주세요 :");
            second = int.Parse(Console.ReadLine());
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.WriteLine(".");
        }

        static void Game()
        {
            Console.Write("내실 가위바위보를 정해 입력해 주세요(0:가위, 1:바위, 2:보) : ");
            Random random = new Random();
            int com = random.Next(0, 3);
            int player = int.Parse(Console.ReadLine());


            Console.WriteLine("당신은 {0}을 냈고, 컴퓨터는 {1}을 냈습니다", (AAA)player, (AAA)com);
            //서로 같은 걸 낼 경우
            if (com == player)
            {
                Console.WriteLine("서로 비겼습니다.");
            }
            //서로 다른 걸 낼 경우, 컴퓨터가 가위를 낼 경우
            else if (com == 0)
            {
                //플레이어가 보를 낼 경우 컴퓨터가 이겼음 표시하기.
                if (player == 2)
                    Console.WriteLine("당신이 졌습니다.");
                //플레이어가 바위 플레이어가 이겼음 표시하기.
                else
                    Console.WriteLine("당신이 이겼습니다.");
            }
            //서로 다른 걸 낼 경우,  컴퓨터가 바위
            else if (com == 1)
            {
                //플레이어가 보를 낼 경우
                if (player == 2)
                    Console.WriteLine("당신이 이겼습니다.");
                //플레이어가 가위
                else
                    Console.WriteLine("당신이 졌습니다.");
            }
            //컴퓨터가 보
            else
            {
                //플레이어가 가위를 낼 경우
                if (player == 0)
                    Console.WriteLine("당신이 졌습니다.");
                //플레이어가 바위
                else
                    Console.WriteLine("당신이 이겼습니다.");
            }
        }

    }
}
