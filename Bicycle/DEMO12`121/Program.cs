
using System;
using System.Net;

namespace DEMO12_121
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Velosiped Sayi : ");
            string countstr = Console.ReadLine();
            int count = Convert.ToInt32(countstr);
            Bicycle[] velosiped = new Bicycle[count];
            for (int i = 0; i < velosiped.Length; i++)
            {
                string brand;
                do
                {
                    Console.WriteLine("Brand : ");
                    brand = Console.ReadLine();


                } while (string.IsNullOrEmpty(brand));
                string model;
                do
                {
                    Console.WriteLine("Model : ");
                    model = Console.ReadLine();

                } while (string.IsNullOrEmpty(model));

                Bicycle bc = new Bicycle(brand, model)
                {
                    Brand = brand,
                    Model = model
                };
                velosiped[i] = bc;
            }
            string opr;
            do
            {

                Console.WriteLine("1.Velosipedlerin butun melumatlari");
                Console.WriteLine("2.Velosipedlerin Modelleri arasinda axtaris etmek");
                Console.WriteLine("0.Menyunu terk et");
                Console.WriteLine("Eminsiniz y/n");
                 opr = Console.ReadLine();
                if (opr == "1")
                {
                    foreach (var item in velosiped)
                    {
                        Console.WriteLine($"Brand : {item.Brand} Model : {item.Model} Millage : {item.Millage}");


                    }
                }
                else if (opr         == "2")
                {
                    Console.WriteLine("Modeli daxil edin");
                    string wantedmodel = Console.ReadLine();
                    foreach (var item in velosiped)
                    {
                        if (item.Model.Contains(wantedmodel))
                        {
                            Console.WriteLine($"Brand : {item.Brand}  Model : {item.Model} Millage : {item.Millage}");
                        }

                    }
                }
                    
            } while (opr != "0");
        }
               

            
        
    }
}
