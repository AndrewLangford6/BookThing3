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

        List<Book> Books = new List<Book>();
        string bad; //for when you don't type in a number
        public Form1()
        {
            InitializeComponent();

            List<string> bookList = File.ReadAllLines("BooksFile.txt").ToList();

            for (int i = 0; i < bookList.Count; i += 2)
            {
                string name = bookList[i + 1];
                int number = Convert.ToInt32(bookList[i]);
                Book a = new Book(name, number);
                Books.Add(a);
                // refBook.Add(score);
            }
        }


        public string LinearSearch(List<Book> searchList, int searchValue)
        {
            foreach (Book i in searchList)
            {
                if (i.number == searchValue)
                {
                    return i.name;
                }
            }
            return "no";
        }
        public string BinarySearch(List<Book> searchList, int searchValue)
        {
            int low = 0;
            int high = searchList.Count - 1;

            while (high >= low)
            {
                int middle = (low + high);
                if (searchList[middle].number == searchValue)
                {
                    return searchList[middle].name;
                }
                else if (searchList[middle].number < searchValue)
                {
                    low = middle + 1;
                }
                else
                {
                    high = middle - 1;
                }
            }
            return "no";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bad = outputLabel.Text;
            try
            {
                Books = Books.OrderBy(x => x.number).ToList();
                int reference = Convert.ToInt32(outputLabel.Text);
                
                string linearWoo = LinearSearch(Books, reference);
                string binaryWoo = BinarySearch(Books, reference);
                bOut.Text = binaryWoo + "";
                lOut.Text = linearWoo + ""; 
            }
            catch
            {
                outputLabel.Text = "why would you type that?\nwhat is wrong with you?\nsee the part where it says number? \nyou wrote '" + bad + "'. Really?" +
                    "\n\nI expect better from you. >:(";
                bOut.Text = "";
                lOut.Text = "";
            }
        }
    }
}
