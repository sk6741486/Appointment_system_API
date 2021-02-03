using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Appointment_system_API.model
{
    public class table
    {
        public int Id { get; set; }
        public string Doctor_Name { get; set; }
        public string Patient_Name { get; set; }
        public string Clinic_name { get; set; }
        public DateTime Appointment_date_time { get; set; }
    }
}
