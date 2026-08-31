/*
* Student ID : 1690700305
* Name       : น.ส.ณัชชาทองหมื่นศรี
* Section    : 129A
* No.        : N/A
* Course     : GI113 Computer Programming (GI)
*/

namespace Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
        const int MaxLevel = 10;

        var bossName = "Kirin";   // ต้องประกาศด้วย var ห้ามเขียน string ตรงๆ
        var rank = 'S';            // ต้องประกาศด้วย var ห้ามเขียน char ตรงๆ
        int level = 7;
        int maxHp = 240;
        int currentHp = 115;       // ค่าตั้งต้นของ Lab นี้คือ HP "หลังโดนโจมตี" จาก Lab 2 แล้ว ไม่ใช่ 175
        float attackPower = 42.5f;
        double critMultiplier = 1.75;
        bool isBoss = true;
        // output
        Console.WriteLine("===== KIRIN SAVE CONVERTER =====");
        Console.WriteLine($"Name: {bossName}\nRank: {rank}\nLevel: {level} / {MaxLevel}\nHP: {currentHp} / {maxHp}" +
            $"\nAttack Power: {attackPower}\nCrit Multiplier: {critMultiplier}\nIs Boss: {isBoss}");

        // Implicit Conversion: Int as double
        Console.WriteLine("\n----- Implicit Conversion: HP as double -----");
        double currentHpDouble = currentHp;
        Console.WriteLine($"HP (double): {currentHpDouble}");

        // Implicit Conversion: Int as float
        Console.WriteLine("\n----- Exact HP Percent (no integer truncation) -----");
        double hpPercent = currentHpDouble * 100 / maxHp; // int หาร int จากนนั้นแปลงผลลัพธ์เป็น double เพื่อเก็บทศนิยม
        Console.WriteLine($"HP Percent (exact): {hpPercent}%");

        // Expicit หาร Casting (float) AttackPower -->> Int
        Console.WriteLine("\n----- Explicit Cast: Attack Power -> Display Int -----");
        int attackInt = (int)attackPower; // Cast Syntax: (type)variable
        Console.WriteLine($"Attack Power (int cast): {attackInt}");

        // Last part: Cast + Convert
        Console.WriteLine("\n----- Cast vs Convert: Crit Multiplier -----");
        int critCast = (int)critMultiplier;
        int critConvert = Convert.ToInt32(critMultiplier);
        Console.WriteLine($"Crit Multiplier (int cast): {critCast}");
        Console.WriteLine($"Crit Multiplier (Convert rounded): {critConvert}");
        }
    }
}