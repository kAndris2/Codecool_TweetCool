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
            if (message.Length > 70)
            {
                string text = "";
                int count = 0;
                for (int i = 0; i < message.Length; i++)
                {
                    text += message[i];
                    count++;
                    if (count == 70)
                    {
                        text += "\n";
                        count = 0;
                    }
                }
                message = text;
            }

            MessageBoardModel.Tweets.Add(new Tweet(name, message));
            new DataManager().Save(MessageBoardModel.Tweets);
            Response.Redirect("/MessageBoard");
        }
    }
}
