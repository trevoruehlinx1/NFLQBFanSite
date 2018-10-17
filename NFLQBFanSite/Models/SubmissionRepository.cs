using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NFLQBFanSite.Models
{
    public static class SubmissionRepository
    {
        //FOR TEMPORARY USE AND TESTING
        private static List<Submission> submissions = new List<Submission>();
        public static List<Submission> Submissions { get { return submissions; } }

        static SubmissionRepository()
        {
            AddTestDataSubmissions();
        }
        public static void AddSubmission(Submission submission)
        {
            submissions.Insert(0, submission);
        }
        public static void AddTestDataSubmissions()
        {
            Submission submission = new Submission
            {
                SubmissionDate = new DateTime(2018, 10, 2),
                Title = "Test story 1",
                Story = "This is test story #1This is test story #1This is test story #1 Test Story #1" +
                "This is test story #1This is test story #1This is test story #1This is test story #1" +
                "This is test story #1This is test story #1This is test story #1This is test story #1"+
                "This is test story #1This is test story #1This is test story #1 Test Story #1 Test Test"+
                "This is test story #1This is test story #1This is test story #1This is test story #1" +
                "This is test story #1This is test story #1This is test story #1This is test story #1",
            };
            submission.Authors.Add(new Author
            {
                Name = "Amanda Field",
                BirthDate = new DateTime(1986,10,2),
                FavQB = "Joe Montana",
                FavTeam = "Tennessee Titans",
            });
            submissions.Add(submission);

            submission = new Submission
            {
                SubmissionDate = new DateTime(2018, 10, 28),
                Title = "Test story 2",
                Story = "This is test story #2This is test story #2This is test story #2" +
                "This is test story #2This is test story #2This is test story #2This is test story #2" +
                "This is test story #2This is test story #2This is test story #2This is test story #2" +
                "This is test story #2This is test story #2This is test story #2This is test story #2" +
                "This is test story #2This is test story #2This is test story #2This is test story #2" +
                "This is test story #2This is test story #2This is test story #2This is test story #2",
            };
            submission.Authors.Add(new Author
            {
                Name = "Trevor Uehlin",
                BirthDate = new DateTime(1978,10,28),
                FavQB = "Aaron Rodgers",
                FavTeam = "Arizona Cardinals",
            });
            submissions.Add(submission);

            submission = new Submission
            {
                SubmissionDate = new DateTime(2017, 8, 19),
                Title = "Test story 3",
                Story = "This is test story #3This is test story #3This is test story #3This is test story #3" +
                "This is test story #3This is test story #3This is test story #3This is test story #3This is test story #3" +
                "This is test story #3This is test story #3This is test story #3This is test story #3This is test story #3" +
                "This is test story #3This is test story #3This is test story #3This is test story #3This is test story #3" +
                "This is test story #3This is test story #3This is test story #3This is test story #3This is test story #3" +
                "This is test story #3This is test story #3This is test story #3This is test story #3This is test story #3",
            };
            submission.Authors.Add(new Author
            {
                Name = "Taylor Uehlin",
                BirthDate = new DateTime(2015, 8, 19),
                FavQB = "Marcus Mariota",
                FavTeam = "Jacksonville Jaguars",
            });
            submissions.Add(submission);
        }
    }
}
