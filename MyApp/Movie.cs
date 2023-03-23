using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp
{
    public class Movie
    {
        public string name;
        public string director;
        private string rate;
        
        public Movie (string aName, string aDirector, string aRate) {
            name = aName;
            director = aDirector;
            Rate = aRate;
        }

            public string Rate {

                get {return rate;}
                set {
               if (value == "PG-13" || value == "PG" || value == "NR" ) {
                   rate = value;
                } else {
                    rate = "NR";
                }

                }



                
            }
        }

    }
