using System;
using System.Net;

namespace Menyu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[0];
            string opr;



            do
            {
                Console.WriteLine("Emeliyyat secin ");
                Console.WriteLine("1.Butun siyahiya baxin ");
                Console.WriteLine("2.Mezmuna gore axtaris edin");
                Console.WriteLine("3.Telebe elave edin");
                Console.WriteLine("0.Menyunu terk et");
                opr = Console.ReadLine();




                switch (opr)
                {


                    case "1":
                        for (int i = 0; i < students.Length; i++)
                        {

                            Console.WriteLine($"FullName: {students[i].FullName}  GroupNo :  {students[i].GroupNo}");

                        }

                        break;

                    case "2":


                        Console.WriteLine("Hansi deyeri axtarirsiz");
                        string getvalue = Console.ReadLine();
                        for (int i = 0; i < students.Length; i++)
                        {

                            if (students[i].FullName.Contains(getvalue) || students[i].GroupNo.Contains(getvalue))
                            {

                                Console.WriteLine($"FullName :  {students[i].FullName}   GroupNo : {students[i].GroupNo} ");

                            }




                        }
                        break;

                    case "3":
                        Console.WriteLine("FullName daxil edin");
                        string fullname = Console.ReadLine();


                        
                        string groupno;

                        do
                        {

                            Console.WriteLine("GroupNo daxil edi");
                            groupno = Console.ReadLine();








                        } while (!CheckGroupNo(groupno));

                        Student student = new Student
                        {
                            GroupNo = groupno,
                            FullName = fullname,


                        };
                        Array.Resize(ref students, students.Length + 1);
                        for (int i = 0; i < students.Length; i++)
                        {

                            students[students.Length - 1] = student;
                        }




                        break;



                }




            } while (opr != "0");








        }



        static bool CheckGroupNo(string groupno)
        {

            bool checkno = false;

            if (!char.IsUpper(groupno[0]))
            {
                return false;
            }
            if (char.IsDigit(groupno[0]))
            {
                return false;

            }

            for (int i = 1; i < groupno.Length; i++)
            {
                if (char.IsDigit(groupno[i]))
                {
                    checkno = true;
                }
                else
                {
                    return false;
                }
            }
          

            if (checkno == false)
            {
                return false;
            }

            else
            {
                return true;
            }
        }


    }



}







