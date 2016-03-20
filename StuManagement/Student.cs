using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StuManagement
{
    class Student
    {
        public static string className;
        private string id;
        private string name;
        private int age;
        private string sex;
        private string hometown;
        private string favs;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Favs
        {
            get { return favs; }
            set { favs = value; }
        }
        public string Hometown
        {
            get { return hometown; }
            set { hometown = value; }
        }
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private static int sid;

        static Student()
        {
            sid = 0;
            className = "Net2014";
        }
        public Student(string name,int age,string sex,string hometown,string favs)
        {
            sid++;
            this.id = className + sid;
            this.name = name;
            this.age = age;
            this.sex = sex;
            this.hometown = hometown;
            this.favs = favs;
        }

        public override string ToString()
        {
            return string.Format("id:{0}；name:{1};age:{2};sex:{3};hometown:{4};favs:{5}",id,name,age,sex,hometown,favs);
        }

        
    }
}
