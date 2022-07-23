using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid_Registration_System
{

    class Appointment
    {

        private int doctor_ID = 0;

        private int appoint_Num = 0;

        public string date { get; set; }
        public string type { get; set; }

        public string location { get; set; }
        public string reason { get; set; }
        public string situation { get; set; }

        //Generate Doctor ID and appointment number functions
        public int generate_docID()
        {
            Random random = new Random();
            doctor_ID = random.Next(20170000, 20179999);
            return doctor_ID;
        }
        public int generate_appoint()
        {
            Random random = new Random();
            appoint_Num = random.Next(99, 1000);
            return appoint_Num;
        }

    }
}
