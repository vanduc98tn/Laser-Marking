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
    /// Interaction logic for PgMechanicalMenu03.xaml
    /// </summary>
    public partial class PgMechanicalMenu03 : Page
    {
        public PgMechanicalMenu03()
        {
            InitializeComponent();
            this.Loaded += PgMechanicalMenu03_Loaded;
            this.btSave.Click += BtSave_Click;

            this.btMenuTab01.Click += BtMenuTab01_Click;
            this.btMenuTab02.Click += BtMenuTab02_Click;
            this.btMenuTab03.Click += BtMenuTab03_Click;
            this.btMenuTab04.Click += BtMenuTab04_Click;
        }

        private void BtMenuTab04_Click(object sender, RoutedEventArgs e)
        {
            UiManager.Instance.SwitchPage(PAGE_ID.PAGE_MECHANICAL_MENU_04);
        }
        private void BtMenuTab03_Click(object sender, RoutedEventArgs e)
        {
            UiManager.Instance.SwitchPage(PAGE_ID.PAGE_MECHANICAL_MENU_03);

        }
        private void BtMenuTab02_Click(object sender, RoutedEventArgs e)
        {
            UiManager.Instance.SwitchPage(PAGE_ID.PAGE_MECHANICAL_MENU_02);

        }
        private void BtMenuTab01_Click(object sender, RoutedEventArgs e)
        {
            UiManager.Instance.SwitchPage(PAGE_ID.PAGE_MECHANICAL_MENU_01);

        }
        private void BtSave_Click(object sender, RoutedEventArgs e)
        {
            this.SaveSetting();
        }

        private void PgMechanicalMenu03_Loaded(object sender, RoutedEventArgs e)
        {
            this.UpdateUI();
        }
        private void UpdateUI()
        {
            this.tbIpTCPVision.Text = UiManager.appSetting.settingDevice.settingTCPTranferVision.Ip.ToString();
            this.tbPortTCPVision.Text = UiManager.appSetting.settingDevice.settingTCPTranferVision.Port.ToString();
        }
        private void SaveSetting()
        {
            UiManager.appSetting.settingDevice.settingTCPTranferVision.Ip = this.tbIpTCPVision.Text;
            UiManager.appSetting.settingDevice.settingTCPTranferVision.Port = Convert.ToInt32(this.tbPortTCPVision.Text);
            UiManager.SaveAppSetting();

            UpdateLogs($"Setting IP : {UiManager.appSetting.settingDevice.settingTCPTranferVision.Ip}");
            UpdateLogs($"Setting PORT : {UiManager.appSetting.settingDevice.settingTCPTranferVision.Port}");
            UpdateLogs("Save Complete !");
        }
        private void UpdateLogs(string notify)
        {
            this.Dispatcher.Invoke(() => {
                this.txtLogs.Text += "\r\n" + notify;
                this.txtLogs.ScrollToEnd();
            });
        }
    }
}
