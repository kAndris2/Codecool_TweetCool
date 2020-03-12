using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TweetCool
{
    public class MessageBoardModel : PageModel
    {
        public static List<Tweet> Tweets = new List<Tweet>();

        public void OnGet()
        {

        }
    }
}