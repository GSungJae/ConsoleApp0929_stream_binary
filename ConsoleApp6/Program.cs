using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = " Hello, World! ";
            //string t;

            //Console.WriteLine(s.Length); // 15
            //Console.WriteLine(s[8]); // W

            //Console.WriteLine(s.Insert(8, "C# ")); //  Hello, C#World! 
            //Console.WriteLine(s.PadLeft(20, '.')); //  ..... Hello, World! 
            //Console.WriteLine(s.PadRight(20, '.')); //  Hello, World! .....
            //Console.WriteLine(s.Remove(6)); //  Hello World! 
            //Console.WriteLine(s.Remove(6, 7));  //  Hello! 
            //Console.WriteLine(s.Replace('l', 'm')); // Hemmo!, wormd! 
            //Console.WriteLine(s.ToLower());
            //Console.WriteLine(s.ToUpper());
            //Console.WriteLine('/' + s.Trim() + '/');
            //Console.WriteLine('/' + s.TrimStart() + '/');
            //Console.WriteLine('/' + s.TrimEnd() + '/');

            //string[] a = s.Split(',');
            //foreach (var i in a)
            //    Console.WriteLine('/' + i + '/');

            //char[] destination = new char[10];
            //s.CopyTo(8, destination, 0, 6);
            //Console.WriteLine(destination);

            //Console.WriteLine('/' + s.Substring(8) + '/');
            //Console.WriteLine('/' + s.Substring(8, 5) + '/');

            //Console.WriteLine(s.Contains("ll"));
            //Console.WriteLine(s.IndexOf('o'));
            //Console.WriteLine(s.LastIndexOf('o'));
            //Console.WriteLine(s.CompareTo("abc"));

            //Console.WriteLine(String.Concat("Hi~", s));
            //Console.WriteLine(String.Compare("abc", s));
            //Console.WriteLine(t = String.Copy(s));

            //String[] val = { "apple", "orange", "grape", "pear" };
            //String result = String.Join(", ", val);
            //Console.WriteLine(result);

            //문제1  주문번호 : yyyyMMdd일련번호5자리 (2020092900005) 를 출력하시오.

            //문제2  입력받은 아이디가 6자리 이상인지 체크하시오.

            //문제3  파일명 : yyyyMMddHHmmss + 랜덤3자리(영문대문자 + 숫자)
            string a = "1";
            string orderNum = DateTime.Now.ToString("yyyyMMdd")+a.PadLeft(5,'0');
            Console.WriteLine(orderNum);
            Console.WriteLine();
            //
            Console.Write("아이디 : ");
            string id = Console.ReadLine().Trim().Replace(" ","");
            if(id.Length<6)
                Console.WriteLine("6자리 이상 입력해주세요.");           
            else
                Console.WriteLine("입력됐습니다.");
            Console.WriteLine();
            //
            string eng = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();

            int pick = random.Next(0, eng.Length);
            int pick1 = random.Next(0, eng.Length);
            int pick2 = random.Next(0, eng.Length);

            string pick3 = eng.Substring(pick, 1);
            string pick4 = eng.Substring(pick1, 1);
            string pick5 = eng.Substring(pick2, 1);

            string orderNum1 = DateTime.Now.ToString("yyyyMMddHHmmss") + pick3 + pick4 + pick5;
            Console.WriteLine(orderNum1);


        }
    }
}
