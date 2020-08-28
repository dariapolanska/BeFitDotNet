namespace BeFitDotNet.WebModels
{
    public enum Sex
    {
        Woman,
        Man
    }

    public class CalculatorForm
    {
        public int Age { get; set; } = 25;

        public Sex Sex { get; set; } = 0;

        public float Weight { get; set; } = 60f;

        public float Height { get; set; } = 1.70f;
    }
}
