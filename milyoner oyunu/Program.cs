using System;

namespace KimMilyonerOlmakIster
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] questions = { "Türkiye'nin paytaxti haradir?", "Dünyanın en büyük okeani hansidir?", "Hansi Türkiye'de yoxdur?", "Hansi bir programlasdirma dilidir?" };
            string[] optionsA = { "Ankara", "Hint Okeani", "Van Gölü", "Interface" };
            string[] optionsB = { "İstanbul", "Atlantik Okeani", "Balaton Gölü", "Class" };
            string[] optionsC = { "İzmir", "Pasifik Okeani", "Duz Gölü", "Keyword" };
            string[] optionsD = { "Bursa", "Arktik Okeani", "Hazır Gölü", "C#" };
            string[] correctAnswers = { "A", "B", "B", "D" };
            int currentQuestion = 0;
            int prizeMoney = 0;
            bool fiftyFiftyJokerUsed = false;

            Console.WriteLine("Kim Milyoner Olmak İster?");
            Console.WriteLine("Oyuna xoş geldiniz!\n");

            while (true)
            {
                Console.WriteLine("Sual {0}: {1}", currentQuestion + 1, questions[currentQuestion]);
                Console.WriteLine("A) {0}", optionsA[currentQuestion]);
                Console.WriteLine("B) {0}", optionsB[currentQuestion]);
                Console.WriteLine("C) {0}", optionsC[currentQuestion]);
                Console.WriteLine("D) {0}", optionsD[currentQuestion]);
                Console.WriteLine("Xais edirem cavabinizi girin veya joker haqqinizi isletmek ucun J herfine basın.");
                string answer = Console.ReadLine().ToUpper();

                if (answer == "A" || answer == "B" || answer == "C" || answer == "D")
                {
                    if (answer == correctAnswers[currentQuestion])
                    {
                        prizeMoney += 1000;
                        Console.WriteLine("Tebrikler! Duz cavap. {0} Manat kazandınız.", prizeMoney);
                    }
                    else
                    {
                        Console.WriteLine("Maalesef sehv cavap verdiniz. Oyunu uduzdunuz. Qazandığınız pul: {0} Manat", prizeMoney);
                        break;
                    }

                    currentQuestion++;

                    if (currentQuestion == 4)
                    {
                        Console.WriteLine("Tebrikler, oyunu tamamladınız! Qazandığınız pul: {0} Manat", prizeMoney);
                        break;
                    }
                }
                else if (answer == "J" && fiftyFiftyJokerUsed == false)
                {
                    // 50/50 joker hakkı kullanılır.
                    Random random = new Random();
                    int correctAnswerIndex = Array.IndexOf(new string[] { "A", "B", "C", "D" }, correctAnswers[currentQuestion]);
                    int wrongAnswerIndex = random.Next(0, 4);
                    while (wrongAnswerIndex == correctAnswerIndex)
                    {
                        wrongAnswerIndex = random.Next(0, 4);
                    }
                    if (answer == "3" && correctAnswerIndex == 2)
                    {
                        Console.WriteLine("\nCongratulations! You won {0} dollars!\n", prizeMoney);
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();
                        //return true;
                    }
                }
            }
        }
    }
}