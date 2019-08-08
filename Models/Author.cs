using System;
using System.Collections.Generic;

namespace TodoApi.Models{

    public class Author{
        public long id {get; set;}
        public string firstName {get; set;}
        public string lastName {get; set;}
        public DateTime bornDate {get; set;}

        public virtual ICollection<Book> books {get; set;}
    }

}