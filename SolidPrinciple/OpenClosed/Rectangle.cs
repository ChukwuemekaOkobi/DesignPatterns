namespace SolidPrinciple
{
    /// <summary>
    /// Single Responsibity 
    /// A class should have only on reason to change 
    /// </summary>
    public class Rectangle
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }


        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }


        public int Area() => Width * Height;
    }
}
