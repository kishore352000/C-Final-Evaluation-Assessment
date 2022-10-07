using System;
using System.Collections;
using System.Collections.Generic;

namespace Phonebook_Q2
{
    public class Phonebook
    {
        public class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public int ph { get; set; }
            public override string ToString()
            {
                return Name + "," + Age;
            }
        }
        public class Citizen
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public int ph { get; set; }
            public override string ToString()
            {
                return Name + "," + Age;
            }
        }
        public class Service
        {
            public string Name { get; set; }
            public string Prof { get; set; }
            public int Age { get; set; }
            public int ph { get; set; }
            public override string ToString()
            {
                return Name + "," + Age + "," + Prof;
            }
        }



    }
    internal class Class8
    {
        static void Main()
        {
            Queue<Phonebook.Student> st = new Queue<Phonebook.Student>();
            Queue<Phonebook.Citizen> cc = new Queue<Phonebook.Citizen>();
            Queue<Phonebook.Service> ss = new Queue<Phonebook.Service>();
            for (int i = 0; i < 10; i++)
            {
                String s = Console.ReadLine();
                string[] sp = s.Split(',');
                if (sp.Length == 3)
                {
                    int k = Int16.Parse(sp[1]);
                    if (k >= 21)
                    {
                        st.Enqueue(new Phonebook.Student()
                        {
                            Name = sp[0],
                            Age = Int16.Parse(sp[1]),
                            ph = Int32.Parse(sp[2])
                        });




                    }
                    else
                    {
                        cc.Enqueue(new Phonebook.Citizen()
                        {
                            Name = sp[0],
                            Age = Int16.Parse(sp[1]),
                            ph = Int32.Parse(sp[2])
                        });
                    }
                }
                else
                {
                    ss.Enqueue(new Phonebook.Service()
                    {
                        Name = sp[0],
                        Prof = sp[1],
                        Age = Int16.Parse(sp[2]),
                        ph = Int32.Parse(sp[3])
                    });
                }
            }
            Console.WriteLine("Students:");
            foreach (Phonebook.Student p in st)
            {
                Console.WriteLine(p.ToString());
            }
            Console.WriteLine("Service and Professionals:");
            foreach (Phonebook.Service p in ss)
            {
                Console.WriteLine(p.ToString());
            }
            Console.WriteLine("Citizens:");
            foreach (Phonebook.Citizen p in cc)
            {
                Console.WriteLine(p.ToString());
            }






        }
    }
}
