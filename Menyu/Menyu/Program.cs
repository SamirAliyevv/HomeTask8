using System;
using System.Net;

namespace Menyu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student [] students=new Student[0];
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
                        string getvalue= Console.ReadLine();
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
                        string fullname=Console.ReadLine();
                        Console.WriteLine("GroupNo daxil edi");
                        string groupno=Console.ReadLine();
                        
                          

                        do
                        {
                            
                            for (int i = 0; i < fullname.Length; i++)
                            {

                                if (fullname[i]>31 && fullname[i]<65)
                                {

                                    Console.WriteLine("FullName daxilinde reqemlerden simvollardan istifade etmek qadagandir");
                                }
                                break;
                            }


                            if (char.IsDigit(groupno[0]))
                            {
                                Console.WriteLine("GroupNo ilk karakteri herf olmalidir ");
                                break;
                            }
                            
                            for (int i = 1; i < groupno.Length; i++)
                            {
                                if (groupno[i]>64 && groupno[i]<91)
                                {

                                    Console.WriteLine("Groupno Daxilinde ilk karakterden sonra reqem olmalidir");

                                }


                            }
                            if (groupno.Length<4)
                            {
                                Console.WriteLine("Groupno 1 boyuk herfden ve davaminda 3 reqemden ibaret olmalidir");
                            }



                        } while (true);

                        Student student = new Student
                        {
                            GroupNo = groupno,
                            FullName = fullname,


                        };
                        Array.Resize(ref students, students.Length + 1);
                        for (int i = 0; i < students.Length; i++)
                        {

                            students[students.Length-1]= student;
                        }
                        while (true);




                        
                }


                break;

            } while (opr!="0");
         




            


        }
    }
}
