using System;

namespace MEMES.API.Models
{
    public class Image
    {
        public int Id { get; set; }
       
        public string Url { get; set; }
        
        public List<Meme> Memes  { get;set; }
    }
}


