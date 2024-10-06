using SimplyBooksAPI.Models;

namespace SimplyBooksAPI.Data
{
    public class UserData
    {
        public static List<User> Users = new List<User>
        {
            new User
            {
                Id = "1007",
                FirstName = "Zach",
                LastName = "Colburn",
            },
        };
    }
}
