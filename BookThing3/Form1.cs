using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BookThing3
{
    public partial class Form1 : Form
    {

        List<Book> bookList = new List<Book>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> bookList2 = File.ReadAllLines("BooksFile.txt").ToList();

            for (int i = 0; i < bookList.Count; i += 2)
            {
                string title2 = bookList2[i];
                int number = Convert.ToInt32(bookList[i + 1]);
                Book hs = new Book(number, title2);
                bookList.Add(hs);
            }
        }

        public Boolean LinearSearch(List<string> searchList, String searchValue)
        {
            foreach (string s in searchList)
            {
                if (s == searchValue)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
