using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace library
{
    [Serializable]
    class Mnage_book:IEnumerable<Book>
    {
        private List<Book> book1 = new List<Book>();

        public List<Book> Book1
        {
            get { return book1; }
            set { book1 = value; }
        }
        public int Count
        {
            get
            {
                return this.book1.Count;
            }
        }
        public void Add(Book s)
        {
            this.book1.Add(s);
        }
        public int Find(long  id)
        {
            if (this.Count == 0)
                return -1;
            else
            {
                for (int i = 0; i < this.Count; i++)
                {
                    if (book1[i].Id == id)
                    {
                        return i;
                    }
                }
                return -1;
            }
        }
        public bool Del(long id)
        {
            if (book1.Count == 0)
                return false;
            else
            {
                int index;
                if ((index = this.Find(id)) != -1)
                {
                    this.book1.RemoveAt(index);
                    return true;
                }
                else
                    return false;
            }
        }
        public IEnumerator<Book> GetEnumerator()
        {
            for (int i = 0; i < book1.Count; i++)
            {
                yield return book1[i];
            }
        }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    
}
