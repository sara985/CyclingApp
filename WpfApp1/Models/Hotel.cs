using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    public class Hotel
    {
        private readonly ReservationBook _reservationbook;

        public string Name { get; }

        public Hotel(string name)
        {
            Name = name;
            _reservationbook = new ReservationBook(new List<Reservation>());
        }

        public Hotel(string name, ReservationBook reservationBook)
        {
            Name = name;
            _reservationbook = reservationBook;
        }
        //13 min 14
        public IEnumerable<Reservation> GetReservationsForUser(string username)
        {
            return _reservationbook.GetReservationsForUser(username);
        }

        public void MakeReservation(Reservation res)
        {
            _reservationbook.AddReservation(res);
        }
    }
}
