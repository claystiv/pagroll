using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pol;

    internal class pagroll
    {

        
               static StreamReader Leer;
               static StreamWriter Escribir;

            

            static void Main(string[] args)
              {
            int Op;
            int op_1 = 0;

            data da = new data();
                
                do
              {
                Console.Clear();
                Console.WriteLine("Pagroll 2022\n\n");
                Console.WriteLine("1) Enter data \n2) show data \n3) search person\n4) exit \n\nyour choice : ");
                Op = int.Parse(Console.ReadLine());

                if (Op == 1)
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Write a new record\n\n");
                        Escribir = new StreamWriter(@"C:\Users\Cristian Murcia\Documents\tut\pagroll\registro.txt", true);
                            //INGRESA DATOS
                        Escribir.WriteLine("-------------------------------- New employee record ---------------------------------");
                        Escribir.WriteLine(DateTime.Now.ToString());
                        Console.Write("\n* Enter the document : ");
                        da.document = double.Parse(Console.ReadLine());
                        Escribir.WriteLine($"\ndocument : { da.document}");
                        Console.Write("\n* Enter the firstName: ");
                        da.firstName = Console.ReadLine();
                        Escribir.WriteLine($"\nfirstName : { da.firstName}");
                        Console.Write("\n* Enter the lostName: ");
                        da.lostName = Console.ReadLine();
                        Escribir.WriteLine($"\nlostName : { da.lostName}");
                        Console.Write("\n* enter the salary : ");
                        da.salary = double.Parse(Console.ReadLine());
                        Escribir.WriteLine($"\nsalary : { da.salary}");
                        Console.Write("\n* enter the workdDays : ");
                        da.workdDays = Int32.Parse(Console.ReadLine());
                        Escribir.WriteLine($"\nworkdDays : { da.workdDays}");


                    if (da.salary < 2000000)
                    {
                        Console.Write("\n* enter the transportation assistance : ");
                        da.transportation = double.Parse(Console.ReadLine());
                        da.totalTransport = da.transportation * da.workdDays / 30;
                    }
                    else
                    {
                        da.totalTransport = 0;
                    }

                    da.accrued = da.totalSalary + da.totalTransport;
                    da.totalSalary = da.salary * da.workdDays / 30;
                    da.health = da.accrued * 0.04;
                    da.pension = da.accrued * 0.04;
                    da.total = da.totalSalary + da.totalTransport - da.health - da.pension;


                    Escribir.WriteLine($"\naccrued :  {da.accrued}");
                    Escribir.WriteLine($"\nhealth :  {da.health}");
                    Escribir.WriteLine($"\npension :  {da.pension}");
                    Escribir.WriteLine($"\npaid days worked :  {da.totalSalary}");
                    Escribir.WriteLine($"\ntotal :  {da.total}");

                    Console.WriteLine($"\nDocument : {da.document} \nFirst Name : {da.firstName} \nLost Name :  {da.lostName} \nworkdDays : {da.workdDays} \ntotalSalary : {da.totalSalary}  \naccrued : {da.accrued} \nhealth : {da.health} \npension : {da.pension} \ntotal : {da.total}");


                    Console.WriteLine("\n\n");
                        String Cadena = Console.ReadLine();
                        Escribir.WriteLine(Cadena);
                        Escribir.Close();


                        Console.WriteLine("The record has been created successfully.\n\n5) Back to main menu\n6) Enter a new user");
                        Console.Write("\nyour choice : ");
                           
                            op_1 = int.Parse(Console.ReadLine());
                    } while (op_1 == 6);
                }

                if (Op == 2)
                {
                    string Linea;
                    int contador = 0;
                    Console.Clear();
                    Leer = new StreamReader(@"C:\Users\Cristian Murcia\Documents\tut\pagroll\registro.txt", true);
                    Console.WriteLine("Showing all records : \n\n");
                    while ((Linea = Leer.ReadLine()) != null)
                    {
                        Console.WriteLine(Linea);
                        contador++;
                    }
                    Leer.Close();

                    Console.WriteLine("\nThe record was displayed successfully.\n\n5) Back to main menu\n");
                    Console.Write("\nyour choice : ");
                    op_1 = int.Parse(Console.ReadLine());
                }

                if (Op == 3)
                {


                    string Linea;
                    int contador = 0;
                    string result_s;
                    Console.Clear();
                    Leer = new StreamReader(@"C:\Users\Cristian Murcia\Documents\tut\pagroll\registro.txt", true);
                    Console.WriteLine("Search record by document number : \n\n");
                    Console.Write("enter the document number : ");
                    result_s = Console.ReadLine();
                    if ((Linea = Leer.ReadLine()) == result_s)
                    {
                        do
                        {
                            Console.WriteLine(Linea);
                            contador++;
                        } while ((Linea = Leer.ReadLine()) != " ");
                    }
                    Leer.Close();

                Console.WriteLine("\nThe record was displayed successfully.\n\n5) Back to main menu\n");
                Console.Write("\nyour choice : ");
                op_1 = int.Parse(Console.ReadLine());
                }
                Console.ReadKey();
            } while (op_1 == 5);
        }
    }

