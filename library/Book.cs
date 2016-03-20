using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace library
{
   [Serializable]
 
    class Book
    {
       

        private int book_number;

        public int Book_number
        {
            get { return book_number; }
            set { book_number = value; }
        }
        public static int sum=0;
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private long id;

        public long Id
        {
            get { return id; }
            set { id = value; }
        }
        private string author;

        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        private string publish_company;

        public string Publish_company
        {
            get { return publish_company; }
            set { publish_company = value; }
        }
        private long publish_time;

        public long Publish_time
        {
            get { return publish_time; }
            set { publish_time = value; }
        }
        private string kind;

        public string Kind
        {
            get { return kind; }
            set { kind = value; }
        }
        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public Book()
        {
            sum++;
        }
        public Book(string name, long id, string author, string publish_company, long publish_time, string kind, double price,int number)
        {
            this.name = name;
            this.id = id;
            this.author = author;
            this.publish_company = publish_company;
            this.publish_time = publish_time;
            this.price = price;
            this.kind = kind;
            this.book_number = number;
            sum++;

        }
        public override string ToString()
        {
            return string.Format("name:{0};id:{1};author:{2};publish_company:{3};publish_time:{4};kind:{5};price:{6};book_number{7}", name, id, author, publish_company, publish_time, kind, price,book_number);
        }
    }
}
