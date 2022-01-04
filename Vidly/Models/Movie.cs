using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Group()
        {
            return "";
        }

        public enum Test
        {
            a, //0
            b, //1
            c, //2
            d, //3
            e  //4
        }
    }

    //public struct Student { 
    //}


    //public class Movie2
    //{
    //    public int Movie2ID { get; set; }
    //    public string Movie2Name { get; set; }
    //}
}