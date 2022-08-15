

using WpfApp1.POCO;

namespace WpfApp1.ViewModels
{
    class OutingDetailViewModel
    {
        private  Outing _outing;

        public OutingDetailViewModel()
        {
        }

        public OutingDetailViewModel(Outing outing)
        {
            _outing = outing;
        }

        public Outing Outing
        {
            get { return _outing; }
            set { _outing = value; }
        }
    }
}
