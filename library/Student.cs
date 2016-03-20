using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace library
{
[Serializable]
  public   class Student
    {
        private long id;

        public long Id
        {
            get { return id; }
            set { id = value; }
        }
    public int number=0;
    private int book_number = 0;

    public int Book_number
    {
        get { return book_number; }
        set { book_number = value; }
    }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string sex;

        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        private long birth;

        public long Birth
        {
            get { return birth; }
            set { birth = value; }
        }
        private string job_unit;

        public string Job_unit
        {
            get { return job_unit; }
            set { job_unit = value; }
        }
  public  Student ()
        {
            number++;

        }
    public Student(long id,int book_number,string  name,string sex,long birth,string job)
  {
      this.id = id;
      this.book_number = number;
      this.name = name;
      this.sex = sex;
      this.birth = birth;
      this.job_unit = job;
      number++;
  }
    public override string ToString()
    {
        return string.Format("id:{0};book_number:{1};name:{2};sex:{3};birth:{4};job:{5}}",id,book_number,name,sex,birth,job_unit);
    }
    }
}
