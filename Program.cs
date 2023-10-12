namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.AddRange(Enumerable.Range(0, 10));

            string formattedNumbers = "";
            for (int i = 0; i < numbers.Count; i++)
            {
                formattedNumbers += numbers[i];
            }

            Console.WriteLine($"The digits are {formattedNumbers}");

            string formattedCharacters = "";
            for (int i = char.MinValue; i <= char.MaxValue; i++)
            {
                char c = Convert.ToChar(i);
                if (!char.IsControl(c))
                {
                    if (c.ToString() != "A") formattedCharacters += c;
                    else break;
                }
            }

            Console.WriteLine($"The characters are {formattedCharacters.Trim()}");

            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] alphas = (alphabet.ToLower() + alphabet).ToCharArray();

            string formattedAlphaNumerics = "";
            for (int i = 0; i < alphas.Length; i++)
            {
                formattedAlphaNumerics += alphas[i].ToString();
            }

            Console.WriteLine($"The alphanumerics are {formattedNumbers} {formattedAlphaNumerics} {formattedCharacters}");
        }
    }
}
