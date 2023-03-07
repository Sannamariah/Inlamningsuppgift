//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.IO;
//using System.Drawing.Imaging;

//namespace inlamningsUppgift
//{
//    internal class Score
//    {
//        public static void Main(string[] args)
//        { 
//        string path = "file.txt";

//        ReadFromFile(path);

//        }

//    public static void ReadFromFile(string path)
//        {
//            StreamReader sr = new StreamReader("file.txt");

//            int count = 0;

//            while(!sr.EndOfStream) 
//            {
//                Console.WriteLine(sr.ReadLine());
//                count++;
//            }
//            Console.WriteLine("LowScore Listan", count);


//            sr.Close();


//        }

//        public static void WriteToFile(string path) 
//        {
//            StreamWriter sw = new StreamWriter(path, true);
            

//            do 
//            {
//                Console.WriteLine("Skriv ditt namn:");
//                string namn = Console.ReadLine();
//                if (Score < "5")
//                { 
//                    WriteToFile(namn, DateTime.Now, App.LowScore(Score));
//                }
//            } while (score)

//            sw.Close();
           
//        }


//    }
//}

// Jag ger upp med textfil delen men lämnar koden kvar för att kunna gå tillbaka i framtien och se hur långt ifrån jag var från att lösa det. 
