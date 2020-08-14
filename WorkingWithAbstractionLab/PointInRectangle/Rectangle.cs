namespace PointInRectangle
{
    public class Rectangle
    {
        public Point UpperLeftCorner { get; set; }
        public Point LowerRightCorner { get; set; }

        public Rectangle()
        {

        }

        public Rectangle(Point ulc, Point lrc)
        {
            UpperLeftCorner = ulc;
            LowerRightCorner = lrc;

        }

        public bool Contains(Point point)
        {
            /*  bool isHorizontal =
                  point.PointX >= UpperLeftCorner.PointX &&
                  point.PointX <= LowerRightCorner.PointX;
              bool isVertical =
                  point.PointY <= UpperLeftCorner.PointY &&
                  point.PointY >= LowerRightCorner.PointY;*/
            bool isHorizontal = this.UpperLeftCorner.PointX <= point.PointX && this.LowerRightCorner.PointX >= point.PointX;

            bool isVertical = this.UpperLeftCorner.PointY <= point.PointY && this.LowerRightCorner.PointY >= point.PointY;

            bool isIn = isHorizontal && isVertical;

            return isIn;
        }


    }
}
