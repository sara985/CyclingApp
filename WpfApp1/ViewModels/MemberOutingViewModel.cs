using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp1.DAO;
using WpfApp1.POCO;

namespace WpfApp1.ViewModels
{
    class MemberOutingViewModel
    {
        private IList<Outing> _outingList;
        
        public MemberOutingViewModel()
        {
            OutingDao outingDao = new OutingDao();
            _outingList = outingDao.List();
        }

        public IList<Outing> Outings
        {
            get { return _outingList; }
            set { _outingList = value; }
        }

        private ICommand oUpdater;
        public ICommand UpdateCommand
        {
            get
            {
                if (oUpdater == null)
                    oUpdater = new Updater();
                return oUpdater;
            }
            set
            {
                oUpdater = value;
            }
        }

        private class Updater : ICommand
        {
            #region ICommand Members  

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public event EventHandler CanExecuteChanged;

            public void Execute(object parameter)
            {

            }
            #endregion  
        }

    }


    
}
