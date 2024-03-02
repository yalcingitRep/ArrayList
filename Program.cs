using System;
using System.Collections;
namespace ArrayListApp{
    class Program{
        public static void Main(string[] args){
            ArrayList list = new ArrayList();
            list.Add("Ayse");
            list.Add("yalcin");
            list.Add(2);
            list.Add(true);
            list.Add('A');

            Console.WriteLine(list[1]);
            foreach(var item in list){
                Console.WriteLine(item);
            }

            string[] renkler = {"Kirmizi","sari","yesil"};
            List<int> sayilar = new List<int>(){1,4,6,7,8,9};

            list.AddRange(renkler);
            list.AddRange(sayilar);

            //sort


            list.Sort();


            Console.WriteLine(list.BinarySearch(9));


            list.Reverse();

            list.Clear();
        }
    }
}