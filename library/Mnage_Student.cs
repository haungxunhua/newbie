using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace library
{
     [Serializable]
   class Mnage_Student : IEnumerable<Student>
    {
        private List<Student> stu1 = new List<Student>();

        internal List<Student> Stu1
        {
            get { return stu1; }
            set { stu1 = value; }
        }


        private int Count1;
       
        

public int Count11
{
  get { return Count1; }
  set { Count1 = value; }
}
         public void Add(Student s)
        {
            this.stu1.Add(s);
        }
        public int Find(long id)
        {
            if (this.Count1 == 0)
                return -1;
            else
            {
                for (int i = 0; i < this.Count1; i++)
                {
                    if (stu1[i].Id == id)
                    {
                        return i;
                    }
                }
                return -1;
            }
        }
        public bool Del(long id)
        {
            if (stu1.Count == 0)
                return false;
            else
            {
                int index;
                if ((index = Find(id)) != -1)
                {
                    this.stu1.RemoveAt(index);
                    return true;
                }
                else
                    return false;
            }
        }
        public IEnumerator<Student> GetEnumerator()
        {
            for (int i = 0; i < stu1.Count; i++)
            {
                yield return stu1[i];
            }
        }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        
    }
}
