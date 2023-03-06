using System;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.IO;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing.Text;
using Microsoft.IdentityModel.Abstractions;

public class App
{


    public void Run()
    {


        Console.WriteLine("********VÄLKOMMEN!********");

        Play();
        MainMenu();



    }

    

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
                    Console.WriteLine("Tack för den här gången!");
                    break;

                case 3:
                    LowScore();
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




    public void LowScore()
    {

        // jag får den att skriva det senaste resultatet men inte att lagra mer. 
        // nästa steg är att få den att lagra 5 resultat och skriva ut min Välkommen till lowscorelistan texten
        StreamReader sr = new StreamReader("file.txt");
        string data = sr.ReadLine();
        while (data != null)
        {

            Console.WriteLine(data);
            string[] values = data.Split(',');
            string name = values[0];
            int count = Int32.Parse(values[1]);
            data = sr.ReadLine();
        }

        Console.WriteLine("          VÄLKOMMEN TILL LOWSCORE LISTAN             ");
        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine("      Namn:     |    Tid:     |     Gissningar:      ");
        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine(data);

    }

    


    public void Play()
    {
        Console.WriteLine("Gissa talet mellan 1 och 100.");
        var random = new Random();
        int secretNumber = random.Next(1, 101);
        bool play = true;
        var date = DateTime.Now;
        StreamWriter sw = new StreamWriter("file.txt");



        while (play)
        {

            int counter = 0;
            int tal = 0;



            
            while (tal != secretNumber)
            {
                tal = CheckNumber(1, 100);
                Console.WriteLine($"Runda: {counter + 1}");


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
            Console.WriteLine($"{secretNumber} är rätt!");
            Console.WriteLine($"Rundor körda: {counter}");
            Console.WriteLine($"Datum: {date.ToLongDateString()}, Tid: {date.ToLongTimeString()} ");
            Console.WriteLine("*********************************************************************");
            // om man platsar på lowscore listan ska detta visas
             Console.Write("Skriv ditt namn:");
             string playerName = Console.ReadLine();
            sw.WriteLine($"{playerName}, {date}, {counter}");
            sw.Close();



            // Play = CheckString();  för G delen," vill du spela igen Ja/Nej?"
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




//public bool CheckString() kod för G delen Ja/Nej
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

















