using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyAnimeList
{
    public class AnimeObject
    {
        public string titulo { get; set; }
        public float score { get; set; }
        public int rank { get; set; }
        public int popularidade { get; set; }
        public int membros { get; set; }      
    }
}
