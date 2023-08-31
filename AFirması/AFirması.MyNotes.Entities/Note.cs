using AFirması.MyNotes.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFirması.MyNotes.Entities
{
    public class Note : IEntity 
    {
        public int Id { get; set; } 
        public string NoteTitle { get; set; }   
        public string NoteDesciption { get; set; } 

        public int  CategoryId { get; set; }    
        public Category Category { get; set; } 



    }

     
}
