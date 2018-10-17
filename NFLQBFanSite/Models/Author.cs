using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NFLQBFanSite.Models
{
    public class Author
    {
        private List<Submission> submissions = new List<Submission>();
        public string Name { get; set; }
        public string FavQB { get; set; }
        public string FavTeam { get; set; }
        public DateTime BirthDate { get; set;}

        public List<Submission> Submissions { get{ return submissions; } }
    }
}
