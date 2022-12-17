namespace MyLibrary
{
    public abstract class Form
    {
        private double area;
        public double GetArea => area;
        public Form(double area)
        {
            this.area = area;
        }
        public override string ToString()
        {
            return GetArea.ToString();
        }
    }
}