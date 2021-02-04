using System;
using System.Collections.Generic;
using System.Text;

namespace Chardon.XamarinThemeManager
{
    /// <summary>
    /// Theme manager interface
    /// 
    /// <param>TTK - Type of designated theme key</param>
    /// </summary>
    public interface IThemeManager<TTK>
    {
        /// <summary>
        /// Set theme by provided key
        /// </summary>
        /// <param name="themeKey">Theme key</param>
        void SetTheme(TTK themeKey);

        /// <summary>
        /// Reset theme to default one
        /// 
        /// <para>If to default theme specified, set to the first theme in order</para>
        /// </summary>
        void ToDefault();
    }
}
