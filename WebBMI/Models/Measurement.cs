namespace WebBMI.Models
{
    public class Measurement
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public double Weight { get; set; }

        public double Height { get; set; }

        public virtual ApplicationUser? User { get; set; }

        public BMI DaneBMI { get { return new BMI() { Masa = Weight, Wzrost = Height }; } }

    }
}
