using College.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace College.VM
{
    public class StudentVM
    {
        public Student Student;
        public int Total;
        public string Result;
        public string Grade;
        public int Average;
        public string ColorName;
        public string s1Color;
        public string s2Color;
        public string s3Color;
        public string s4Color;
        public string s5Color;
        public string s6Color;
        public StudentVM(Student s)
        {
            Student = s;
            Total = Student.s1 + Student.s2 + Student.s3 + Student.s4 + Student.s4 + Student.s5 + Student.s6;
            Result = "Fail";
            if (Student.s1 >= 35 && Student.s2 >= 35 && Student.s3 >= 35 && Student.s4 >= 35 && Student.s5 >= 35 && Student.s6 >= 35)
            {
                Result = "Pass";
            }
            if(Student.s1<35)
            {
                s1Color = "red";
            }
            else
            {
                s1Color = "green";
            }   
            if (Student.s2 < 35)
            {
                s2Color = "red";
            }
            else
            {
                s2Color = "green";
            }
            if (Student.s3 < 35)
            {
                s3Color = "red";
            }
            else
            {
                s3Color = "green";
            }
            if (Student.s4 < 35)
            {
                s4Color = "red";
            }
            else
            {
                s4Color = "green";
            }
            if (Student.s5 < 35)
            {
                s5Color = "red";
            }
            else
            {
                s5Color = "green";
            }
            if (Student.s6 < 35)
            {
                s6Color = "red";
            }
            else
            {
                s6Color = "green";
            }
            Grade = "F";
            if (Result == "Pass")
            {
                
                int p = Total / 6;

                if (p >= 90)
                {
                    Grade = "A+";
                }
                else if (p >= 80)
                {
                    Grade = "A";
                }
                else if (p >= 70)
                {
                    Grade = "B";
                }
                else if (p >= 60)
                {
                    Grade = "C";
                }
                else if (p >= 50)
                {
                    Grade = "D";
                }
                else if (p >= 35)
                {
                    Grade = "E";
                }
            }
            Average = Total / 6;
            ColorName = Result == "Pass" ? "green" : "red";
        }
    }
}