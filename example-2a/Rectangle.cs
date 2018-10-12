namespace Classes{
    public class Rectangle : Shape{
        private float w;
        private float h;

        public Rectangle(float width, float height)
        {
            this.w = width;
            this.h = height;
        }

        public override double Area() => w * h;
    }
}