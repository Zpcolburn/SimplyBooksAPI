using SimplyBooksAPI.Models;

namespace SimplyBooksAPI.Data
{
    public class BookData
    {
        public static List<Book> Books = new List<Book>
        {
            new Book
            {
                Id = 101,
                AuthorId = 01,
                Title = "A Promised Land",
                Image = "https://images-na.ssl-images-amazon.com/images/I/91+NBrXG-PL.jpg",
                Description = "",
                Price = 24.99M,
                Sale = false,
                UserId = "1007",
            },

            new Book
            {
                Id = 102,
                AuthorId = 02,
                Title = "Children of Blood and Bone",
                Image = "https://images-na.ssl-images-amazon.com/images/I/A1agLFsWkOL.jpg",
                Description = "",
                Price = 12.99M,
                Sale = true,
                UserId = "1007",
            },

            new Book
            {
                Id = 103,
                AuthorId = 03,
                Title = "A People's History of the United States of America",
                Image = "https://images-na.ssl-images-amazon.com/images/I/51529Lfc2ML.jpg",
                Description = "",
                Price = 30.00M,
                Sale = false,
                UserId = "1007",
            },

            new Book
            {
                Id = 104,
                AuthorId = 04,
                Title = "Concrete Rose",
                Image = "https://images-na.ssl-images-amazon.com/images/I/81rRRmZZvZL.jpg",
                Description = "",
                Price = 15.89M,
                Sale = false,
                UserId = "1007",
            },

            new Book
            {
                Id = 105,
                AuthorId = 05,
                Title = "The Underground Railroad",
                Image = "https://images-na.ssl-images-amazon.com/images/I/A1Cu4ywUeyL.jpg",
                Description = "",
                Price = 25.00M,
                Sale = true,
                UserId = "1007",
            },

            new Book
            {
                Id = 106,
                AuthorId = 06,
                Title = "Hood Feminism",
                Image = "https://res.cloudinary.com/bloomsbury-atlas/image/upload/w_360,c_scale/jackets/9781526622402.jpg",
                Description = "",
                Price = 12.99M,
                Sale = true,
                UserId = "1007",
            },

            new Book
            {
                Id = 107,
                AuthorId = 07,
                Title = "A Blade So Black",
                Image = "https://images-na.ssl-images-amazon.com/images/I/81Uf1dTjfQL.jpg",
                Description = "",
                Price = 15.00M,
                Sale = false,
                UserId = "1007",
            },

            new Book
            {
                Id = 108,
                AuthorId = 08,
                Title = "A Dream So Dark",
                Image = "https://m.media-amazon.com/images/I/51BZdlchEsL.jpg",
                Description = "",
                Price = 14.99M,
                Sale = false,
                UserId = "1007",
            },

            new Book
            {
                Id = 109,
                AuthorId = 08,
                Title = "The Fire Next Time",
                Image = "https://images-na.ssl-images-amazon.com/images/I/61GSqXVhhKL.jpg",
                Description = "",
                Price = 12.00M,
                Sale = false,
                UserId = "1007",
            },
        };
    }
}
