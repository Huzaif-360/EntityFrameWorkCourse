using System;
using System.Collections.Generic;
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
            var context = new DatabaseFirstDemoEntities();
            var table = new Table_1
            {
               // Body = "Body",
                DatePublished = DateTime.Now,
                Title = "Title",
                PostID = 1

            };
            context.Table_1.Add(table);
            context.SaveChanges();
        }
    }
}
