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
    /// Interaction logic for PgTeachingMenu01.xaml
    /// </summary>
    public partial class PgTeachingMenu01 : Page
    {
        public PgTeachingMenu01()
        {
            InitializeComponent();
            this.btTeaching1.Click += BtTeaching1_Click;
            this.btTeaching2.Click += BtTeaching2_Click;
            this.btTeaching3.Click += BtTeaching3_Click;
            this.btTeaching4.Click += BtTeaching4_Click;

            this.btLoadAx1Pos0.Click += BtLoadAx1Pos0_Click;
            this.btLoadAx1Pos1.Click += BtLoadAx1Pos1_Click;
            this.btLoadAx1Pos2.Click += BtLoadAx1Pos2_Click;
            this.btLoadAx1Pos3.Click += BtLoadAx1Pos3_Click;
            this.btLoadAx1Pos4.Click += BtLoadAx1Pos4_Click;
            this.btLoadAx1Pos5.Click += BtLoadAx1Pos5_Click;

            this.btLoadAx2Pos0.Click += BtLoadAx2Pos0_Click;
            this.btLoadAx2Pos1.Click += BtLoadAx2Pos1_Click;
            this.btLoadAx2Pos2.Click += BtLoadAx2Pos2_Click;
            this.btLoadAx2Pos3.Click += BtLoadAx2Pos3_Click;
            this.btLoadAx2Pos4.Click += BtLoadAx2Pos4_Click;
            this.btLoadAx2Pos5.Click += BtLoadAx2Pos5_Click;
            
        }

        

        private void BtLoadAx2Pos10_Click(object sender, RoutedEventArgs e)
        {

            WndComfirm comfirmYesNo = new WndComfirm();
            if (!comfirmYesNo.DoComfirmYesNo($"Confrim Save Data Pos 10")) return;
            UiManager.Instance.PLC.device.WriteWord(DeviceCode.ZR, 25198, 10);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 24699, true);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 24699, false);

        }
        private void BtLoadAx2Pos9_Click(object sender, RoutedEventArgs e)
        {

            WndComfirm comfirmYesNo = new WndComfirm();
            if (!comfirmYesNo.DoComfirmYesNo($"Confrim Save Data Pos 09")) return;
            UiManager.Instance.PLC.device.WriteWord(DeviceCode.ZR, 25198, 9);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 24699, true);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 24699, false);

        }
        private void BtLoadAx2Pos8_Click(object sender, RoutedEventArgs e)
        {

            WndComfirm comfirmYesNo = new WndComfirm();
            if (!comfirmYesNo.DoComfirmYesNo($"Confrim Save Data Pos 08")) return;
            UiManager.Instance.PLC.device.WriteWord(DeviceCode.ZR, 25198, 8);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 24699, true);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 24699, false);

        }
        private void BtLoadAx2Pos7_Click(object sender, RoutedEventArgs e)
        {

            WndComfirm comfirmYesNo = new WndComfirm();
            if (!comfirmYesNo.DoComfirmYesNo($"Confrim Save Data Pos 07")) return;
            UiManager.Instance.PLC.device.WriteWord(DeviceCode.ZR, 25198, 7);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 24699, true);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 24699, false);

        }
        private void BtLoadAx2Pos6_Click(object sender, RoutedEventArgs e)
        {

            WndComfirm comfirmYesNo = new WndComfirm();
            if (!comfirmYesNo.DoComfirmYesNo($"Confrim Save Data Pos 06")) return;
            UiManager.Instance.PLC.device.WriteWord(DeviceCode.ZR, 25198, 6);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 24699, true);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 24699, false);

        }
        private void BtLoadAx2Pos5_Click(object sender, RoutedEventArgs e)
        {

            WndComfirm comfirmYesNo = new WndComfirm();
            if (!comfirmYesNo.DoComfirmYesNo($"Confrim Save Data Pos 05")) return;
            UiManager.Instance.PLC.device.WriteWord(DeviceCode.ZR, 25198, 5);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 24699, true);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 24699, false);

        }
        private void BtLoadAx2Pos4_Click(object sender, RoutedEventArgs e)
        {

            WndComfirm comfirmYesNo = new WndComfirm();
            if (!comfirmYesNo.DoComfirmYesNo($"Confrim Save Data Pos 04")) return;
            UiManager.Instance.PLC.device.WriteWord(DeviceCode.ZR, 25198, 4);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 24699, true);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 24699, false);

        }
        private void BtLoadAx2Pos3_Click(object sender, RoutedEventArgs e)
        {

            WndComfirm comfirmYesNo = new WndComfirm();
            if (!comfirmYesNo.DoComfirmYesNo($"Confrim Save Data Pos 03")) return;
            UiManager.Instance.PLC.device.WriteWord(DeviceCode.ZR, 25198, 3);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 24699, true);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 24699, false);

        }
        private void BtLoadAx2Pos2_Click(object sender, RoutedEventArgs e)
        {

            WndComfirm comfirmYesNo = new WndComfirm();
            if (!comfirmYesNo.DoComfirmYesNo($"Confrim Save Data Pos 02")) return;
            UiManager.Instance.PLC.device.WriteWord(DeviceCode.ZR, 25198, 2);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 24699, true);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 24699, false);

        }
        private void BtLoadAx2Pos1_Click(object sender, RoutedEventArgs e)
        {

            WndComfirm comfirmYesNo = new WndComfirm();
            if (!comfirmYesNo.DoComfirmYesNo($"Confrim Save Data Pos 01")) return;
            UiManager.Instance.PLC.device.WriteWord(DeviceCode.ZR, 25198, 1);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 24699, true);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 24699, false);

        }
        private void BtLoadAx2Pos0_Click(object sender, RoutedEventArgs e)
        {

            WndComfirm comfirmYesNo = new WndComfirm();
            if (!comfirmYesNo.DoComfirmYesNo($"Confrim Save Data Pos 00")) return;
            UiManager.Instance.PLC.device.WriteWord(DeviceCode.ZR, 25198, 0);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 24699, true);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 24699, false);

        }


        private void BtLoadAx1Pos10_Click(object sender, RoutedEventArgs e)
        {

            WndComfirm comfirmYesNo = new WndComfirm();
            if (!comfirmYesNo.DoComfirmYesNo($"Confrim Save Data Pos 10")) return;
            UiManager.Instance.PLC.device.WriteWord(DeviceCode.ZR, 24998, 10);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 24599, true);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 24599, false);

        }
        private void BtLoadAx1Pos9_Click(object sender, RoutedEventArgs e)
        {

            WndComfirm comfirmYesNo = new WndComfirm();
            if (!comfirmYesNo.DoComfirmYesNo($"Confrim Save Data Pos 09")) return;
            UiManager.Instance.PLC.device.WriteWord(DeviceCode.ZR, 24998, 9);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 24599, true);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 24599, false);

        }
        private void BtLoadAx1Pos8_Click(object sender, RoutedEventArgs e)
        {

            WndComfirm comfirmYesNo = new WndComfirm();
            if (!comfirmYesNo.DoComfirmYesNo($"Confrim Save Data Pos 08")) return;
            UiManager.Instance.PLC.device.WriteWord(DeviceCode.ZR, 24998, 8);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 24599, true);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 24599, false);

        }
        private void BtLoadAx1Pos7_Click(object sender, RoutedEventArgs e)
        {

            WndComfirm comfirmYesNo = new WndComfirm();
            if (!comfirmYesNo.DoComfirmYesNo($"Confrim Save Data Pos 07")) return;
            UiManager.Instance.PLC.device.WriteWord(DeviceCode.ZR, 24998, 7);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 24599, true);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 24599, false);

        }
        private void BtLoadAx1Pos6_Click(object sender, RoutedEventArgs e)
        {

            WndComfirm comfirmYesNo = new WndComfirm();
            if (!comfirmYesNo.DoComfirmYesNo($"Confrim Save Data Pos 06")) return;
            UiManager.Instance.PLC.device.WriteWord(DeviceCode.ZR, 24998, 6);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 24599, true);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 24599, false);

        }
        private void BtLoadAx1Pos5_Click(object sender, RoutedEventArgs e)
        {

            WndComfirm comfirmYesNo = new WndComfirm();
            if (!comfirmYesNo.DoComfirmYesNo($"Confrim Save Data Pos 05")) return;
            UiManager.Instance.PLC.device.WriteWord(DeviceCode.ZR, 24998, 5);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 24599, true);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 24599, false);

        }
        private void BtLoadAx1Pos4_Click(object sender, RoutedEventArgs e)
        {

            WndComfirm comfirmYesNo = new WndComfirm();
            if (!comfirmYesNo.DoComfirmYesNo($"Confrim Save Data Pos 04")) return;
            UiManager.Instance.PLC.device.WriteWord(DeviceCode.ZR, 24998, 4);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 24599, true);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 24599, false);

        }
        private void BtLoadAx1Pos3_Click(object sender, RoutedEventArgs e)
        {

            WndComfirm comfirmYesNo = new WndComfirm();
            if (!comfirmYesNo.DoComfirmYesNo($"Confrim Save Data Pos 03")) return;
            UiManager.Instance.PLC.device.WriteWord(DeviceCode.ZR, 24998, 3);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 24599, true);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 24599, false);

        }
        private void BtLoadAx1Pos2_Click(object sender, RoutedEventArgs e)
        {

            WndComfirm comfirmYesNo = new WndComfirm();
            if (!comfirmYesNo.DoComfirmYesNo($"Confrim Save Data Pos 02")) return;
            UiManager.Instance.PLC.device.WriteWord(DeviceCode.ZR, 24998, 2);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 24599, true);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 24599, false);

        }
        private void BtLoadAx1Pos1_Click(object sender, RoutedEventArgs e)
        {

            WndComfirm comfirmYesNo = new WndComfirm();
            if (!comfirmYesNo.DoComfirmYesNo($"Confrim Save Data Pos 01")) return;
            UiManager.Instance.PLC.device.WriteWord(DeviceCode.ZR, 24998, 1);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 24599, true);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 24599, false);

        }
        private void BtLoadAx1Pos0_Click(object sender, RoutedEventArgs e)
        {
            
            WndComfirm comfirmYesNo = new WndComfirm();
            if (!comfirmYesNo.DoComfirmYesNo($"Confrim Save Data Pos 00")) return;
            UiManager.Instance.PLC.device.WriteWord(DeviceCode.ZR, 24998, 0);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 24599, true);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 24599, false);

        }

        
        private void BtTeaching4_Click(object sender, RoutedEventArgs e)
        {
            UiManager.Instance.SwitchPage(PAGE_ID.PAGE_TEACHING_MENU_03);
        }

        private void BtTeaching3_Click(object sender, RoutedEventArgs e)
        {
            UiManager.Instance.SwitchPage(PAGE_ID.PAGE_TEACHING_MENU_02);
        }

        private void BtTeaching2_Click(object sender, RoutedEventArgs e)
        {
            UiManager.Instance.SwitchPage(PAGE_ID.PAGE_TEACHING_MENU_01);
        }

        private void BtTeaching1_Click(object sender, RoutedEventArgs e)
        {
            UiManager.Instance.SwitchPage(PAGE_ID.PAGE_MANUAL_OPERATION_01);
        }
    }
}
