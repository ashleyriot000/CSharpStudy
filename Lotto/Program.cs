namespace Lotto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("로또 추첨번호 예측 사이트에 오신 것을 환영합니다.");
            Console.Write("총 몇장의 로또 번호를 추첨하시겠습니까? : ");
            int count = int.Parse(Console.ReadLine());

            for(int i = 0; i < count; i++)
            {
                GenerateLotto();
            }
        }

        static void GenerateLotto()
        {
            //1. 로또는 총 6개의 숫자로 이루어져 있고, 1 ~ 46번까지 있다.
            int[] lottos = new int[6];
            //2. 추첨된 숫자는 서로 중복되지 않는다.
            //3. 로또 번호 추첨하는 함수
            Random random = new Random();
            //int number = random.Next(1, 47);
            for(int i = 0; i < 6; i++)
            {
                //램덤으로 뽑기.
                //뽑은 숫자들 중에서 중복된 있는지 확인 for.
                //확인했더니 중복이에요. i -= 1;
            }

            Console.WriteLine("({0:D2},{1:D2},{2:D2},{3:D2},{4:D2},{5:D2})",
                lottos[0], lottos[1], lottos[2], lottos[3], lottos[4], lottos[5]);
        }
    }
}
