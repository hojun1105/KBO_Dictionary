﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using KBO_Dictionary.BusinessLogicLayer;
using KBO_Dictionary.PresentationLayer;

namespace KBO_Dictionary
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            var apiDataSaverService = new ApiDataSaverService();
            apiDataSaverService.Invoke();

            var view = new ListView { DataContext = new ListViewModel() };
            view.Show();
        }
    }
}
