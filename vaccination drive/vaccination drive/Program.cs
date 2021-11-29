using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaccination_drive
{
    
    class Program
    {
        public static List<Beneficiarydetails> Beneficiarys = new List<Beneficiarydetails>();
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Vaccination Drive ");
            Console.WriteLine("----------------------------------------------------------------------------");
            Vaccine vaccine = new Vaccine();

            //Adds Default object 1 in the class
            Beneficiarydetails beneficiarydetail_1 = new Beneficiarydetails();
            Vaccine vaccine_1 = new Vaccine();
            
            beneficiarydetail_1.Beneficiary_Name = "mohan";
            beneficiarydetail_1.Beneficiary_Mobile_Number = 9940805509;
            beneficiarydetail_1.Beneficiary_City = "salem";
            beneficiarydetail_1.Beneficiary_gender = GENDER.Male.ToString();
            beneficiarydetail_1.Beneficiary_Age = 23;
            beneficiarydetail_1.Beneficiary_vaccination_date = "23/05/2021";
            beneficiarydetail_1.Beneficiary_Registration_number = 95;
            beneficiarydetail_1.Vaccination_Name = Vaccination_Names.Covishield.ToString();
            beneficiarydetail_1.Vaccination_Dose_status = null;
            Beneficiarys.Add(beneficiarydetail_1);

            //Adds Default object 2 in the class
            Beneficiarydetails beneficiarydetail_2 = new Beneficiarydetails();
            Vaccine vaccine_2 = new Vaccine();

            beneficiarydetail_2.Beneficiary_Name = "raj";
            beneficiarydetail_2.Beneficiary_Mobile_Number = 8072482686;
            beneficiarydetail_2.Beneficiary_City = "chennai";
            beneficiarydetail_2.Beneficiary_gender = GENDER.Male.ToString();
            beneficiarydetail_2.Beneficiary_Age = 22;
            beneficiarydetail_2.Beneficiary_vaccination_date = "15/04/2021";
            beneficiarydetail_1.Beneficiary_Registration_number = 96;
            vaccine_2.Dose1 = "first dose completed";
            beneficiarydetail_2.Vaccination_Dose_status=vaccine_2.Dose1 ; 
            beneficiarydetail_2.vaccination_details.Add(vaccine_2);
            beneficiarydetail_2.Vaccination_Name = Vaccination_Names.Cowaxin.ToString();
            Beneficiarys.Add(beneficiarydetail_2);

            //Adds Default object 3 in the class
            Beneficiarydetails beneficiarydetail_3 = new Beneficiarydetails();
            Vaccine vaccine_3 = new Vaccine();

            beneficiarydetail_3.Beneficiary_Name = "raj";
            beneficiarydetail_3.Beneficiary_Mobile_Number = 8072482686;
            beneficiarydetail_3.Beneficiary_City = "chennai";
            beneficiarydetail_3.Beneficiary_gender = GENDER.Male.ToString();
            beneficiarydetail_3.Beneficiary_Age = 22;
            beneficiarydetail_3.Beneficiary_vaccination_date = "15/04/2021";
            beneficiarydetail_1.Beneficiary_Registration_number = 98;
            beneficiarydetail_3.Vaccination_Dose_status = vaccine.Dose2;
            vaccine_3.Dose1 = "first dose completed";
            vaccine_3.Dose2 = "second dose completed";
            beneficiarydetail_3.vaccination_details.Add(vaccine_3);
            Beneficiarys.Add(beneficiarydetail_3);
            

            string Name, City, Gender,Userchoice2="yes", Next_due_date;
            long Mobile_Numbe;
            int Age, Userchoice1, registration_number,i=0;
            Rechance:  // lable for returning to main menu
            do
            {
                //---MAIN MENU----
                Console.WriteLine("MAIN MENU : ");
                Console.WriteLine(" 1.Beneficiary Registration. \n 2.Vaccination. \n 3.Exit. ");
                Console.WriteLine("To Continue please choose your choice(enter as integer) : ");
                Userchoice1 = int.Parse(Console.ReadLine());
                if (Userchoice1 == 1 || Userchoice1 == 2 || Userchoice1 == 3)
                {
                    if (Userchoice1 == 1)
                    {
                        //creates new beneficiary and adds to the list......
                        Console.WriteLine("you are choosed the Beneficiary Registration. ");
                        Console.WriteLine("Need to fill the below details for the beneficiary registration.");

                        Console.WriteLine("Enter your Name : ");
                        Name = Console.ReadLine();
                        Console.WriteLine("Enter your Mobile Number : ");
                        Mobile_Numbe = long.Parse(Console.ReadLine());
                        Console.WriteLine("Enter your City : ");
                        City = Console.ReadLine();
                        Console.WriteLine("Enter your Gender(male/female) : ");
                        Gender = Console.ReadLine().ToLower();
                        if (Gender == "male")
                        {
                            Gender = GENDER.Male.ToString();
                        }
                        else if (Gender == "female")
                        {
                            Gender = GENDER.Female.ToString();
                        } 

                        Console.WriteLine("Enter your Age : ");
                        Age = int.Parse(Console.ReadLine());
                        
                        Beneficiarydetails beneficiarydetail = new Beneficiarydetails(Name, Mobile_Numbe, City, Gender, Age);
                       
                        Beneficiarys.Add(beneficiarydetail);
                        Console.WriteLine("Your Resistration process has successfully done ");
                        Console.WriteLine("Your Resistration Number is {0}", beneficiarydetail.Beneficiary_Registration_number);
                    }
                    else if (Userchoice1 == 2)
                    {
                        //Vaccination module
                        Console.WriteLine("Enter the Registration Number to Vaccine :");
                        registration_number = int.Parse(Console.ReadLine());
                        foreach(Beneficiarydetails beneficiarys in Beneficiarys)
                        {
                            if(beneficiarys.Beneficiary_Registration_number==registration_number)   //printing of beneficiary details if who is succussfully registered
                            {
                                Console.WriteLine("Beneficiary Name is : {0}", beneficiarys.Beneficiary_Name);
                                Console.WriteLine("Beneficiary Mobile Number is : {0}", beneficiarys.Beneficiary_Mobile_Number);
                                Console.WriteLine("Beneficiary City is : {0}", beneficiarys.Beneficiary_City);
                                Console.WriteLine("Beneficiary Gender is : {0}", beneficiarys.Beneficiary_gender);
                                Console.WriteLine("Beneficiary Age is : {0}", beneficiarys.Beneficiary_Age);

                                Console.WriteLine("Please choose your option : ");
                                Console.WriteLine("1.Vaccine. \n 2.vaccination  history. \n. 3. next due date \n 4. exit");
                                Console.WriteLine("Please enter choose your option(as numbers) : ");
                                int userchoice3 = int.Parse(Console.ReadLine());

                                if (userchoice3 == 1)
                                {
                                    if(beneficiarys.vaccination_details.Count!=2) // checks whether beneficiary has vaccination history
                                    {
                                        //putting the vaccine to the vaccine 
                                        Console.WriteLine("avalabilty vaccines are 1. Covaxin, \n 2.Covishield  ");
                                        Console.WriteLine("Enter the vaccination name (as numbers)  : ");
                                        int vaccine_name = int.Parse(Console.ReadLine());  // get the vaccine name from the user
                                        if (vaccine_name == 1)     // put the covaxin vaccine 
                                        {
                                            beneficiarys.Vaccination_Name = Vaccination_Names.Cowaxin.ToString();
                                            if (beneficiarys.vaccination_details.Count == 0)   //checks for the beneficiary has first dose(for covaxin)
                                            {
                                                vaccine.Dose1 = "first dose completed";
                                                beneficiarys.vaccination_details.Add(vaccine);
                                                beneficiarys.Vaccine_date = DateTime.Today;
                                                Console.WriteLine("your are successfully vaccinated");

                                            }
                                            else if (beneficiarys.vaccination_details.Count == 1)    //checks for the beneficiary has second dose(for covaxin)
                                            {
                                                vaccine.Dose2 = "second dose completed";
                                                beneficiarys.vaccination_details.Add(vaccine);
                                                beneficiarys.Vaccine_date = DateTime.Today;
                                                Console.WriteLine("your are successfully vaccinated");
                                            }
                                        }
                                        if (vaccine_name == 2)    // put the covisheid vaccine  
                                        {
                                            beneficiarys.Vaccination_Name = Vaccination_Names.Covishield.ToString();
                                            if (beneficiarys.vaccination_details.Count == 0)   //checks for the beneficiary has first dose(for covisheid)
                                            {
                                                vaccine.Dose1 = "first dose completed";

                                            }
                                            else if (beneficiarys.vaccination_details.Count == 1)    //checks for the beneficiary has second dose(for covisheid)
                                            {
                                                vaccine.Dose2 = "second dose completed";
                                            }
                                            beneficiarys.vaccination_details.Add(vaccine);
                                            Console.WriteLine("your are successfully vaccinated");
                                            i++;
                                        }

                                    }
                                    else   //print if beneficiary complete the tow vaccine
                                    {
                                        Console.WriteLine("you are already vaccinated of two Doses");
                                    }
                                    
                                }
                                else if (userchoice3 == 2)   // showing beneficiary vaccination history
                                {
                                    Console.WriteLine(beneficiarys.vaccination_Details(beneficiarys.Vaccination_Name, beneficiarys.Vaccine_date));
         
                                }
                                else if (userchoice3 == 3)    // showing benificiary next due date 
                                {
                                    Console.WriteLine(beneficiarys.next_due_date());
                                }
                                else if (userchoice3 == 4)   // move to MAIN MENU
                                {
                                    goto Rechance;
                                }
                            }
                            
                        }
                    }
                    else if (Userchoice1 == 3)      //exit from the application
                    {
                        System.Environment.Exit(0);

                    }
                }
                else
                {
                    Console.WriteLine("Enter the valid choice");
                    Console.WriteLine("Now you are moved to MAIN MENU");
                    goto Rechance;
                }

                Console.WriteLine("Do Want to Continue (yes/no) : ");    //
                Userchoice2 =Console.ReadLine().ToLower();

            } while (Userchoice2 == "yes");

            Console.ReadKey();
 
        }


        
    }
}
