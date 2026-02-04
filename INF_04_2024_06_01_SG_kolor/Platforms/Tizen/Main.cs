using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace INF_04_2024_06_01_SG_kolor
{
    internal class Program : MauiApplication
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

        static void Main(string[] args)
        {
            var app = new Program();
            app.Run(args);
        }
    }
}
