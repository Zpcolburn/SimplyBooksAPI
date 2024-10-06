using SimplyBooksAPI.Models;
using static System.Net.Mime.MediaTypeNames;

namespace SimplyBooksAPI.Data
{
    public class AuthorData
    {
        public static List<Author> Authors = new List<Author>
        {
            new Author
            {
                Id = 01,
                Email = "ta@ta.com",
                FirstName = "Tomi",
                LastName = "Adeyemi",
                Image = "https://upload.wikimedia.org/wikipedia/commons/1/17/Tomi_Adeyemi_2020.JPG",
                Favorite = false,
                UserId = "1007", 
            },

            new Author
            {
                Id = 02,
                Email = "ba@obama.com",
                FirstName = "Barack",
                LastName = "Obama",
                Image = "https://upload.wikimedia.org/wikipedia/commons/8/8d/President_Barack_Obama.jpg",
                Favorite = false,
                UserId = "1007"
            },

            new Author
            {
                Id = 03,
                Email = "hz@zinn.com",
                FirstName = "Howard",
                LastName = "Zinn",
                Image = "https://upload.wikimedia.org/wikipedia/commons/e/ef/Howard_Zinn%2C_2009_%28cropped%29.jpg",
                Favorite = false,
                UserId = "1007"
            },

            new Author
            {
                Id = 04,
                Email = "at@thomas.com",
                FirstName = "Angie",
                LastName = "Thomas",
                Image = "https://upload.wikimedia.org/wikipedia/commons/a/a1/Angie_thomas_9022008.jpg",
                Favorite = false,
                UserId = "1007"
            },

            new Author
            {
                Id = 05,
                Email = "cw@whithead.com",
                FirstName = "Colson",
                LastName = "Whitehead",
                Image = "https://upload.wikimedia.org/wikipedia/commons/5/5c/Colson_Whitehead_BBF_2011_Shankbone.JPG",
                Favorite = false,
                UserId = "1007"
            },

            new Author
            {
                Id = 06,
                Email = "mk@kendall.com",
                FirstName = "Mikki",
                LastName = "Kendall",
                Image = "https://upload.wikimedia.org/wikipedia/commons/1/17/Author%2C_activist%2C_and_cultural_critic_Mikki_Kendall.jpg",
                Favorite = false,
                UserId = "1007"
            },

            new Author
            {
                Id = 07,
                Email = "lm@lm.com",
                FirstName = "L.L",
                LastName = "McKinney",
                Image = "https://mpd-biblio-authors.imgix.net/200066919.jpg?fit=crop&crop=faces&w=870&h=870",
                Favorite = false,
                UserId = "1007"
            },

            new Author
            {
                Id = 08,
                Email = "jb@baldwin.com",
                FirstName = "James",
                LastName = "Baldwin",
                Image = "https://upload.wikimedia.org/wikipedia/commons/3/37/James_Baldwin_33_Allan_Warren.jpg",
                Favorite = false,
                UserId = "1007"
            },
        };
    }
}
