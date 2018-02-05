using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesLAB9
{
    class Movies
    {
        #region Fields

        private string title;
        private string category;
        private int catnum;
        #endregion
        //Properties
        public string Title
        {
            set { title = value; }

            get { return title; }

        }
        public string Category
        {
            set { category = value; }

            get { return category; }

        }
        public int Catnum
        {
            set { catnum = value; }

            get { return catnum; }
        }

        public Movies(string title, string category, int catnum)
        {
            Catnum = catnum;
            Title = title;
            Category = category;
        }
        //public void PrintInfo(string Movies,string Categories)
        //{
        //    Console.WriteLine(new string('*', 20));
        //    Console.WriteLine(Movies);                //USE THE PROPERTIE NOT THE FIELD
        //    Console.WriteLine(Category);           
        //    Console.WriteLine(new string('*', 20));
        //}
    }
}
