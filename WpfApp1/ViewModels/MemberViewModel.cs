using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.DAO;
using WpfApp1.POCO;

namespace WpfApp1.ViewModels
{
    class MemberViewModel
    {
        private Member _member;
        private Vehicle? _vehicle;
        private List<Category> _categories;
        private IList<Bike> _bikes;
        private IList<Outing> _outing;

        private MemberDAO memberDao = new MemberDAO();
        private OutingDao outingDao = new OutingDao();

        public MemberViewModel()
        {
        }

        public MemberViewModel(int id)
        {
            _member = memberDao.GetById(id);
            _categories = memberDao.GetCategoriesByMemberId(id);
            _bikes = memberDao.getBikesByMemberId(id);
            _outing = outingDao.List();
        }


        public Member Member { 
            get { return _member; }
            set { _member = value; } 
        }

        public Vehicle? Vehicle { get => _vehicle; set => _vehicle = value; }
        public List<Category> Categories { get => _categories; set => _categories = value; }
        public IList<Bike> Bikes { get => _bikes; set => _bikes = value; }
        public IList<Outing> Outing { get => _outing; set => _outing = value; }

    }
}
