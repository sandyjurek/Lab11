using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Text;

namespace Lab11
{
    public class Movies
    {
        private string _title;
        private string _category;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Category
        {
            get { return _category; }

            set { _category = value; }
        }

        public string Movies(string title, string category)
        {
            Title = title;
            Category = category;
        }

    }
}
