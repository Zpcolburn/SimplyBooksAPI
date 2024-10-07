using Microsoft.EntityFrameworkCore;
using SimplyBooksAPI.Models;
using System;

namespace SimplyBooksAPI.API
{
    public class BookAPI
    {
        public static void Map(WebApplication app)
        {
            // Get all Books 
            app.MapGet("/books", (SimplyBooksAPIDbContext db) =>
            {
                return db.Books.ToList();
            });

            // Get Single Book (details)
            app.MapGet("/books/{id}", (SimplyBooksAPIDbContext db, int id) =>
            {
                Book book = db.Books
                .Include(book => book.Author)
                .SingleOrDefault(book => book.Id == id);

                if (book == null)
                {
                    return Results.NotFound();
                }
                return Results.Ok(book);

            });

            // Create Book 
            app.MapPost("/books", (SimplyBooksAPIDbContext db, Book newBook) =>
            {
                db.Books.Add(newBook);
                db.SaveChanges();
                return Results.Created($"books/{newBook.Id}", newBook);
            });

            // Update Book
            app.MapPut("/books/{id}", (SimplyBooksAPIDbContext db, int id, Book book) =>
            {
                Book bookToUpdate = db.Books.SingleOrDefault(book => book.Id == id);
                if (bookToUpdate == null)
                {
                    return Results.NotFound();
                }

                bookToUpdate.Title = book.Title;
                bookToUpdate.Image = book.Image;
                bookToUpdate.Description = book.Description;
                bookToUpdate.Price = book.Price;
                bookToUpdate.Sale = book.Sale;

                db.SaveChanges();
                return Results.Ok(bookToUpdate);

            });

            // Delete Book
            app.MapDelete("/books/{id}", (SimplyBooksAPIDbContext db, int id) =>
            {
                Book book = db.Books.SingleOrDefault(book => book.Id == id);

                if (book == null)
                {
                    return Results.NotFound();
                }

                db.Books.Remove(book);
                db.SaveChanges();
                return Results.NoContent();
            });
        }
    }
}