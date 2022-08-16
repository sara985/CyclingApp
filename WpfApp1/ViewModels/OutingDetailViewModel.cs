

using WpfApp1.DAO;
using WpfApp1.POCO;

namespace WpfApp1.ViewModels
{
    class OutingDetailViewModel
    {
        private  Outing _outing;
        private int _bikePlacesNeeded;
        private int _passengerPlacesNeeded;
        private int _memberId;

        private OutingDao outingDao = new OutingDao();

        public OutingDetailViewModel(int outingid, int memberId)
        {
            _outing = outingDao.GetById(outingid);
            _bikePlacesNeeded = outingDao.getRequestBikesPlacesByOutingId(outingid);
            _passengerPlacesNeeded = outingDao.getRequestPassengerPlacesByOutingId(outingid);
            _memberId = memberId;
        }

        public OutingDetailViewModel(Outing outing, int memberId)
        {
            _outing = outing;
            _bikePlacesNeeded = outingDao.getRequestBikesPlacesByOutingId(outing.Id);
            _passengerPlacesNeeded = outingDao.getRequestPassengerPlacesByOutingId(outing.Id);
            _memberId= memberId;
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
        public int MemberId { get => _memberId; set => _memberId = value; }
    }
}
