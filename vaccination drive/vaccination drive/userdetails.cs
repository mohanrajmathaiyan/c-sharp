using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaccination_drive
{
    class Beneficiarydetails
    {
        //stores beneficiary details
        public string Beneficiary_Name { get; set; }
        public long Beneficiary_Mobile_Number { get; set; }
        public string Beneficiary_City { get; set; }
        public string Beneficiary_gender { get; set; }
        public int Beneficiary_Age { get; set; }
        public int Beneficiary_Registration_number;
        public DateTime Vaccine_date { get; set; }
        public DateTime Next_date { get; set; }
        public string Beneficiary_vaccination_date { get; set; }
        public string Vaccination_Name { get; set; }
        public string Vaccination_Dose_status { get; set; }

        public List<Vaccine> vaccination_details = new List<Vaccine>();
        private static int  Auto_genaratenumber=100;
        public Beneficiarydetails()   // constructor called when object careteing tiem
        {
            Auto_genaratenumber++;
            
        }

        public Beneficiarydetails(string Name,long Mobile_Number,string City,string Gender,int Age)    // constructor called when object careteing tiem
        {
            //values are assigned to the object
            this.Beneficiary_Name = Name;
            this.Beneficiary_Mobile_Number = Mobile_Number;
            this.Beneficiary_City = City;
            this.Beneficiary_gender = Gender;
            this.Beneficiary_Age = Age;
            this.Beneficiary_Registration_number = Auto_genaratenumber;
            Auto_genaratenumber++;
        }
        public string vaccination_Details(string vaccinename,DateTime vaccinedate)     //method for findout the vaccination details of benificiary
        {
            string message = null;
            if (vaccination_details.Count == 0)
            {
                Vaccine details = new Vaccine(vaccinename, vaccinedate);

                message = $"your next dose due date is {details.vaccine_date.AddDays(30).ToShortDateString()}";
                return message;
            }

            else if (vaccination_details.Count == 1)
            {
                if (vaccination_details[0].vaccine_date > vaccination_details[0].vaccine_date.AddDays(30))
                {
                    Vaccine details = new Vaccine(vaccinename, vaccinedate);
                    vaccination_details.Add(details);
                    message = "you have completed your vaccination course and for participation";
                    return message;
                }
                else
                {
                    message = $"You are not allowed for 2nd dose your due date is {vaccination_details[0].vaccine_date.AddDays(30).ToShortDateString()}";
                }

            }
            else
            {
                message = "You had 2 doses already.";
            }
            return message;
            

        }
        public string next_due_date()      //method for checking the due date for the benificiary
        {
            string message = null;
            if(vaccination_details.Count == 0)
            {
                message = $"your next dose due date is {vaccination_details[0].vaccine_date.AddDays(30).ToShortDateString()}";


            }
            else if ((vaccination_details.Count == 0))
            {
                message = "you have completed your vaccination course and for participation";

            }
            return message;
        }
    }
    public enum GENDER      //enum for gender
    {
        Male,
        Female
    }
}
