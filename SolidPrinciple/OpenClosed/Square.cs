namespace SolidPrinciple
{
    public class Square : Rectangle
    {

        public override int Width
        {
            set
            {
                base.Width = base.Height = value;
            }
        }

        public override int Height
        {
            set
            {
                base.Width = base.Height = value;
            }
        }
        public Square(int length) : base(length, length)
        {

        }
    }
}
