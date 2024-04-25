using CSharpFundamentals.Helpers;

namespace CSharpFundamentals
{
    static class SummarizingText
    {
        public static void Practice()
        {
            var sentence = "This is going to be a really really really really really really really long text";
            var summary = StringUtility.SummarizeText(sentence, 25);
            Console.WriteLine(summary);
        }
    }
}
