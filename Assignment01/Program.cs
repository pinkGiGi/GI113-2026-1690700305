/*
* Student ID : 1690700305
* Name       : น.ส.ณัชชาทองหมื่นศรี
* Section    : 129A
* No.        : N/A
* Course     : GI113 Computer Programming (GI)
*/
using System;

namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            const string GameTitle = "Umamusume: Pretty Derby";

            var traineeName = "[El☆Número 1] El Condor Pasa"; // string
            var turfAptitude = 'A';                          // char

            int speedStat = 1257;            // int
            float fanMotivationRate = 1.25f; // float
            double winRatePercent = 99.5;    // double
            bool isDebuting = false;         // bool

            Console.WriteLine($"==========================================");
            Console.WriteLine($"           {GameTitle} - Stat Card       ");
            Console.WriteLine($"==========================================");
            Console.WriteLine($"Trainee Name   : {traineeName}");
            Console.WriteLine($"Turf Aptitude  : Rank {turfAptitude}");
            Console.WriteLine($"Speed Stat     : {speedStat}");
            Console.WriteLine($"Fan Bonus Rate : x{fanMotivationRate}");
            Console.WriteLine($"Win Rate       : {winRatePercent}%");
            Console.WriteLine($"Is Debuting    : {isDebuting}");
            Console.WriteLine($"------------------------------------------");

            // Implicit Conversion
            double speedStatAsDouble = speedStat;
            Console.WriteLine($"[Implicit] Speed Stat as double : {speedStatAsDouble}");

            // Explicit Cast vs Convert.ToInt32()
            int winRateTruncated = (int)winRatePercent;               // explicit cast: ตัดเศษทิ้ง -> ได้ 99
            int winRateRounded = Convert.ToInt32(winRatePercent);      // Convert: ปัดเศษขึ้น -> ได้ 100

            Console.WriteLine($"[Explicit Cast] Win Rate (Truncate): {winRateTruncated}%");
            Console.WriteLine($"[Convert]       Win Rate (Round)   : {winRateRounded}%");
            Console.WriteLine($"==========================================");
        }
    }
}