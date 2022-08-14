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
    class MemberListViewModel
    {
        private IList<Member> _memberList;

        public MemberListViewModel()
        {
            MemberDAO memberDAO = new MemberDAO();
            _memberList = memberDAO.List();
        }

        public IList<Member> Members
        {
            get { return _memberList; }
            set { _memberList = value; }
        }

        private ICommand mUpdater;
        public ICommand UpdateCommand
        {
            get
            {
                if (mUpdater == null)
                    mUpdater = new Updater();
                return mUpdater;
            }
            set
            {
                mUpdater = value;
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
