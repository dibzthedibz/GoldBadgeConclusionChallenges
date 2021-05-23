using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutingRepo
{
    public class Outing
    {
        public string Place { get; set; }
        public int Attendance { get; set; }
        public DateTime Date { get; set; }
        public int CostPerPerson { get; set; }
        public int CostPerEvent
        {
            get
            {
                return CostPerPerson * Attendance;
            }
        }

        public Outing() { }
        public Outing(string place, int attendance, DateTime date, int costPerP)
        {
            Place = place;
            Attendance = attendance;
            Date = Date;
            CostPerPerson = costPerP;

        }
    }
}
