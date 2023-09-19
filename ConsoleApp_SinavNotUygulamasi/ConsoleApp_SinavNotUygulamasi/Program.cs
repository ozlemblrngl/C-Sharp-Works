internal class Program
{
    private static void Main(string[] args)
    {
        bool ogrenciSinavgirdimi = true;
        int sinavNot = 86;
        


        if (ogrenciSinavgirdimi == true)
        {

            if ( sinavNot <= 100 && sinavNot >= 90)
            {
                Console.WriteLine("Sınav harf notunuz: " + sinavNot + "- AA");
            }
            else if (sinavNot >= 80)
            {
                Console.WriteLine("Sınav harf notunuz: " + sinavNot + "- BA");
            }
            else if (sinavNot >= 70)
            {
                Console.WriteLine("Sınav harf notunuz: " + sinavNot + "- CB");
            }
            else if (sinavNot >= 50)
            {
                Console.WriteLine("Sınav harf notunuz: " + sinavNot + "- DD");
            }
            else
            {
                Console.WriteLine("Sınav harf notunuz: " + sinavNot + "- FF");
            }

        }
        else
        {
            Console.WriteLine(" Sınava giriş yapmadınız ");
        }
    }
}