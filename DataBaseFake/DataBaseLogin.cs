using MvcMovie.Models;

namespace MvcMovie.DataBaseFake
{
    public class DataBaseLogin
    {
        public static List<Login> Usuarios = new List<Login>()
        {
            new Login
            {
                Id = 1,
                User = "admin",
                Password = "1234"

            }
        };
    }
}
