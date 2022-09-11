using System;
using System.Collections;
using System.Collections.Generic;

namespace Array_List
{
    class Program
    {
        static void Main(string[] args)
        {
           //System.Collections namespace
           ArrayList liste=new ArrayList();
           liste.Add("Ayşe");
           liste.Add(2);
           liste.Add(true);
           liste.Add('a');

           //İçerisindeki verilere erişim
           Console.WriteLine(liste[1]);
           foreach(var item in liste)
              Console.WriteLine(item);
           
           //AddRange
           Console.WriteLine("*****AddRange*****");
           string[] renkler={"Kırmızı","Sarı","Yeşil"};
           liste.AddRange(renkler);
           List<int> sayilar=new List<int>(){1,8,3,7,9,92,5};
           liste.AddRange(sayilar);
           foreach(var item in liste)
              Console.WriteLine(item);

           //Sort
           Console.WriteLine("******Sort******");
           liste.Sort(); 
           //int,bool,string tipinde değerler olduğu için hata 

           //BinarySearch
           Console.WriteLine("******BinarySearch******");
           //BinarySearch kullanmadan önce sıralama yapmalıyız. 
           //Sonra BinarySearch ile indexe ulaşabiliriz

           //Reverse
           Console.WriteLine("******Reverse******");
           liste.Reverse();
           foreach(var item in liste)
             Console.WriteLine(item);
           
           //Clear
           Console.WriteLine("******Clear******");
           liste.Clear();
           foreach(var item in liste)
             Console.WriteLine(item);

        }
    }
}
