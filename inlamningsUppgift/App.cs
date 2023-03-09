using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Sources;

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
                    Console.WriteLine("LOWSCORE LISTAN!");
                    foreach (var x in InitializeFromFile())
                    {
                        
                        Console.WriteLine(x.PlayerName, x.Score, x.Date);
                        
                    }
                    
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

    public class Player
    { 
        public string PlayerName { get; set; }
        public int Score { get; set; }
        public int Date { get; set; }   

        public Player(int date)
        {
            this.Date = date;
        }
    }


    private void  SaveToFile(List<Player> list)
    {
       var strings = new List<string>();
        foreach (var player in list) 
        { 
            string spelarString = player.PlayerName + "," + player.Score + "," + player.Date;
            strings.Add(spelarString);
        }


        File.WriteAllLines("score.txt", strings);
    }


    public List<Player> InitializeFromFile()
    {
        var listan = new List<Player>();
        if (!File.Exists("score.txt")) return listan;

        foreach (var line in File.ReadLines("score.txt"))
        { 
            var parts = line.Split(',');
            var player = new Player(0);
            player.PlayerName = parts[0];
            player.Score = Convert.ToInt32(parts[1]);
            player.Date = Convert.ToInt32(parts[2]);
            listan.Add(player);
        
        
        }
        return listan;
    }


    public void Play()
    {
        var list = InitializeFromFile();
        Console.WriteLine("Gissa talet mellan 1 och 100.");
        var random = new Random();
        int secretNumber = random.Next(1, 101);
        bool play = true;
        var date = DateTime.Now;
       




        while (play)
        {

            int score = 0;
            int tal = 0;



            
            while (tal != secretNumber)
            {
                tal = CheckNumber(1, 100);
                Console.WriteLine($"Runda: {score + 1}");


                if (tal > secretNumber)
                {

                    Console.WriteLine($"Talet är mindre än {tal}.");


                }

                else if (tal < secretNumber)
                {

                    Console.WriteLine($"Talet är större än {tal}.");


                }
                score++;

            }
            Console.Clear();
            Console.WriteLine("*********************************************************************");
            Console.WriteLine($"{secretNumber} är rätt!");
            Console.WriteLine($"Rundor körda: {score}");
            Console.WriteLine($"Datum: {date.ToLongDateString()}, Tid: {date.ToLongTimeString()} ");
            Console.WriteLine("*********************************************************************");
            Console.Write("Skriv ditt namn:");
            string playerName = Console.ReadLine();

            list.Add(new Player(0) { PlayerName = playerName, Score = score, Date = Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd")) });
            SaveToFile(list);
            
            Console.WriteLine("----------------------------------------------------------------------");
            
           



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

















