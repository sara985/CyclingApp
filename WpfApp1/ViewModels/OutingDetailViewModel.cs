

using WpfApp1.DAO;
using WpfApp1.POCO;

namespace WpfApp1.ViewModels
{
    class OutingDetailViewModel
    {
        private  Outing _outing;
        private int _bikePlacesNeeded;
        private int _passengerPlacesNeeded;

        private OutingDao outingDao = new OutingDao();

        public OutingDetailViewModel()
        {
        }

        public OutingDetailViewModel(Outing outing)
        {
            _outing = outing;
            _bikePlacesNeeded = outingDao.getRequestBikesPlacesByOutingId(outing.Id);
            _passengerPlacesNeeded = outingDao.getRequestPassengerPlacesByOutingId(outing.Id);
        }

        public Outing Outing
        {
            get { return _outing; }
            set { _outing = value; }
        }

        public int BikePlacesNeeded { get => _bikePlacesNeeded; set => _bikePlacesNeeded = value; }
        public int PassengerPlacesNeeded { get => _passengerPlacesNeeded; set => _passengerPlacesNeeded = value; }
    }
}
