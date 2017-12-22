﻿using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace FoodStock01.Droid
{
    [Activity(Label = "FoodStock01", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);


            //指定したファイルのパスを取得する。
            var dbPath = GetLocalFilePath("sqlitetest.db3");



            //この段階ではまだエラーになる。
            LoadApplication(new App(dbPath));
        }

        public static string GetLocalFilePath(string filename)
        {
            //指定されたファイルのパスを取得する。なければ作成してそのパスを返却する。
            var path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);



            return System.IO.Path.Combine(path, filename);
        }
    }
}

