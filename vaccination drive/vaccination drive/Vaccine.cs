using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaccination_drive
{
    class Vaccine
    {
        public string Dose1 { get; set; }

        public string Dose2 { get; set; }
        public string vaccine { get; set; }
        public DateTime vaccine_date { get; set; }
        public Vaccine()
        {

        }
        public Vaccine(string vaccine,DateTime vaccinedate)    // construtor called
        {
            this.vaccine = vaccine;
            this.vaccine_date = vaccinedate;

        }

    }

    public enum Vaccination_Names  //enum for vaccination names
    {
        Cowaxin,
        Covishield,

    }
}
