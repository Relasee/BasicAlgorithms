using System;

namespace Split
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Write a word and number : (with ,)");
           string s = Console.ReadLine();
           string[] arr = s.Split(',');
           for(int i=0;i<arr.Length;i+=2){
                Console.Write(arr[i]+" ");
           }
        }
    }
}
