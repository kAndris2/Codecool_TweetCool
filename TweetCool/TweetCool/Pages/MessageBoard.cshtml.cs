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
        public static Dictionary<string, List<Tweet>> Messages = new Dictionary<string, List<Tweet>>();

        public void OnGet()
        {

        }
    }
}