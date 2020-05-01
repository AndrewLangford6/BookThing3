using System;
using System.Collections.Generic;
using System.Text;

namespace BookThing3
{
    public class Book
    {
       public  int number;
       public  string name;

        public Book(string title, int refNumber)
        {
            number = refNumber;
            name = title;


        }

    }
}
