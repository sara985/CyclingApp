using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Exceptions;

namespace WpfApp1.Models
{
    public class ReservationBook
    {
        private readonly List<Reservation> _reservations;

        public ReservationBook(List<Reservation> reservations)
        {
            _reservations = reservations;
        }

        public IEnumerable<Reservation> GetAllReservations(string username)
        {
            return _reservations;
        }

        public void AddReservation(Reservation res)
        {
            foreach (Reservation existingReservation in _reservations)
            {
                if (existingReservation.Conflicts(res))
                {
                    throw new ReservationConflictException(existingReservation, res);
                }
            }

            _reservations.Add(res);

        }
    }
}
