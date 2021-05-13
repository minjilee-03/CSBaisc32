using System;
using System.Threading;

namespace CSBasic323
{
    class Program
    {
        static void Main(string[] args)
        {
            // 반복문과 배열
            int[] intArray = new int[100];
            Console.WriteLine(intArray.Length);
            Console.WriteLine(intArray[0]);
            Console.WriteLine(intArray[99]);
            //Console.WriteLine(intArray[100]);    // 범위 초과
            //Console.WriteLine(intArray[-1]);      // 음수 사용 불가

            Console.WriteLine();

            // while / do while
            int i = 0;
            int[] intArray2 = { 52, 273, 32, 65, 103 };
            while (i < intArray2.Length)
            {
                Console.WriteLine(i + "번째 출력 : " + intArray2[i]);
                i++;
            }

            string input;
            do
            {
                Console.Write("입력 (종료 : exit) : ");
                input = Console.ReadLine();
            } while (input != "exit");

            Console.WriteLine();

            // for / 역 for
            for (int j = '가'; j <= '힣'; j++)
            {
                Console.Write((char)j);
            }
            Console.WriteLine();

            int[] intArray3 = { 1, 2, 3, 4, 5, 6 };
            for (int k = intArray3.Length - 1; k >= 0; k--)
            {
                Console.WriteLine(intArray3[k]);
            }
            for (int k = intArray3.Length; k > 0; k--)
            {
                Console.WriteLine(intArray3[k - 1]);
            }

            Console.WriteLine();

            // foreach
            string[] fruits = { "사과", "배", "딸기", "포도", "바나나", "오렌지" };
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            Console.WriteLine();

            // 중첩 for
            for (i = 0; i < 10; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
            for (i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10 - i - 1; j++)
                {
                    Console.Write(' ');
                }
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // 반복문 응용
            // 대소문자 변환
            string input3 = "Potato Tomato";
            Console.WriteLine(input3.ToUpper());
            Console.WriteLine(input3.ToLower());
            input3.ToLower();
            Console.WriteLine(input3);  // 기존 그대로 출력

            // split
            string foods = "감자 고구마 토마토";
            string[] foodArray = foods.Split(new char[] { ' ' });
            foreach (var item in foodArray)
            {
                Console.WriteLine(item);
            }
            // 환경변수의 path 텍스트 값을 가져와서 \를 \\로 치환해서 넣어준다.
            string path = "C:\\Program Files (x86)\\Common Files\\Oracle\\Java\\javapath;C:\\oraclexe\\app\\oracle\\product\\11.2.0\\server\\bin;%SystemRoot%\\system32;%SystemRoot%;%SystemRoot%\\System32\\Wbem;%SYSTEMROOT%\\System32\\WindowsPowerShell\\v1.0\\;%SYSTEMROOT%\\System32\\OpenSSH\\;C:\\ProgramData\\Naraesoft\\Magic Recovery\\;C:\\Program Files\\nodejs\\;C:\\Program Files\\Microsoft SQL Server\\130\\Tools\\Binn\\;C:\\Program Files\\Microsoft SQL Server\\Client SDK\\ODBC\\170\\Tools\\Binn\\;C:\\Program Files\\Git\\cmd;C:\\Program Files\\dotnet\\";
            string[] paths = path.Split(new char[] { ';' });
            foreach (var item in paths)
            {
                Console.WriteLine(item);
            }

            // trim
            string dirtyInput = "   text     um    \n\t";
            Console.WriteLine("{" + dirtyInput + "}");
            Console.WriteLine("{" + dirtyInput.Trim() + "}");


            string[] foodArray2 = { "감자", "고구마", "토마토", "가지" };
            Console.WriteLine(string.Join(" ", foodArray));
            Console.WriteLine(string.Join(",", foodArray));
            Console.WriteLine(string.Join(";", foodArray));
            Console.WriteLine(string.Join(" ", foodArray));

            Console.SetCursorPosition(1, 0);
            Console.WriteLine("[                ]");
            Thread.Sleep(1000);
            Console.SetCursorPosition(1, 0);
            Console.WriteLine("[#                ]");
            Thread.Sleep(1000);
            Console.SetCursorPosition(1, 0);
            Console.WriteLine("[##                ]");
            Thread.Sleep(1000);
            Console.SetCursorPosition(1, 0);
            Console.WriteLine("[###                ]");
            Thread.Sleep(1000);
            Console.SetCursorPosition(1, 0);
            Console.WriteLine("[####                ]");
            Thread.Sleep(1000);
            Console.SetCursorPosition(1, 0);
            Console.WriteLine("[#####                ]");
            Thread.Sleep(1000);

            int x = 1;
            while (x < 50)
            {
                Console.Clear();
                Console.SetCursorPosition(x, 5);

                if (x % 3 == 0)
                    Console.WriteLine("__@");
                else if (x % 3 == 1)
                    Console.WriteLine("_^@");
                else
                    Console.WriteLine("^_@");

                Thread.Sleep(1000);
                x++;
            }
        }
    }
}