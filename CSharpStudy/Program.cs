namespace CSharpStudy
{
    internal class Program
    {
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


            Console.Write("첫번째 숫자를 입력해주세요 : ");
            float fA = float.Parse(Console.ReadLine());
            Console.Write("두번째 숫자를 입력해주세요 : ");
            float fB = float.Parse(Console.ReadLine());
            //변수의 덧셈
            float fC = fA + fB;
            Console.WriteLine("fA + fB = {0:f2}", fC);
            //변수의 뺄셈
            fC = fA - fB;
            Console.WriteLine("fA - fB = {0:f2}", fC);
            //변수의 곱셈
            fC = fA * fB;
            Console.WriteLine("fA X fB = {0:f2}", fC);
            //변수의 나눗셈
            fC = fA / fB;
            Console.WriteLine("fA / fB = {0:f2}", fC);
            //변수의 나머지
            fC = fA % fB;
            Console.WriteLine("fA % fB = {0:f2}", fC);
        }
    }
}
