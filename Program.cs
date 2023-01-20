namespace Lowercase2Uppercase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputFileName = @"D:\InductionTasks\Lowercase2Uppercase\lowercasefile.txt";
            string outputFileName = @"D:\InductionTasks\Lowercase2Uppercase\uppercasefile.txt";

            string contents = File.ReadAllText(inputFileName);
            contents = contents.ToUpper();

            File.WriteAllText(outputFileName, contents);
        }
    }
}