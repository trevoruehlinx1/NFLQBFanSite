using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NFLQBFanSite.Models;
using Microsoft.AspNetCore.Mvc;

namespace NFLQBFanSite.Controllers
{
    public class HistoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SubmitStories()
        {
            return View();
        }
        public IActionResult ReadStories()
        {
            List<Submission> submissions = SubmissionRepository.Submissions;

            return View(submissions);
        }
        [HttpPost]
        public RedirectToActionResult AddSubmission(string name,string title,string story, string favTeam,string favQB)
        {
            if(story != null)
            {
                Submission submission = new Submission
                {
                    SubmissionDate = DateTime.Now,
                    Title = title,
                    Story = story,
                };
                submission.Authors.Add(new Author
                {
                    Name = name,
                    FavQB = favQB,
                    FavTeam = favTeam,

                });
                SubmissionRepository.AddSubmission(submission);
                
                return RedirectToAction("ReadStories");
            }
            return RedirectToAction("SubmitStories");

        }
    }
}