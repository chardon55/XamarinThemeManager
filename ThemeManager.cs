using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Chardon.XamarinThemeManager
{
    /// <summary>
    /// General theme manager class
    /// </summary>
    public abstract partial class ThemeManager
    {
        protected ThemeManager(ResourceDictionary lightTheme, ResourceDictionary darkTheme)
        {
            LightTheme = lightTheme;
            DarkTheme = darkTheme;
        }

        public ResourceDictionary DarkTheme { get; private set; }

        public ResourceDictionary LightTheme { get; private set; }

        private bool isDarkMode = false;
        public bool IsDarkMode
        {
            get => isDarkMode;
            set
            {
                SetDarkMode(value);
            }
        }

        public void SetDarkMode(bool darkMode)
        {
            if (this.isDarkMode == darkMode)
            {
                return;
            }

            if (darkMode)
            {
                ToDark();
            }
            else
            {
                ToLight();
            }
        }

        public void ToDark()
        {
            isDarkMode = true;
        }

        public void ToLight()
        {
            isDarkMode = false;
        }

        private readonly ICollection<ResourceDictionary> mergedDicts = Application.Current.Resources.MergedDictionaries;

        protected virtual void ResetTheme(ResourceDictionary resourceDictionary)
        {
            if (resourceDictionary is null)
            {
                return;
            }
            mergedDicts?.Clear();
            mergedDicts?.Add(resourceDictionary);
        }

        public void Toggle() => IsDarkMode = !IsDarkMode;

        public static AppTheme SystemTheme => AppInfo.RequestedTheme;

        public AppTheme CurrentAppTheme
        {
            get => IsDarkMode ? AppTheme.Dark : AppTheme.Light;
            set
            {
                if (value == AppTheme.Unspecified)
                {
                    return;
                }

                IsDarkMode = (value == AppTheme.Dark);
            }
        }

        public void FitSystem() => CurrentAppTheme = SystemTheme;
    }
}
