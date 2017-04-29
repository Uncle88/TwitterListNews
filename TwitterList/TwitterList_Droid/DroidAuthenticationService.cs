﻿using System;
using TwitterList.Authentication;
using TwitterList;
using Xamarin.Auth;

namespace TwitterList_Droid
{
    public class DroidAuthenticationService : Constans, IAuthenticationService
    {
        public void LoginToTwitter()
        {
            var auth = new OAuth1Authenticator(
                                               TWITTER_KEY,
                                               TWITTER_SECRET,
                                               new Uri(TWITTER_REQTOKEN_URL),
                                               new Uri(TWITTER_AUTH),
                                               new Uri(TWITTER_ACCESSTOKEN_URL),
                                               new Uri(TWITTER_CALLBACK_URL));

            auth.AllowCancel = true;
            auth.Completed += (s, eventArgs) =>
            {
                if (eventArgs.IsAuthenticated)
                {
                    Account loggedInAccount = eventArgs.Account;
                    //save the account data for a later session, according to Twitter docs, this doesn't expire
                    AccountStore.Create().Save(loggedInAccount, "Twitter");
                }
            };
            //MainActivity mAct = new MainActivity();
            //StartActivity(auth.GetUI(mAct));
        }
    }
}