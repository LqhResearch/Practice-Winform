using System;

namespace Lab_290622
{
    class Student
    {
        public string Name { get; set; }
        public bool Gender { get; set; }
        public int Birthday { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Course { get; set; }

        public Student()
        {
            Name = "";
            Gender = true;
            Birthday = 0;
            Phone = "";
            Address = "";
            Course = "";
        }

        public Student(string name, bool gender, int birthday, string phone, string address, string course)
        {
            Name = name;
            Gender = gender;
            Birthday = birthday;
            Phone = phone;
            Address = address;
            Course = course;
        }

        public int Age()
        {
            return DateTime.Now.Year - Birthday;
        }
    }
}
