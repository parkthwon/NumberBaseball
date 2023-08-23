using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int answer1 = random.Next(1, 9);
            int answer2 = random.Next(1, 9);
            int answer3 = random.Next(1, 9);

            while (answer1 == answer2 || answer1 == answer3 || answer2 == answer3)
            {
                answer2 = random.Next(1, 9);
                answer3 = random.Next(1, 9);
            }

            int[] answer = { answer1, answer2, answer3 };
            int count = 0;
            Console.WriteLine("3자리 숫자야구");

            while (true)
            {
                try
                {
                    Console.Write("\n숫자 입력 : ");
                    int keyinput = int.Parse(Console.ReadLine());
                    int input1 = keyinput / 100;
                    int input2 = (keyinput / 10) % 10;
                    int input3 = keyinput % 10;

                    if (keyinput < 100 || keyinput > 987)
                    {
                        Console.WriteLine("3자리 숫자만 입력하세요");
                    }
                    else if (input1 == input2 || input1 == input3 || input2 == input3)
                    {
                        Console.WriteLine("중복숫자는 안됩니다");
                    }
                    else
                    {
                        int[] input = { input1, input2, input3 };
                        int strike = 0;
                        int ball = 0;
                        count++;

                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                if (answer[i] == input[j])
                                {
                                    if (i == j)
                                        strike++;
                                    else
                                        ball++;
                                }
                            }
                        }


                        if (strike == 0 && ball == 0)
                        {
                            Console.WriteLine("아웃!\n" + count + "번 시도");
                        }
                        else if (strike == 3)
                        {
                            Console.WriteLine("홈런입니다!!\n" + count + "번 시도");
                            break;
                        }
                        else
                        {
                            Console.WriteLine(strike + "스트라이크 " + ball + "볼\n" + count + "번 시도");
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("숫자만 입력하세요");
                }
            }
            Console.WriteLine("이겼습니다!"); // 게임이 종료된 후 출력
            Console.ReadLine(); // 사용자 입력 대기
        }
    }
}