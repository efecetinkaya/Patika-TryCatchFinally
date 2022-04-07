using System;

namespace consoleprogramlama
{
     class Program
    {
        static void Main(string[] args)
        {
          try{
              Console.WriteLine("Bir Sayı Giriiz");
              int sayi = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Girdiğiniz Sayı: " + sayi);
          }
          catch(ArgumentNullException ex){
              Console.WriteLine("Hata :" + ex.Message.ToString());
          }
          catch(OverflowException ex){
              Console.WriteLine("Hata :" + ex.Message.ToString());
          }
          catch(FormatException ex){
              Console.WriteLine("Hata :" + ex.Message.ToString());
          }
          finally{
              Console.WriteLine("İşlem Tamamlandı.");
          }
        }
    }
}