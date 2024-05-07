using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patify.Models
{
    public class Article
    {
        public int Id { get; set; } 

        public string Content { get; set; }

        public string ArticleHeader { get; set; }

        public string ArticlePhoto { get; set; }
    }
}
