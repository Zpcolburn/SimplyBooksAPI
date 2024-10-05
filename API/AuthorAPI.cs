using Microsoft.EntityFrameworkCore;
using SimplyBooksAPI.Models;
using System;
namespace SimplyBooksAPI.API
{
    public class AuthorAPI
    {
        public static void Map(WebApplication app)
        {
            // Get all authors
            app.MapGet("/authors", (SimplyBooksAPIDbContext db) =>
            {
                return db.Authors.Include(p => p.Books).ToList();
            });

            // Get author by ID
            app.MapGet("/authors/{id}", (SimplyBooksAPIDbContext db, int id) =>
            {
                var author = db.Authors
                                .Include(a => a.Books)
                                .FirstOrDefault(a => a.Id == id);
                if (author == null)
                {
                    return Results.NotFound();
                }
                return Results.Ok(author);
            });

            // Create new author
            app.MapPost("/authors", (SimplyBooksAPIDbContext db, Author newAuthor) =>
            {
                db.Authors.Add(newAuthor);
                db.SaveChanges();
                return Results.Created($"authors/{newAuthor.Id}", newAuthor);
            });

            // Update single author
            app.MapPut("/authors/{id}", (SimplyBooksAPIDbContext db, int id, Author author) =>
            {
                Author authorToUpdate = db.Authors.SingleOrDefault(author => author.Id == id);

                if (authorToUpdate == null)
                {
                    return Results.NotFound();
                }

                authorToUpdate.FirstName = author.FirstName;
                authorToUpdate.LastName = author.LastName;
                authorToUpdate.Email = author.Email;
                authorToUpdate.Image = author.Image;
                authorToUpdate.Favorite = author.Favorite;

                db.SaveChanges();
                return Results.Ok(authorToUpdate);
            });

            // Delete author
            app.MapDelete("/authors/{id}", (SimplyBooksAPIDbContext db, int id) =>
            {
                Author author = db.Authors.SingleOrDefault(author => author.Id == id);

                if (author == null)
                {
                    return Results.NotFound();
                }

                db.Authors.Remove(author);
                db.SaveChanges();
                return Results.NoContent();
            });
        }
    }
}
