using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvpLogoin.Bean;

namespace MvpLogoin.Model.Listener
{
    public interface OnLoginListener
    {
        void LoginSuccess(User user);

        void LoginFailed();

        void LoginError();
    }
}