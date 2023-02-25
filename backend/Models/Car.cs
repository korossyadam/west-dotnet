namespace backend.Models
{
    public class Car
    {
        public int CarIndex { get; set; }
        public int ChassisIndex { get; set; }
        public string Brand { get; set; }
        public string Chassis { get; set; }
        public string Engine { get; set; }
        public string EngineCode { get; set; }
        public int Kw { get; set; }
        public int Hp { get; set; }
        public int Displacement { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Fuel { get; set; }
    }

}
