using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace FirstConsoleApp
{
    public class Book
    {
        public Book(string title, string author, float price)
        {
            Title = title;
            Author = author;
            Price = price;
        }

        private string _title = string.Empty;
        public string Title
        {
            get { return _title; }
            set
            {
                int result;
                bool isDigit = int.TryParse(value[0].ToString(), out result);
                if (string.IsNullOrEmpty(value) || value.Length < 4)
                {
                    throw new ArgumentException("Title not valid!  Must be more than 3 characters!");
                }

                _title = value;
            }
        }

        private string _authorName = string.Empty;
        public string Author
        {
            get { return _authorName; }
            set
            {
                int result;
                bool isDigit = int.TryParse(value[0].ToString(), out result);
                if (isDigit)
                {
                    throw new ArgumentException("Author not valid!  Not allowed to start with number!");
                }

                _authorName = value;
            }
        }

        private float _price = 0.01F;
        public float Price
        {
            get { return _price; }
            set
            {
                if (value <= 0F)
                {
                    throw new ArgumentException("Price not valid!  Cannot be zero or negative!");
                }

                _price = value;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()} Title=`{Title}` Author=`{Author}` Price={Price.ToString("c02")}";
        }

    }
}
