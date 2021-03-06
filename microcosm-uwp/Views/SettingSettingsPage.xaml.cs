﻿using microcosm.Common;
using microcosm.Config;
using System;
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

// 空白ページの項目テンプレートについては、https://go.microsoft.com/fwlink/?LinkId=234238 を参照してください

namespace microcosm.Views
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class SettingSettingsPage : Page
    {
        public SettingData[] settings;
        public SettingSettingsPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            settings = CommonInstance.getInstance().settings;

            base.OnNavigatedTo(e);
            this.SettingDetailFrame.Navigate(typeof(SettingDetailPlanet), (object)settings);

            foreach (SettingData setting in settings)
            {
                SettingCombo.Items.Add(setting.dispName);
            }
            SettingCombo.SelectedIndex = 0;
        }

        private void SettingCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // イベント投げられるのかな
        }

        private void DispPlanetSetting_Click(object sender, RoutedEventArgs e)
        {
            SettingDetailFrame.Navigate(typeof(SettingDetailPlanet), (object)settings);
        }

        private void DispAspectCategorySetting_Click(object sender, RoutedEventArgs e)
        {
            SettingDetailFrame.Navigate(typeof(SettingDetailAspectCategory), (object)settings);
        }

        private void DispAspectPlanetSetting_Click(object sender, RoutedEventArgs e)
        {
            SettingDetailFrame.Navigate(typeof(SettingDetailPlanetAspect), (object)settings);
        }

        private void OrbsSetting_Click(object sender, RoutedEventArgs e)
        {
            SettingDetailFrame.Navigate(typeof(SettingDetailOrbs), (object)settings);
        }
    }
}
