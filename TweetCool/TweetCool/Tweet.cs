using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TweetCool
{
    public class Tweet
    {
        public String UserName { get; set; }
        public String Message { get; set; }
        public DateTime Date { get; set; }

        public Tweet(string username, string message)
        {
            UserName = username;
            Message = message;
            Date = DateTime.Now;
        }
    }
}
