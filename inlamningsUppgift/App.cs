using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

public class App
{


    public void Run()
    {

        
        Console.WriteLine("******VÄLKOMMEN!******");
        
        Play();
        MainMenu();



    }

    // Play = CheckString();  för G vill du spela igen Ja/Nej?









    public void MainMenu()
    {
        
        bool isRunning = true;

        while (isRunning)
        {

            
            Console.WriteLine("VÄLJ ETT ALTERNATIV");
            Console.WriteLine("");
            Console.WriteLine("1. Spela igen");
            Console.WriteLine("2. Avsluta");
            Console.WriteLine("3. Se lowscore");

            int sel = CheckNumber(1, 3);

            switch (sel)
            {

                case 1:
                    Play();
                    break;

                case 2:
                    isRunning = false;
                    Console.WriteLine("Tack för den här gången");
                    break;

                case 3:
                    // show lowscore list
                    break;

                default:
                    sel = Convert.ToInt32(Console.ReadLine());
                    if (sel < 1 && sel < 3)
                    {
                        Console.WriteLine("Felaktigt val! Mata in igen");
                        sel = Convert.ToInt32(Console.ReadLine());
                    }
                    break;


            }
        }
    }

    public void Play()
    {
        Console.WriteLine("Gissa talet mellan 1 och 100.");
        var random = new Random();
        int secretNumber = random.Next(1, 101);
        bool play = true;
        Console.WriteLine(secretNumber);
        while (play)
        {

            int counter = 0;
            int tal = 0;




            while (tal != secretNumber)
            {
                tal = CheckNumber(1, 100);
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
            Console.Clear();
            Console.WriteLine("*********************************************************************");
            Console.WriteLine($"Nummer: {tal}");
            Console.WriteLine($"{secretNumber} är rätt!");
            Console.WriteLine($"Du gissade rätt på {counter} gånger.");
            Console.WriteLine("*********************************************************************");
            play = false;
            

        }

         
    }
    public int CheckNumber(int min, int max)
    {
        int tal = 0;

        while (true)
        {

            if (int.TryParse(Console.ReadLine(), out tal) == false)
            {

                Console.WriteLine("Felaktig inmatning, ange ett tal");
                continue;
            }
            if (tal < min || tal > 100)
            {
                Console.WriteLine("Felaktig inmatning, ange ett tal mellan 1 - 100");
                continue;
            }

            return tal;
        }
    }
}


    //public bool CheckString()  för G delen
    //{
       

    //    while (true)
    //    {
    //        Console.WriteLine($"Vill du spela igen? Ja/Nej");
    //        string svar = Console.ReadLine().ToLower();



    //        if (svar == "ja")
    //        {
    //            Console.Clear();
    //            Console.WriteLine("Gissa talet mellan 1 och 100.");
    //            return true;
                
    //        }
    //        else if(svar == "nej")
    //        {
    //            Console.WriteLine("Tack för den här gången!");
    //            return false;
    //        }

    //    }
    //}








    


   





