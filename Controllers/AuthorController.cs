using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TodoApi.Models;
using TodoApi.Contexts;
using System;

namespace TodoApi.Controllers{

    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase{

        private readonly AuthorContext _context;

        public AuthorController(AuthorContext context){
            _context = context;
            if (_context.authors.Count() == 0){
                _context.authors.Add(new Author{
                    firstName = "Profesor",
                    lastName = "Uno",
                    bornDate = DateTime.Now.Date
                });
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public ActionResult<List<Author>> GetAll(){
            return _context.authors.ToList();
        }

        [HttpGet("{id}", Name = "GetAuthor")]
        public ActionResult<Author> GetById(long id){
            var author = _context.authors.Find(id);
            if(author == null){
                return NotFound();
            }
            return author;
        }
    }

}