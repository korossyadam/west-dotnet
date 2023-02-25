using backend.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarSelectorController : ControllerBase
    {

        private string connectionString = "Server=tcp:west.database.windows.net,1433;Initial Catalog=west;Persist Security Info=False;User ID=CloudSAa6d89434;Password=zGN@FcR6S9HzULe;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        private readonly ILogger<CarSelectorController> _logger;

        public CarSelectorController(ILogger<CarSelectorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("chassis/{brand}", Name = "GetChassis")]
        public IEnumerable<Chassis> GetChassis(string Brand)
        {
            List<Chassis> resultList = new List<Chassis>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM chassis WHERE brand = @Brand ORDER BY Name";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Brand", Brand);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Chassis chassis = new Chassis();
                            chassis.ChassisIndex = reader.GetInt16(reader.GetOrdinal("ChassisIndex"));
                            chassis.Brand = reader.GetString(reader.GetOrdinal("Brand"));
                            chassis.Name = reader.GetString(reader.GetOrdinal("Name"));
                            if (!reader.IsDBNull(reader.GetOrdinal("StartDate")))
                                chassis.StartDate = reader.GetDateTime(reader.GetOrdinal("StartDate"));
                            if (!reader.IsDBNull(reader.GetOrdinal("EndDate")))
                                chassis.EndDate = reader.GetDateTime(reader.GetOrdinal("EndDate"));
                            chassis.HasImage = reader.GetBoolean(reader.GetOrdinal("HasImage"));

                            resultList.Add(chassis);
                        }
                    }
                }
            }

            return resultList;
        }

        [HttpGet("cars/{chassis}", Name = "GetCars")]
        public IEnumerable<Car> GetCars(string Chassis)
        {
            List<Car> resultList = new List<Car>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM cars WHERE chassis = @Chassis";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Chassis", Chassis);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Car car = new Car();
                            car.CarIndex = reader.GetInt32(reader.GetOrdinal("CarIndex"));
                            car.Brand = reader.GetString(reader.GetOrdinal("Brand"));
                            car.ChassisIndex = reader.GetInt32(reader.GetOrdinal("ChassisIndex"));
                            car.Chassis = reader.GetString(reader.GetOrdinal("Chassis"));
                            car.Engine = reader.GetString(reader.GetOrdinal("Engine"));
                            car.EngineCode = reader.GetString(reader.GetOrdinal("EngineCode"));
                            if (!reader.IsDBNull(reader.GetOrdinal("StartDate")))
                                car.StartDate = reader.GetDateTime(reader.GetOrdinal("StartDate"));
                            if (!reader.IsDBNull(reader.GetOrdinal("EndDate")))
                                car.EndDate = reader.GetDateTime(reader.GetOrdinal("EndDate"));
                            if (!reader.IsDBNull(reader.GetOrdinal("Kw")))
                                car.Kw = reader.GetInt16(reader.GetOrdinal("Kw"));
                            if (!reader.IsDBNull(reader.GetOrdinal("Hp")))
                                car.Hp = reader.GetInt16(reader.GetOrdinal("Hp"));
                            if (!reader.IsDBNull(reader.GetOrdinal("Displacement")))
                                car.Displacement = reader.GetInt16(reader.GetOrdinal("Displacement"));
                            car.Fuel = reader.GetString(reader.GetOrdinal("Fuel"));

                            resultList.Add(car);
                        }
                    }
                }
            }

            return resultList;
        }
    }
}