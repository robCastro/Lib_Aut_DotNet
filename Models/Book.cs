using System;

namespace TodoApi.Models{

    public class Book{

        public long Id {get; set;}
        public string title {get; set;}
        public DateTime datePub {get; set;}        
        public long authorId {get; set;}
    }

}