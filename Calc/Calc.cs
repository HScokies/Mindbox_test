namespace Calc
{
    public static class Calc
    {
        public static double GetArea<T>(T shape) where T : Shape
        {
            return shape.GetArea();
        }
    }
}