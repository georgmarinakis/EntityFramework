using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{

    public class Course
    {
        public int Id { get; set; } //key
        public string Name { get; set; }
        public string Description { get; set; }
        public CourseLevel Level { get; set; } // navigation property
        public float FullPrice { get; set; }
        public Author Author { get; set; } // navigation property
        public IList<Tag> Tags { get; set; } //one-to-many
    }
}
