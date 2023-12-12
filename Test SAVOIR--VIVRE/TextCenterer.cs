namespace Test_SAVOIR__VIVRE
{
    internal class TextCenterer
    {
        public static void PrintCenteredText(string text)
        {
            int width = Console.WindowWidth;
            int leftPadding = (width - text.Length) / 2;
            leftPadding = Math.Max(0, leftPadding);

            Console.SetCursorPosition(leftPadding, Console.CursorTop);
            Console.WriteLine(text);
        }
    }
}
