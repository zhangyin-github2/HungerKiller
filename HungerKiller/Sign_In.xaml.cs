﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using HungerKiller.Model;

// “内容对话框”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上进行了说明

namespace HungerKiller
{
    public sealed partial class Sign_In : ContentDialog
    {
        public Sign_In()
        {
            this.InitializeComponent();
        }

        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {

            if ((passwordBox.Password == "123456") && (username.Text == "admin"))
            {
                args.Cancel = true;
                statusText6.Text = "用户名或密码错误";

            }
            if ((passwordBox.Password.Length==0) || (username.Text.Length == 0))
            {
                args.Cancel = true;
                statusText6.Text = "东西都不写全还想登录？？？";

            }
            else
            {
                tiao1.jm1 = true;
            }

        }

        private void ContentDialog_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            
            tiao.jm = true;
        }

        

       /* private void Button_Click(object sender, RoutedEventArgs e)
        {
            Sign_In a = new Sign_In();
            a.Hide();

        }*/
    }
}