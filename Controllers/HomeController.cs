using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using formWithDbConn.Models;
using System.Diagnostics;


namespace studentform.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(Student std)
        {
           
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DbConn;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand comman = new SqlCommand("INSERT INTO Regester(Name,Age,Country,State,City,PhNo,Email,Gender)VALUES(@Name,@Age,@Country,@State,@City,@PhNo,@Emailid,@Gender)", connection);
            comman.Parameters.AddWithValue("@Name", std.Name);
            comman.Parameters.AddWithValue("@Age", std.Age);
            comman.Parameters.AddWithValue("@Country", std.Country);
            comman.Parameters.AddWithValue("@State", std.State);
            comman.Parameters.AddWithValue("@City", std.City);
            comman.Parameters.AddWithValue("@PhNo", std.PhNo);
            comman.Parameters.AddWithValue("@Emailid", std.Emailid);
            comman.Parameters.AddWithValue("@Gender", std.Gender);

            comman.ExecuteNonQuery();
            connection.Close();

            return View();
        }

    }
}
