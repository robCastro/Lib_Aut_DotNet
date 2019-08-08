using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace TodoApi.Contexts {

    public class AuthorContext : DbContext{
        
        public AuthorContext(DbContextOptions<AuthorContext> options) : base(options){

        }

        public DbSet<Author> authors {get; set;}
        public DbSet<Book> books {get; set;}
    }

}