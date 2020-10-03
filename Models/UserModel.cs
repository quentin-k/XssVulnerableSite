using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XssVulnerableSite.Models
{
    public class JsInput
    {
        public string FavoriteColor { get; set; }
    }
    public class HtmlInput
    {
        public string Name { get; set; }
    }

    public class CommentInput
    {
        public string FavoriteFood { get; set; }
    }
}