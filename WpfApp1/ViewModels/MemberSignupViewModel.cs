﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.POCO;

namespace WpfApp1.ViewModels
{
    class MemberSignupViewModel
    {
        private Member _member;
        private Vehicle? car;
        private IList<Category> _categories;
        private IList<Bike> _bikes;

        public MemberSignupViewModel()
        {
            _member = new Member();
            _member.Email = "car";
        }


        public Member Member { 
            get { return _member; }
            set { _member = value; } 
        }

        public Vehicle? Car { get => car; set => car = value; }
        public IList<Category> Categories { get => _categories; set => _categories = value; }
        public IList<Bike> Bikes { get => _bikes; set => _bikes = value; }
    }
}
