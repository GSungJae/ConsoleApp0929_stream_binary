using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class ClassSerialize2
    {
        static void Main()
        {
            BinaryFormatter serializer = new BinaryFormatter();

            //------------------------------------------------------------------------
            // 파일을 읽어서 배열에 저장
            Persons[] arr = new Persons[6];
            
            if (File.Exists("b.dat"))
            {
                FileStream rs = new FileStream("b.dat", FileMode.Open);
                
                arr = (Persons[])serializer.Deserialize(rs);
                Console.WriteLine(arr.Length);
                Console.WriteLine("객체 역직렬화 성공");

                foreach (Persons item in arr)
                {
                    Console.WriteLine(item.Name);
                }
                rs.Close();
            }
            Console.WriteLine(arr.Length);
            int readCnt = arr.Length;
            //------------------------------------------------------------------------
            // 3명을 추가로 입력해서 파일에 저장
            Persons[] new_arr = new Persons[readCnt+3];
            Array.Copy(arr, new_arr, readCnt);

            new_arr[readCnt] = new Persons("김연4아", "010-111", 30);
            new_arr[readCnt+1] = new Persons("김연5아", "010-111", 30);
            new_arr[readCnt + 2] = new Persons("김연6아", "010-111", 30);
            foreach (Persons item in new_arr)
                Console.WriteLine(item.Name);

            FileStream fs = new FileStream("b.dat", FileMode.Create);
            BinaryFormatter serializer1 = new BinaryFormatter();

            serializer1.Serialize(fs, new_arr);

            fs.Close();

            Console.WriteLine("객체 직렬화 성공");
        }
    }
}
// 코드(2~3), 개념(2~3)