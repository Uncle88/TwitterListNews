﻿using System;
using System.Windows.Input;
using MvvmCross.Core.ViewModels;
using TwitterList.Authentication;

namespace TwitterList.ViewModels
{
    public class AuthViewModel : MvxViewModel
    {
        private IAuthenticationService _authServ;

        public AuthViewModel(IAuthenticationService authServ)
        {
            _authServ = authServ;

        }

        private MvxCommand _authCommand;

        public ICommand AuthCommand
        {
            get
            {
                _authCommand = _authCommand ?? new MvxCommand(() => _authServ.LoginToTwitter());
                return _authCommand;
            }
        }
    }
}

