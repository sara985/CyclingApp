using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Models;

namespace WpfApp1.ViewModels
{
    class ReservationViewModel : ViewModelBase
    {
        private readonly Reservation _reservation;
        public string RoomID => _reservation.RoomID.ToString();
        public string Username => _reservation.Username;
        public string StartDate => _reservation.StartTime.ToShortDateString();
        public string EndDate => _reservation.EndTime.ToShortDateString();

        public ReservationViewModel(Reservation res)
        {
            _reservation = res;
        }

        

    }
}
