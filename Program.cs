

using System;
using System.Linq;
using System.Threading;
namespace EMS
{
   
    class CreateEmplyoee
    {
        string MobileNo,EmployeeId, AddressLine1, AddressLine2, DateOfJoining, FirstName, LastName;
        int Age;
        double CTC;
        DateTime Dob,Doj;
        DayOfWeek day;
        Program program1 = new Program();
        public void AddEmplyoeeId(CreateEmplyoee emp )
        {
            Console.WriteLine("Please Enter Employee ID: ");
            string EId= Console.ReadLine();
            int size = EId.Length;
            string sub = EId.Substring(1,size-1);
            if (EId[0]=='E' && sub.All(c => char.IsDigit(c)))
            {
                emp.EmployeeId = EId;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sorry! Please Follow the Format (E001).");
                Console.ResetColor();
                AddEmplyoeeId(emp);
            }

            
        }

        public void AddFirstName(CreateEmplyoee emp)
        {
            Console.WriteLine("Please Enter Employee First Name: ");
            string FN = Console.ReadLine();
            if(FN.Any(c => char.IsDigit(c)))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Name.");
                Console.ResetColor();
                AddFirstName(emp);
            }
            int size = FN.Length;
            if(size<30 && size>0)
            {
                emp.FirstName = FN;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sorry! Please Give your Name in less than 30 words.");
                Console.ResetColor();
                AddFirstName(emp);
            }

            
        }

        public void AddLastName(CreateEmplyoee emp)
        {
            Console.WriteLine("Please Enter Employee Last Name: ");
            string LN = Console.ReadLine();
            if (LN.Any(c => char.IsDigit(c)))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Name.");
                Console.ResetColor();
                AddLastName(emp);
            }
            int size = LN.Length;
            if (size < 30 && size>0)
            {
                emp.LastName = LN;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sorry! Please Give your Name in less than 30 words.");
                Console.ResetColor();
                AddLastName(emp);
            }
           
        }

        public void AddAddressLine1(CreateEmplyoee emp)
        {
            string Address1temp;
            Console.WriteLine("Please Enter Address Line 1: ");
            Address1temp = Console.ReadLine();
            if(Address1temp.Length>=20)
            {
                AddressLine1 = Address1temp;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Length of Address should be more than 20 characters.");
                Console.ResetColor();
                AddAddressLine1(emp);
            }
        }

        public void AddAddressLine2(CreateEmplyoee emp)
        {
            string Address2temp;
            Console.WriteLine("Please Enter Address Line 2: ");
            Address2temp = Console.ReadLine();
            if (Address2temp.Length >= 20)
            {
                AddressLine2 = Address2temp;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Length of Address should be more than 20 characters.");
                Console.ResetColor();
                AddAddressLine2(emp);
            }

        }

        public void AddDob(CreateEmplyoee emp)
        {
          //  DateTime Dob;
            Console.WriteLine("Please Enter date of Birth <DD/MM/YYYY>: ");
            //accepts date in MM/dd/yyyy format
            Dob = DateTime.Parse(Console.ReadLine());
            //Console.WriteLine(Dob);
            DateTime d1 = Dob;
            DateTime d2 = DateTime.Now;

            TimeSpan t = d2 - d1;
            double NrOfDays = t.TotalDays;
            Age = Convert.ToInt32(NrOfDays / 365);
            if(Age<18)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sorry you are not Eligible for our Company as your age is less than 18.");
                Environment.Exit(0);
                Console.ResetColor();
            }
            //Console.WriteLine(Age);
        }

        public void AddCTC(CreateEmplyoee emp)
        {
            double MonthlySalary;
            Console.WriteLine("Please Enter Monthly Salary: ");
            MonthlySalary = Convert.ToDouble(Console.ReadLine());
            CTC = 12 * MonthlySalary;
            if(CTC<100000)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your CTC is less than 100000 so we can't accept it.");
                Console.ResetColor();
                AddCTC(emp);
            }
            //Console.WriteLine(CTC);
        }

        public void AddMobileNo(CreateEmplyoee emp)
        {
            Console.WriteLine("Please Enter Mobile: ");
            string MN;
            MN = Console.ReadLine();
            int size = MN.Length;
            //Console.WriteLine(size);

            string sub = MN.Substring(1, size-1);
            if (((size > 11 && size<14) && MN[0]=='+') && sub.All(char.IsDigit))
            {
                MobileNo = MN;
            }
            else if (size==10  && sub.All(char.IsDigit)) 
            {
                MobileNo = MN;
            }
            else if((size==11 && MN[0]=='0') && sub.All(char.IsDigit))
            {
                MobileNo = MN;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sorry! Wrong Mobile Number.");
                Console.ResetColor();
                AddMobileNo(emp);
            }
            //Console.WriteLine(MobileNo);


        }

        public void AddDateOfJoining(CreateEmplyoee emp)
        {
            Console.WriteLine("Please Enter the Date of Joining <DD/MM/YYYY>: ");
            Doj =DateTime.Parse( Console.ReadLine());
            //string day;
            day = Doj.DayOfWeek; //enum
            string str = day.ToString(); //string
            Console.WriteLine(str);
        }

        public void PrintData(CreateEmplyoee emp)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(EmployeeId);
            Console.Write(":  ");
            Console.Write(FirstName);
            Console.Write(" ");
            Console.WriteLine(LastName);
            Console.Write(AddressLine1);
            Console.Write(",");
            Console.WriteLine(AddressLine2);
            Console.Write(Age);
            Console.WriteLine(" Years");
            Console.WriteLine("Salary INR {0}",CTC);
            Console.WriteLine(MobileNo);
            Console.WriteLine("Joined On: {0}, {1}",Doj,day);
            //program1.Main();
        }
    }

    class Program
    {
        int flag = 2;
        int ColorSelected = 0;
        static void Main(string[] args)
        {
            
            CreateEmplyoee emp = new CreateEmplyoee();
              Program program = new Program();
            while (program.flag == 2 || program.flag==1)
            {
               
                Console.WriteLine("*********** WelCome To EMS ************");
                int choice;
                Console.WriteLine("1. Add new Employee details");
                Console.WriteLine("2. View the Employee details");
                Console.WriteLine("3. Change the screen settings");
                 Console.WriteLine("4. Exit");

                 Console.Write("Enter Your Choice:- ");
                 choice = Convert.ToInt32(Console.ReadLine());
            
                switch (choice)
                {
                    case 1:
                        program.flag = 1;
                        emp.AddEmplyoeeId(emp);
                        emp.AddFirstName(emp);
                        emp.AddLastName(emp);
                        emp.AddAddressLine1(emp);
                        emp.AddAddressLine2(emp);
                        emp.AddDob(emp);
                        emp.AddCTC(emp);
                        emp.AddMobileNo(emp);
                        emp.AddDateOfJoining(emp);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Thanks for adding details of Employee.");
                        Console.ResetColor();
                        break;
                    case 2:
                        if (program.flag != 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("NO Data Available. Please add the details of an Employee.");
                            Console.ResetColor();
                            //emp.AddEmplyoeeId(emp);
                            //emp.AddFirstName(emp);
                            //emp.AddLastName(emp);
                            //emp.AddAddressLine1(emp);
                            //emp.AddAddressLine2(emp);
                            //emp.AddDob(emp);
                            //emp.AddCTC(emp);
                            //emp.AddMobileNo(emp);
                            //emp.AddDateOfJoining(emp);
                            break;
                        }
                        else
                        {
                            emp.PrintData(emp);
                            Console.WriteLine("1. Continue");
                            Console.WriteLine("2. Exit");
                            int ch;
                            ch = Convert.ToInt32(Console.ReadLine());
                            if (ch == 2)
                            {
                                Environment.Exit(0);
                            }
                            
                        }
                        break;
                    case 3:
                        Console.WriteLine("1. Change the back ground color");
                        Console.WriteLine("2. Change the font color");
                       
                        int colorChoice = Convert.ToInt32(Console.ReadLine());
                        switch (colorChoice)
                        {
                            case 1:
                                int option;

                                Console.WriteLine("1 RED");
                                Console.WriteLine("2 GREEN");
                                Console.WriteLine("3 BLACK");
                                Console.WriteLine("4 WHITE");
                                Console.WriteLine("5 BLUE");
                                option = Convert.ToInt32(Console.ReadLine());
                                switch (option)
                                {
                                    case 1:
                                        if (program.ColorSelected != 1)
                                        {
                                            program.ColorSelected = 1;
                                            Console.BackgroundColor = ConsoleColor.Red;
                                            Console.Clear();

                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("As This is color of your Foreground So please select some other color.");
                                            Console.ResetColor();
                                        }
                                        break;
                                    case 2:
                                        if (program.ColorSelected != 2)
                                        {
                                            program.ColorSelected = 2;
                                            Console.BackgroundColor = ConsoleColor.Green;
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("As This is color of your Foreground So please select some other color.");
                                            Console.ResetColor();
                                        }
                                            break;
                                    case 3:
                                        if (program.ColorSelected != 3)
                                        {
                                            program.ColorSelected = 3;
                                            Console.BackgroundColor = ConsoleColor.Black;
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("As This is color of your Foreground So please select some other color.");
                                            Console.ResetColor();
                                        }
                                            break;
                                    case 4:
                                        if (program.ColorSelected != 4)
                                        {
                                            program.ColorSelected = 4;
                                            Console.BackgroundColor = ConsoleColor.White;
                                            Console.Clear();

                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("As This is color of your Foreground So please select some other color.");
                                            Console.ResetColor();
                                        }
                                        break;
                                    case 5:
                                        if (program.ColorSelected != 5)
                                        {
                                            program.ColorSelected = 5;
                                            Console.BackgroundColor = ConsoleColor.Blue;
                                            Console.Clear();

                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("As This is color of your Foreground So please select some other color.");
                                            Console.ResetColor();
                                        }
                                        break;
                                    default:
                                        Console.BackgroundColor = ConsoleColor.Blue;
                                        Console.Clear();
                                        break;
                                }
                                break;
                            case 2:
                                int option1;

                                Console.WriteLine("1 RED");
                                Console.WriteLine("2 GREEN");
                                Console.WriteLine("3 BLACK");
                                Console.WriteLine("4 WHITE");
                                Console.WriteLine("5 BLUE");
                                option1 = Convert.ToInt32(Console.ReadLine());
                                switch (option1)
                                {
                                    case 1:
                                        if (program.ColorSelected != 1)
                                        {
                                            program.ColorSelected = 1;
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("As This is color of your Background So please select some other color.");
                                            Console.ResetColor();
                                        }
                                        break;
                                    case 2:
                                        if (program.ColorSelected != 2)
                                        {
                                            program.ColorSelected = 2;
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.Clear();

                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("As This is color of your Background So please select some other color.");
                                            Console.ResetColor();
                                        }
                                        break;
                                    case 3:
                                        if (program.ColorSelected != 3)
                                        {
                                            program.ColorSelected = 3;
                                            Console.ForegroundColor = ConsoleColor.Black;
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("As This is color of your Background So please select some other color.");
                                            Console.ResetColor();
                                        }
                                         break;
                                    case 4:
                                        if (program.ColorSelected != 4)
                                        {
                                            program.ColorSelected = 4;
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("As This is color of your Background So please select some other color.");
                                            Console.ResetColor();
                                        }
                                        break;
                                    case 5:
                                        if (program.ColorSelected != 5)
                                        {
                                            program.ColorSelected = 5;
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("As This is color of your Background So please select some other color.");
                                            Console.ResetColor();
                                        }
                                         break;
                                    default:
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.Clear();
                                        break;
                                }
                                break;
                        }
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("Thanks for Visiting us.");
                        Console.ResetColor();
                        program.flag = 0;
                        Timer t = new Timer(timerC, null, 5000, 5000);
                        void timerC(object state)
                        {
                            Environment.Exit(0);
                        }
                        break;


                }
            }
            Console.ReadLine();
        }
            
            
           // Console.Write(emp.EmplyoeeId);

            
            
        }
    }

