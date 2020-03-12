using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace TweetCool.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public void OnPost([FromForm(Name = "username")] string name, [FromForm(Name = "message")] string message)
        {
            List<Tweet> tweets = new List<Tweet>();
            Tweet tweet = new Tweet(name, message);
            tweets.Add(tweet);

            if (MessageBoardModel.Messages.ContainsKey(name))
            {
                MessageBoardModel.Messages[name].Add(tweet);
            }
            else
            {
                MessageBoardModel.Messages.Add(name, tweets);
            }
            Response.Redirect("/MessageBoard");
        }
    }
}
