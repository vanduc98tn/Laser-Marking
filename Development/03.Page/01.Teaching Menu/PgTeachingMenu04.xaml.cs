using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Interaction logic for PgTeachingMenu04.xaml
    /// </summary>
    public partial class PgTeachingMenu04 : Page
    {
        public PgTeachingMenu04()
        {
            InitializeComponent();

            this.btTeaching00.Click += BtTeaching00_Click;
            this.btTeaching01.Click += BtTeaching01_Click;
            this.btTeaching02.Click += BtTeaching02_Click;
            this.btTeaching03.Click += BtTeaching03_Click;
            this.btTeaching04.Click += BtTeaching04_Click;

        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////

        private void BtTeaching04_Click(object sender, RoutedEventArgs e)
        {
            UiManager.Instance.SwitchPage(PAGE_ID.PAGE_TEACHING_MENU_04);
        }
        private void BtTeaching03_Click(object sender, RoutedEventArgs e)
        {
            UiManager.Instance.SwitchPage(PAGE_ID.PAGE_TEACHING_MENU_03);
        }
        private void BtTeaching02_Click(object sender, RoutedEventArgs e)
        {
            UiManager.Instance.SwitchPage(PAGE_ID.PAGE_TEACHING_MENU_02);
        }
        private void BtTeaching01_Click(object sender, RoutedEventArgs e)
        {
            UiManager.Instance.SwitchPage(PAGE_ID.PAGE_TEACHING_MENU_01);
        }
        private void BtTeaching00_Click(object sender, RoutedEventArgs e)
        {
            UiManager.Instance.SwitchPage(PAGE_ID.PAGE_MANUAL_OPERATION_01);
        }
    }
}
