﻿using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvvmCross.Platform.IoC;
using MvvmCross.Platform.Platform;
using TwitterList.Authentication;
using TwitterList.ViewModels;

namespace TwitterList
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();
            RegisterAppStart<ViewModels.AuthViewModel>();
            //Mvx.LazyConstructAndRegisterSingleton(() =>
            //{
            //var provider = Mvx.IocConstruct<IAuthenticationService>();
            //return provider;
            //});

            //Mvx.IocConstruct<IAuthenticationService>();


            //Mvx.RegisterSingleton<IAuthenticationService>(new AuthenticationService());

        }
    }
}
