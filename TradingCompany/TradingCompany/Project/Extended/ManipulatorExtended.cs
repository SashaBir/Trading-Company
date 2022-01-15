using System;
using System.Windows.Controls;

namespace TradingCompany.Project.Extended
{
    internal static class ManipulatorExtended
    {
        internal static void SwitchToOtherPage<T>(this object oldPage, T newPage)
            where T : Page
        {
            if (oldPage == null)
                throw new Exception("oldPage is null.");

            if (newPage == null)
                throw new Exception("newPage is null.");

            if ((Frame)oldPage is Frame frame)
            {
                frame.Visibility = System.Windows.Visibility.Visible;
                frame.Content = newPage;
                return;
            }

            if ((Page)oldPage is Page page)
            {
                page.Visibility = System.Windows.Visibility.Visible;
                page.Content = newPage;
                return;
            }
        }
    }
}
