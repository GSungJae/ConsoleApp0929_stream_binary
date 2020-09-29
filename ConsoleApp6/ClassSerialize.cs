using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    [Serializable]
    class Persons
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }

        public Persons(string name, string phone, int age)
        {
            Name = name;
            Phone = phone;
            Age = age;
        }
        public override string ToString()
        {
            return $"Name:{Name} Phone:{Phone} Age:{Age}";
        }
    }
    class ClassSerialize
    {
        static void Main()
        {
            Persons[] arr = new Persons[3];

            arr[0] = new Persons("김연1아", "010-111", 30);
            arr[1] = new Persons("김연2아", "010-111", 30);
            arr[2] = new Persons("김연3아", "010-111", 30);


            FileStream fs = new FileStream("b.dat", FileMode.Create);
            BinaryFormatter serializer = new BinaryFormatter();

            serializer.Serialize(fs, arr);

            fs.Close();

            Console.WriteLine("객체 직렬화 성공");

            // -----------------------------------------------------------------------
            FileStream rs = new FileStream("b.dat", FileMode.Open);
            arr = (Persons[])serializer.Deserialize(rs);
            
            Console.WriteLine("객체 역직렬화 성공");

            //------------------------------------------------------------------------
            foreach(Persons item in arr)
                Console.WriteLine(item.Name);
        }
    }
}
