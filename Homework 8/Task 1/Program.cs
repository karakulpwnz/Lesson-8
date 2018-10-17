using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
//Володин Артем

//1. С помощью рефлексии выведите все свойства структуры DateTime


namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime();

            //забираем список всех свойств структуры
            PropertyInfo[] myPropertyInfo;
            myPropertyInfo = dateTime.GetType().GetProperties();

            //выводим все свойства структуры
            for (int i = 0; i < myPropertyInfo.Length; i++)
            {
                Console.WriteLine(myPropertyInfo[i]);
            }

            Console.ReadKey();
        }
    }
}