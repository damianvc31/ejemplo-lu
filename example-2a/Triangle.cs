namespace Classes{
    public class Triangle : Shape{
        private float w;
        private float h;

        public Triangle(float width, float height)
        {
            this.w = width;
            this.h = height;
        }

        public override double Area() => (w * h)/2;
    }
}