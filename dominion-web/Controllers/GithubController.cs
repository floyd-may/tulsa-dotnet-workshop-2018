using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Octokit;

namespace dominion_web.Controllers
{
    public class GithubController : Controller
    {
        private readonly GitHubCredentials _credentials;
        public GithubController(GitHubCredentials credentials)
        {
            _credentials = credentials;
        }

        public async Task<IActionResult> Issues(string owner, string repoName)
        {
            ViewBag.owner = owner;
            ViewBag.repoName = repoName;

            var gh = new GitHubClient(new ProductHeaderValue("Sample-App_floyd-may"));
            gh.Credentials = new Credentials(_credentials.Token);

            var issues = await gh.Issue.GetAllForRepository(owner, repoName);

            return View(issues);
        }
    }
}