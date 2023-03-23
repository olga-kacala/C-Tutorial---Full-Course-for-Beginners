using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp
{
    public class Song
    {
        public string title;
        public string author;
        public int duration;
        public static int count =0;

        public Song (string aTitle, string aAuthor, int aDuration) {
            title = aTitle;
            author = aAuthor;
            duration = aDuration;
            count++;

        }
    }
}