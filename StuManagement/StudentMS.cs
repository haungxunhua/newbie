using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StuManagement
{
    class StudentMS:IEnumerable<Student>
    {
        private List<Student> sms = new List<Student>();
        //private int count;
       
        public int Count
        {
            get
            {
                return this.sms.Count;
            }
        }

        public void Add(Student s)
        {
            this.sms.Add(s);
        }
        public int Find(int id)
        {
            if (id <= 0 || id > this.Count)
            {
                throw new IDErrorException("ID is Error!");
            }
            else
            {
                for (int i = 0; i < this.Count; i++)
                {
                    if (this.sms[i].Id.Contains(Student.className + id))
                    {

                        return i;
                    }
                }
                return -1;
            }
        }
        public int DelStudent(int id)
        {
            int index;
            if ((index=this.Find(id)) != -1)
            {
                this.sms.RemoveAt(index);
                return 1;
            }
            else
            {
                return -1;
            }
        }


        public IEnumerator<Student> GetEnumerator()
        {
            for (int i = 0; i < this.sms.Count; i++)
                yield return sms[i];
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
