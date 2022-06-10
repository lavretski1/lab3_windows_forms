namespace VP_3
{
    public class CarInfo 
    {
        public string? Brand { get; set; }
        public int ManufactureYear { get; set; }
        public string? EngineNumber { get; set; }
        public string? BodyNumber { get; set; }
        public string? Color { get; set; }
        public string? NumberPlate { get; set; }
        public string? OwnerName { get; set; }
    }

    internal static class Program
    {
        public static List<CarInfo> cars = new List<CarInfo>();

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}