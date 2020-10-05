using System;
using System.Collections.Generic;
using System.Text;

namespace FirstConsoleApp
{
    public class GoldenEditionBook : Book
    {
        public GoldenEditionBook(string title, string author, float price) : base(title, author, price)
        {
            this.Price *= 1.30F;
        }
    }
}
