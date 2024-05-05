using static System.Console;

namespace StringSliceApp
{
    class StringSlice
    {
        static void Main(string[] args)
        {
            string greeting = "Good Morning.";
            WriteLine(greeting.Substring(0,5)); // Good
            WriteLine(greeting.Substring(5));   // Morning
            WriteLine();

            string[] arr = greeting.Split(new string[] { " " }, StringSplitOptions.None);
            WriteLine("Word Count : {0}", arr.Length); // 공백 기준으로 나누면 단어는 2개 나옴

            foreach (string item in arr)
            {
                WriteLine(item);
            }
        }
    }
}
