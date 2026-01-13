using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Development
{
    /// <summary>
    /// Interaction logic for PgSuperUserMenu03.xaml
    /// </summary>
    public partial class PgSuperUserMenu03 : Page
    {
        public PgSuperUserMenu03()
        {
            InitializeComponent();

            this.btSetting01.Click += BtSetting01_Click;
            this.btSetting02.Click += BtSetting02_Click;
            this.btSetting03.Click += BtSetting03_Click;
            this.btSetting04.Click += BtSetting04_Click;

        }


        private void BtSetting04_Click(object sender, RoutedEventArgs e)
        {
            UiManager.Instance.SwitchPage(PAGE_ID.PAGE_SUPER_USER_MENU_04);
        }
        private void BtSetting03_Click(object sender, RoutedEventArgs e)
        {
            UiManager.Instance.SwitchPage(PAGE_ID.PAGE_SUPER_USER_MENU_03);
        }
        private void BtSetting02_Click(object sender, RoutedEventArgs e)
        {
            UiManager.Instance.SwitchPage(PAGE_ID.PAGE_SUPER_USER_MENU_02);
        }
        private void BtSetting01_Click(object sender, RoutedEventArgs e)
        {
            UiManager.Instance.SwitchPage(PAGE_ID.PAGE_SUPER_USER_MENU_01);
        }
    }
}
