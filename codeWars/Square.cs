namespace codeWars
{
    public class Square
    {
        public static string GenerateSquare(int size)
        {
            var square = "";

            for (int length = 0; length < size; length++)
            {
                for (int width = 0; width < size; width++)
                {
                    square += "+";
                }

                if (length != size - 1)
                {
                    square += "\n";
                }
            }

            return square;
        }
    }
}