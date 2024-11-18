
using System.Runtime.InteropServices.Marshalling;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ans = "y";
            do
            {
                Console.Clear();

                headProgram("Pisit hablakhon");

                //input รับข้อมูล น้ำหนักและส่วนสูง
                double weight = 0.0;
                double height = 0.0;
                Console.Write("input your weight(kg) :");
                //weight = Convert.ToDouble(Console.ReadLine());
                if (double.TryParse(Console.ReadLine(), out weight) == false)
                {
                    continue;
                }
                Console.Write("input your height(cm) :");
                //height = Convert.ToDouble(Console.ReadLine());
                if (!double.TryParse(Console.ReadLine(), out height))
                {
                    continue;
                }
                line("#", 40);
                //process ประมวลผล

                bmi(weight, height);

                line("%", 40);
                Console.WriteLine();
                Console.Write("Would you like to continue working? (y,n) :");
                ans = Console.ReadLine();
            } while (ans == "y");
        }
        static void line(string letter, int width)
        {
            string str = "";
            for (int i = 0; i < width; i++)
            {
                str += letter;
            }
            Console.WriteLine(str);
        }

        static void headProgram(string programmerName)
        {
            Console.WriteLine("Update from Web Github");
            //ทดสอบ Github
            //ทดสอบผ่าน vscode 
            Console.WriteLine("Body mass index (BMI)");
            line("*", 40);

            WriteLineColor("Develop by " + programmerName, ConsoleColor.Blue, ConsoleColor.Gray);
            WriteLineColor("Udonthani Rajabhat University", ConsoleColor.Green, ConsoleColor.Yellow);

            line("-", 40);

            Console.WriteLine("Please input you Information");
        }
        static void WriteLineColor(string text, ConsoleColor fg, ConsoleColor bg)
        {
            Console.ForegroundColor = fg;
            Console.BackgroundColor = bg;

            Console.WriteLine(text);

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }

        static void bmi(double weight, double height)
        {
            //process ประมวลผล
            double bmi = weight / Math.Pow(height / 100, 2);
            string result = "";
            if (bmi < 18.5)
            {
                result = "Underweight";
            }
            else if (bmi < 25.0)
            {
                result = "Normal weight";
            }
            else if (bmi < 30)
            {
                result = "Overweight";
            }
            else
            {
                result = "obesity";
            }
            Console.WriteLine("Your Body mass index (BMI) is " + bmi.ToString("0.00"));
            WriteLineColor("From your body mass index, you are" + result, ConsoleColor.Green, ConsoleColor.Gray);
        }
    }
}
