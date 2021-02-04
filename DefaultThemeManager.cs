using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Chardon.XamarinThemeManager
{
    /// <summary>
    /// Default theme manager
    /// </summary>
    public class DefaultThemeManager : ThemeManager
    {
        public DefaultThemeManager(ResourceDictionary lightTheme, ResourceDictionary darkTheme) : base(lightTheme, darkTheme)
        {
        }
    }
}
