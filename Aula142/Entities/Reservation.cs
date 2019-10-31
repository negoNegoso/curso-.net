using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula142.Entities
{
    class Reservation
    {
        public int roomNumber { get; set; }
        public DateTime checkIn { get; set; }
        public DateTime checkOut { get; set; }

        public Reservation()
        {
        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            this.roomNumber = roomNumber;
            this.checkIn = checkIn;
            this.checkOut = checkOut;
        }

        public int duration()
        {
            TimeSpan duration = checkOut.Subtract(checkIn);
            return (int)duration.TotalDays;
        }

        public override string ToString()
        {
            return "Room: " + roomNumber
                + ", check-in: " + checkIn.ToString("dd/MM/yyyy")
                + ", check-out: " + checkOut.ToString("dd/MM/yyyy")
                + ", Duration: " + duration()
                + " nights";
        }

        public void updateDate(DateTime ckin, DateTime ckout)
        {
            checkIn = ckin;
            checkOut = ckout;

        }

    }
}
