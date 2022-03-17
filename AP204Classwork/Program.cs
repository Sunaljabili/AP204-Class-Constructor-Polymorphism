using System;
using AP204Classwork.Models;

namespace AP204Classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Bir soz daxil edin :");
            //string word = Console.ReadLine();
            //Console.WriteLine(findAcount(word));

            //Console.WriteLine("Deyer daxil edin :");
            //string word = Console.ReadLine();
            //Console.WriteLine(Reverse(word));
            //Word();

            Car car1 = new Car();
            car1.Model = "Pirus";
            car1.Brand = "Toyota";
            car1.Color = "yashil Uber";
            car1.MaxSpeed = 180;

            Bus bus = new Bus(100, "Daewo", "Gentra", "Qirmizi", 65);

            Console.WriteLine(car1.AllInfo());
            Console.WriteLine(bus.AllInfo()); 


        }

        #region Task-1
        //public static int findAcount(string word)
        //{

        //    int count = 0;
        //    for (int i = 0; i < word.Length; i++)
        //    {

        //        if (word[i] == 'a')
        //        {
        //            count++;
        //        }

        //    }
        //    return count;


        //}
        #endregion

        #region Task-2

        //public static  string Reverse(string word)
        //{
        //    string newWord = "";

        //    for (int i = word.Length - 1; i >= 0; i--)
        //    {
        //        newWord += word[i];

        //    }
        //    return newWord;
        //}


        #endregion

        #region Task-3

        public static void Word()
        {
            string[] brand = { "BMW", "Nissan", "Mercedes", "Audi" };
            for (int i = 0; i < brand.Length; i++)
               
            {
                if (brand[i].Length > 5)
                {
                    Console.WriteLine(brand[i]);
                }

            }
        }
        #endregion


    }
}
