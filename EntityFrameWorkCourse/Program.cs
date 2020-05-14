using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Section 2
            //Getting Started
            //Lecture 8
            
        }

    }

    public class Post
    {
        public int Id { get; set; }
        public DateTime DatePublished { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
    public  class BlogContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }

    }
}
