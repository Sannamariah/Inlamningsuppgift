public class App
{
       
       
        


        public void Run()
        {


        var random = new Random();
        int secretNumber = random.Next(1, 101);
        bool playAgain = true;
        int counter = 0;
        int lowScore = 0;






        Console.WriteLine("Gissa talet mellan 1 och 100.");
       
        while (playAgain)
        {
          

            counter = 1;
            secretNumber = random.Next(1, 101);
            int tal = 0;
            tal = 0;
           


            while (tal != secretNumber)
            {
                tal = Convert.ToInt32(Console.ReadLine());
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

            Console.WriteLine($"Vill du spela igen? Ja/Nej");
            string svar = Console.ReadLine();
           
            if (svar == "Ja")
            {
                
                playAgain = true;
                Console.WriteLine("Gissa talet mellan 1 och 100.");
            }
            else
            {
                playAgain = false;
            }
            Console.WriteLine("Tack för den här gången!");

            



        }



    }




} 

   





