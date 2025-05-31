using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Lütfen bir sayı giriniz: ");
        while (true)
        {
            try
            {
                double number = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Girdiğiniz sayının karesi: {Math.Pow(number, 2)}");
                break;
            }

            catch (FormatException ex)
            {
                Console.Write("Geçersiz giriş!\nLütfen bir sayı giriniz: ");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Genel bir hata oluştu.");
            }
            //finally bloğunu burada ihtiyaç olmadığı için kullanmadım
        }
    }
}
