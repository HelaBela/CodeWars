namespace codeWars
{
    public class CountChars
    {
        
        public static int CountCharInString(string word, char checkChar)
        {
            var charArray = word.ToLower().ToCharArray();
            var timesTheCharaterAppears = 0;

            foreach (var character in charArray)
            {
                if (checkChar == character)
                {
                    timesTheCharaterAppears++;
                }
            }

            return timesTheCharaterAppears;
        }

        public static bool XOXO(string word)
        {
            return CountCharInString(word, 'x') == CountCharInString(word, 'o');
        }

    }
}