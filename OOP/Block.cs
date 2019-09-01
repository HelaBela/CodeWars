namespace OOP
{
    public class Block
    {
        public int width;

        public int height;

        public int length;
        
        public Block(int[]dimentions)
        {
            this.width = dimentions[0];
            this.height = dimentions[1];
            this.length = dimentions[2];

        }
        public int GetWidth(){return width;}
        public int GetHeight(){return height;}
        public int GetLength(){return length;}
    }
}