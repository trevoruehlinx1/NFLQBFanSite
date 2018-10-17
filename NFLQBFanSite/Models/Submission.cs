using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NFLQBFanSite.Models
{
    public class Submission
    {
        private List<Review> reviews = new List<Review>();
        private List<Author> authors = new List<Author>();

        public String Story { get; set; }
        public string Title { get; set; }
        public DateTime SubmissionDate { get; set; }

        public List<Review> Reviews { get{ return reviews; } }
        public List<Author> Authors { get { return authors; } }
    }
}
