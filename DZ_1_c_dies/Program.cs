namespace DZ_1_c_dies
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // задание 3
            Console.WriteLine("Введите число");
            string num1 = Console.ReadLine();
            Console.WriteLine("Введите число");
            string num2 = Console.ReadLine();
            Console.WriteLine("Введите число");
            string num3 = Console.ReadLine();
            Console.WriteLine("Введите число");
            string num4 = Console.ReadLine();
            Console.WriteLine("Получилось" + " " + num1 + num2 + num3 + num4);

            // задание 4
            Console.WriteLine("Введите шестизначное число:");
            string numStr = Console.ReadLine();

            int numInt = Convert.ToInt32(numStr);
            if (numInt > 999999 || numInt < 100000) Console.WriteLine("Ошибка. Введите шестизначное число:");

            Console.WriteLine("Какие цифры поменять местами:");
            int numInt1 = Convert.ToInt32(Console.ReadLine());
            int numInt2 = Convert.ToInt32(Console.ReadLine());

            char[] numStrArr = numStr.ToCharArray();
            char temp1 = numStrArr[numInt1 - 1];
            char temp2 = numStrArr[numInt2 - 1];

            numStrArr[numInt1 - 1] = temp2;
            numStrArr[numInt2 - 1] = temp1;

            Console.WriteLine(numStrArr);


            // задание 5

            string? vremya = Console.ReadLine();
            char[] sp = { '.' };
            string[] vr = vremya.Split(sp);
            int[] mass = new int[vr.Length];
            for (int i = 0; i < mass.Length; ++i)
                mass[i] = Convert.ToInt32(vr[i]);
            DateTime vremya2 = new DateTime(Convert.ToInt32(mass[0]), mass[1], mass[2]);
            Console.WriteLine("\nОпределение :" +"\nдата " + vremya2 + "\nсезон  " + Season(vremya2.Month) + "\nдень  " + vremya2.DayOfWeek);
            string Season(int date)
            {
                switch (date)
                {
                    case 1: case 2: case 12: return "Зима";
                    case 3: case 4: case 5: return "Весна";
                    case 6: case 7: case 8: return "Лето";
                    case 9: case 10: case 11: return "Осень";
                    default: return "ничего";
                }
            }

            // задание 6
            Console.WriteLine("Введите температуру:");
            string input = Console.ReadLine();
            string noSpaces = input.Replace(" ", "");
            noSpaces = noSpaces.ToLower();
            string str = noSpaces.Remove(noSpaces.Length - 1); 
            double degrees = Convert.ToDouble(str);

            if (noSpaces.EndsWith("c") || noSpaces.EndsWith("ц"))
            {
                double f = degrees * 9 / 5 + 32;
                Console.WriteLine($"{degrees}C = {f}F");
            }
            else if (noSpaces.EndsWith("f") || noSpaces.EndsWith("ф"))
            {
                double c = (degrees - 32) / 1.8;
                Console.WriteLine($"{degrees}F = {c}C");
            }
            // задание 7
            Console.WriteLine("Введите два числа:");
            int num11 = Convert.ToInt32(Console.ReadLine());
            int num22 = Convert.ToInt32(Console.ReadLine());

            if (num11 > num22)
            {
                int temp;
                temp = num11;
                num11 = num22;
                num22 = temp;
            }

            for (int i = num11; i <= num22; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }
        }
    }
}