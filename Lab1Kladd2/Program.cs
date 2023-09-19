namespace Lab1Kladd2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please input something below: ");
            string userInput = Console.ReadLine();
            FindSubstrings(userInput);
            Console.ReadKey();
        }

        static void FindSubstrings(string input)
        {
            string substring = " ";
            string substringMatch1 = " ";
            string substringMatch2 = " ";
            int sum = 0;

            for (int startIndex = 0; startIndex < input.Length - 1; startIndex++)
            {
                int temp = 0;
                bool isNumber = int.TryParse(input[startIndex] + "", out temp);

                if (isNumber == false)
                {
                    continue;
                }

                for (int endIndex = startIndex + 1; endIndex <= input.Length; endIndex++)
                {

                    if (!char.IsDigit(input[endIndex]))
                    {
                        break;
                    }

                    if (input[startIndex] == input[endIndex])
                    {
                        substring = input.Substring(startIndex, endIndex - startIndex + 1);

                        int result;
                        int.TryParse(substring, out result);
                        sum += result;

                        substringMatch1 = input.Substring(0, input.IndexOf(substring));
                        substringMatch2 = input.Substring(substring.Length + substringMatch1.Length, (input.Length) - (substring.Length + substringMatch1.Length));

                        Console.Write(substringMatch1);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(substring);
                        Console.ResetColor();
                        Console.WriteLine(substringMatch2);
                        break;

                    }

                }
            }

            Console.WriteLine($"The total sum of your substrings is {sum}");

        }

    }
}