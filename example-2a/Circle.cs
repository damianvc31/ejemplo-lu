namespace Classes{
    public class Circle : Shape{
        private float r;

        public Circle(float radius)
        {
            this.r = radius;
        }

        public override double Area() => (r*r) * System.Math.PI;
    }
}