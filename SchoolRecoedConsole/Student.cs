using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SchoolRecoedConsole
{
    class Student
    {
        Dictionary<int, ArrayList> numberNames = new Dictionary<int, ArrayList>();
        public void SaveData(int id,ArrayList data)
        {
             
                numberNames.Add (id, data);
                Console.WriteLine();
                Console.WriteLine("Added Successfully");
                Console.WriteLine("==================================");
                DisplayData();
            
        }
        public void EditData(int id)
        {
            if (numberNames.ContainsKey(id))
            {
                ArrayList arlist = new ArrayList();

                if (numberNames.TryGetValue(id, out arlist))
                {
                    
                    Console.Write("Name is [{0}] ",arlist[0]);
                    string name = Console.ReadLine();
                    if (name=="")
                    {
                        name = arlist[0].ToString();
                    }
                    Console.Write("Mark is [{0}] " , arlist[1]);
                    string mark =Console.ReadLine();
                    if (mark=="")
                    {
                        mark = arlist[1].ToString(); 
                    }
                    int ExamMark = Convert.ToInt32(mark);
                    Console.WriteLine();
                    Console.WriteLine("Updated Successfully");
                    Console.WriteLine("==================================");
                   // ArrayList list = new ArrayList();
                    arlist.Clear();
                    arlist.Add(name);
                    arlist.Add(ExamMark);
                    numberNames[id] = arlist;
                    DisplayData();     
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("No key found");
                Console.WriteLine("==================================");
            }
        }


        public void DisplayData()
        {
            Console.WriteLine();
            Console.WriteLine("=================================");
            Console.WriteLine("AdmNo\tName\tMarks");
            Console.WriteLine("=================================");

            foreach (var i in numberNames)
            {

                Console.Write(i.Key);
                Console.Write("\t");
                Console.Write(i.Value[0]);
                Console.Write("\t");
                Console.WriteLine(i.Value[1]);
            }
            Console.WriteLine("=================================");
            Console.WriteLine();
        }

        public void DeleteData(int id)
        {
            if (numberNames.ContainsKey(id))
            {

                string confirm;
                Console.Write("Sure You Want to Delete- press Y/N  ");
                confirm = Console.ReadLine();
                if (confirm == "Y" || confirm == "y")
                {
                    numberNames.Remove(id);
                    Console.WriteLine();
                    Console.WriteLine("Deleted Successfully");
                    Console.WriteLine("==================================");
                    DisplayData();
                }
                else if (confirm == "N" || confirm == "n")
                {
                    Console.WriteLine();
                    Console.WriteLine("Cancelled");
                    Console.WriteLine("==================================");
                }
                else
                {
                    Console.WriteLine("Invalid Operation");
                    Console.WriteLine("==================================");
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("No key found");
                Console.WriteLine("==================================");
            }
        }

        public  string CheckId(int id)
        {
            string s="";
            if (numberNames.ContainsKey(id))
            {
                
                Console.WriteLine();
                s="Admission Number Already present";
                Console.WriteLine("==================================");
                
            }
            return s;
        }
    }
}
