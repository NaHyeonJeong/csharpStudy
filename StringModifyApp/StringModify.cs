using static System.Console;

namespace StringModifyApp
{
    class StringModify
    {
        static void Main(string[] args)
        {
            WriteLine("ToLower() : {0}", "ABC".ToLower());
            WriteLine("ToUpper() : {0}", "abc".ToUpper());

            WriteLine("Insert() : '{0}'", "회사 업무가 기초부터 공부 중!".Insert(7, "지겨워져서 "));
            WriteLine("Remove() : '{0}'", "I don't Love you".Remove(2,6));

            WriteLine("Trim() : '{0}'", "지겨워! 지겹다구! ".Trim());
            WriteLine("TrimStart() : '{0}'", " 지겨워! 지겹다구! ".TrimStart());
            WriteLine("TrimEnd() : '{0}'", "지겨워! 지겹다구! ".TrimEnd());
        }
    }
}
