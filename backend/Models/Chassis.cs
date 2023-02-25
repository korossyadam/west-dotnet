namespace backend.Models
{
    public class Chassis
    {
        public int ChassisIndex { get; set; }
        public string Brand { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool HasImage { get; set; }
    }
}
