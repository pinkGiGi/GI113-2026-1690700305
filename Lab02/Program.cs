/*
 * Student ID : 1690700305
 * Name       : น.ส.ณัชชาทองหมื่นศรี
 * Section    : 129A
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */


using static System.Net.Mime.MediaTypeNames;

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");

            Console.WriteLine();

            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine();
            Console.WriteLine("Kirin takes 60 damage!");
            currentHp = currentHp - 60;
            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"HP Percent: {currentHp * 100 / maxHp}%");
            // Character 1: Knight
            string char1Name = "Arthur";
            char char1Class = 'K';
            int char1Hp = 500;
            float char1Defense = 85.5f;
            bool char1IsAlive = true;
            // Character 2: Mage
            string char2Name = "Merlin";
            char char2Class = 'M';
            int char2Hp = 250;
            double char2ManaRegen = 12.75;
            bool char2IsAlive = true;

            // Character 3: Archer
            string char3Name = "Robin";
            char char3Class = 'A';
            int char3Hp = 320;
            float char3Speed = 15.8f;
            bool char3IsAlive = true;

            // Character 4: Boss Dragon
            string char4Name = "Ignis";
            char char4Class = 'D';
            int char4Hp = 1200;
            double char4CritRate = 0.35;
            bool char4IsAlive = true;

            Console.WriteLine("===== KNIGHT STATUS: INITIAL =====");
            Console.WriteLine($"Name: {char1Name}");
            Console.WriteLine($"Class: {char1Class}");
            Console.WriteLine($"HP: {char1Hp}");
            Console.WriteLine($"DEF: {char1Defense}");
            Console.WriteLine($"Alive: {char1IsAlive}");

            Console.WriteLine("===== MAGE STATUS: INITIAL =====");
            Console.WriteLine($"Name: {char2Name}");
            Console.WriteLine($"Class: {char2Class}");
            Console.WriteLine($"HP: {char2Hp}");
            Console.WriteLine($"MP Regen: {char2ManaRegen}");
            Console.WriteLine($"Alive: {char2IsAlive}");

            Console.WriteLine("===== ARCHER STATUS: INITIAL =====");
            Console.WriteLine($"Name: {char3Name}");
            Console.WriteLine($"Class: {char3Class}");
            Console.WriteLine($"HP: {char3Hp}");
            Console.WriteLine($"Speed: {char3Speed}");
            Console.WriteLine($"Alive: {char3IsAlive}");

            Console.WriteLine("===== DRAGON STATUS: INITIAL =====");
            Console.WriteLine($"Name: {char4Name}");
            Console.WriteLine($"Class: {char4Class}");
            Console.WriteLine($"HP: {char4Hp}");
            Console.WriteLine($"Crit Rate: {char4CritRate}");
            Console.WriteLine($"Alive: {char4IsAlive}");
        }
    }
}
