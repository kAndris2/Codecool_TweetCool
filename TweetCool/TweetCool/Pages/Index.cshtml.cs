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
            MessageBoardModel.Tweets = new DataManager().Import();
        }

        public void OnPost([FromForm(Name = "username")] string name, [FromForm(Name = "message")] string message)
        {
            MessageBoardModel.Tweets.Add(new Tweet(name, message));
            new DataManager().Save(MessageBoardModel.Tweets);
            Response.Redirect("/MessageBoard");
        }
    }
}
