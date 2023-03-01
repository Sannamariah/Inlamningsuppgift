using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

public class App
{

    static int Meny()
    {
        while (true)
        {

            Console.WriteLine("******VÄLKOMMEN!******");
            Console.WriteLine("VÄLJ ETT ALTERNATIV");
            Console.WriteLine("");
            Console.WriteLine("1. Spela/spela igen");
            Console.WriteLine("2. Low Score");
            Console.WriteLine("3. Avsluta");


        }

    }



    public void Run()
    {


        var random = new Random();
        int secretNumber = random.Next(1, 101);
        bool playAgain = true;







        Console.WriteLine("Gissa talet mellan 1 och 100.");

        while (playAgain)
        {


            int counter = 1;
            secretNumber = random.Next(1, 101);
            int tal = 0;
            tal = 0;



            while (tal != secretNumber)
            {
                tal = checkNumber();
                Console.WriteLine($"Runda: {counter}");


                if (tal > secretNumber)
                {

                    Console.WriteLine($"Talet är mindre än {tal}.");


                }

                else if (tal < secretNumber)
                {

                    Console.WriteLine($"Talet är större än {tal}.");


                }
                counter++;

            }
            Console.WriteLine($"Nummer: {tal}");
            Console.WriteLine($"{secretNumber} är rätt!");
            Console.WriteLine($"Du gissade rätt på {counter} gånger.");

            playAgain = checkString();

            





        }



    }

    public int checkNumber()
    {
        int tal = 0;

        while (true)
        {
            
            if (int.TryParse(Console.ReadLine(), out tal) == false)
            {

                Console.WriteLine("Felaktig inmatning, ange ett tal");
                continue;
            }
            if (tal < 1 || tal > 100)
            {
                Console.WriteLine("Felaktig inmatning, ange ett tal mellan 1 - 100");
                continue;
            }

            return tal;
        }
    }


    public bool checkString()
    {
       

        while (true)
        {
            Console.WriteLine($"Vill du spela igen? Ja/Nej");
            string svar = Console.ReadLine().ToLower();



            if (svar == "ja")
            {
                Console.WriteLine("Gissa talet mellan 1 och 100.");
                return true;
                
            }
            else if(svar == "nej")
            {
                Console.WriteLine("Tack för den här gången!");
                return false;
            }

        }
    }
}

   





