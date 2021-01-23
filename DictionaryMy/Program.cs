using System;

namespace DictionaryMy
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> myDict = new MyDictionary<string, string>();

            myDict.Add("B", "55");
            myDict.Add("O", "33");
            myDict.Add("F", "43");
            myDict.Add("S", "23");

            for (int i = 0; i < myDict.keys.Length; i++)
            {
                Console.WriteLine(myDict.keys[i] + "--" + myDict.values[i]);
            }
        }


    }
}
