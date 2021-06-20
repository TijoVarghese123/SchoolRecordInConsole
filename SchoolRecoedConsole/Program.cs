using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace SchoolRecoedConsole
{
    class Program
    {

        static void Main(string[] args)
        {
            int number=1;
            int AdmNo = 0;
            string Name = "";
            int Division = 0;
            Student stud = new Student();
            while (Convert.ToInt32( number)<5)
            {
                Console.WriteLine("Enter a Number");
                Console.WriteLine("1- Add Record");
                Console.WriteLine("2- Edit Record");
                Console.WriteLine("3- Delete Record");
                Console.WriteLine("4- Exit");
                number = Convert.ToInt32(Console.ReadLine());
                if(number==1)
                {
                    
                    Console.WriteLine("Enter Admission Number");
                    AdmNo = Convert.ToInt32(Console.ReadLine());
                    string checkId=stud.CheckId(AdmNo);
                    if(checkId == "")
                    {
                        Console.WriteLine("Enter Your Name");
                        Name = Console.ReadLine();
                        Console.WriteLine("Enter Your Mark");
                        Division = Convert.ToInt32(Console.ReadLine());
                        var arlist1 = new ArrayList();
                        arlist1.Add(Name);
                        arlist1.Add(Division);
                        stud.SaveData(AdmNo, arlist1);
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine( "Admission Number Already Exists");
                        Console.WriteLine("==================================");
                        stud.DisplayData();
                    }
               
                }
                if(number==2)
                {
                    Console.WriteLine("Enter Admission number");
                    int EditAdm = Convert.ToInt32(Console.ReadLine());
                    stud.EditData(EditAdm);
                }
                if(number==3)
                {
                    Console.WriteLine("Enter Admission number");
                    int DeletAdm = Convert.ToInt32(Console.ReadLine());
                    stud.DeleteData(DeletAdm);
                }

                if(number==4)
                {
                    string confirm;
                    Console.Write("Sure You Want to Quit press Y/N  ");
                    confirm = Console.ReadLine();
                    if(confirm=="Y" || confirm=="y")
                    {
                       
                        return;

                    }
                    else if (confirm == "N" || confirm == "n")
                    {
                        Console.WriteLine("Continue Process");
                        Console.WriteLine("==================================");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Operation");
                        Console.WriteLine("==================================");
                    }

                }               
            }   
        }
    }    
}


