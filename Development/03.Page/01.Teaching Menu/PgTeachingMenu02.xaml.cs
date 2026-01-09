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
    /// Interaction logic for PgTeachingMenu02.xaml
    /// </summary>
    public partial class PgTeachingMenu02 : Page
    {
        public PgTeachingMenu02()
        {
            InitializeComponent();

            this.btTeaching0.Click += BtTeaching0_Click;
            this.btTeaching1.Click += BtTeaching1_Click;
            this.btTeaching2.Click += BtTeaching2_Click;
            this.btTeaching3.Click += BtTeaching3_Click;
            this.btTeaching4.Click += BtTeaching4_Click;

            this.btLoadTab1Pos0.Click += btLoadTab1Pos0_Click;
            this.btLoadTab1Pos1.Click += btLoadTab1Pos1_Click;
            this.btLoadTab1Pos2.Click += btLoadTab1Pos2_Click;
            this.btLoadTab1Pos3.Click += btLoadTab1Pos3_Click;
            this.btLoadTab1Pos4.Click += btLoadTab1Pos4_Click;
            this.btLoadTab1Pos5.Click += btLoadTab1Pos5_Click;
            this.btLoadTab1Pos6.Click += btLoadTab1Pos6_Click;
            //this.btLoadTab1Pos7.Click += btLoadTab1Pos7_Click;
            //this.btLoadTab1Pos8.Click += btLoadTab1Pos8_Click;
            //this.btLoadTab1Pos9.Click += btLoadTab1Pos9_Click;

            this.btLoadTab2Pos0.Click += btLoadTab2Pos0_Click;
            this.btLoadTab2Pos1.Click += btLoadTab2Pos1_Click;
            this.btLoadTab2Pos2.Click += btLoadTab2Pos2_Click;
            this.btLoadTab2Pos3.Click += btLoadTab2Pos3_Click;
            this.btLoadTab2Pos4.Click += btLoadTab2Pos4_Click;
            this.btLoadTab2Pos5.Click += btLoadTab2Pos5_Click;
            this.btLoadTab2Pos6.Click += btLoadTab2Pos6_Click;
            this.btLoadTab2Pos7.Click += btLoadTab2Pos7_Click;
            //this.btLoadTab2Pos8.Click += btLoadTab2Pos8_Click;
            //this.btLoadTab2Pos9.Click += btLoadTab2Pos9_Click;

            //this.btLoadTab3Pos0.Click += btLoadTab3Pos0_Click;
            //this.btLoadTab3Pos1.Click += btLoadTab3Pos1_Click;
            //this.btLoadTab3Pos2.Click += btLoadTab3Pos2_Click;
            //this.btLoadTab3Pos3.Click += btLoadTab3Pos3_Click;
            //this.btLoadTab3Pos4.Click += btLoadTab3Pos4_Click;
            //this.btLoadTab3Pos5.Click += btLoadTab3Pos5_Click;
            //this.btLoadTab3Pos6.Click += btLoadTab3Pos6_Click;
            //this.btLoadTab3Pos7.Click += btLoadTab3Pos7_Click;
            //this.btLoadTab3Pos8.Click += btLoadTab3Pos8_Click;
            //this.btLoadTab3Pos9.Click += btLoadTab3Pos9_Click;
        }


        private void btLoadTab3Pos9_Click(object sender, RoutedEventArgs e)
        {

            WndComfirm comfirmYesNo = new WndComfirm();
            if (!comfirmYesNo.DoComfirmYesNo($"Confrim Load Current to POS")) return;
            UiManager.Instance.PLC.device.WriteWord(DeviceCode.R, 5272, 9);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15776, true);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15776, false);

        }
        private void btLoadTab3Pos8_Click(object sender, RoutedEventArgs e)
        {

            WndComfirm comfirmYesNo = new WndComfirm();
            if (!comfirmYesNo.DoComfirmYesNo($"Confrim Load Current to POS")) return;
            UiManager.Instance.PLC.device.WriteWord(DeviceCode.R, 5272, 8);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15776, true);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15776, false);

        }
        private void btLoadTab3Pos7_Click(object sender, RoutedEventArgs e)
        {

            WndComfirm comfirmYesNo = new WndComfirm();
            if (!comfirmYesNo.DoComfirmYesNo($"Confrim Load Current to POS")) return;
            UiManager.Instance.PLC.device.WriteWord(DeviceCode.R, 5272, 7);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15776, true);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15776, false);

        }
        private void btLoadTab3Pos6_Click(object sender, RoutedEventArgs e)
        {

            WndComfirm comfirmYesNo = new WndComfirm();
            if (!comfirmYesNo.DoComfirmYesNo($"Confrim Load Current to POS")) return;
            UiManager.Instance.PLC.device.WriteWord(DeviceCode.R, 5272, 6);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15776, true);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15776, false);

        }
        private void btLoadTab3Pos5_Click(object sender, RoutedEventArgs e)
        {

            WndComfirm comfirmYesNo = new WndComfirm();
            if (!comfirmYesNo.DoComfirmYesNo($"Confrim Load Current to POS")) return;
            UiManager.Instance.PLC.device.WriteWord(DeviceCode.R, 5272, 5);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15776, true);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15776, false);

        }
        private void btLoadTab3Pos4_Click(object sender, RoutedEventArgs e)
        {

            WndComfirm comfirmYesNo = new WndComfirm();
            if (!comfirmYesNo.DoComfirmYesNo($"Confrim Load Current to POS")) return;
            UiManager.Instance.PLC.device.WriteWord(DeviceCode.R, 5272, 4);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15776, true);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15776, false);

        }
        private void btLoadTab3Pos3_Click(object sender, RoutedEventArgs e)
        {

            WndComfirm comfirmYesNo = new WndComfirm();
            if (!comfirmYesNo.DoComfirmYesNo($"Confrim Load Current to POS")) return;
            UiManager.Instance.PLC.device.WriteWord(DeviceCode.R, 5272, 3);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15776, true);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15776, false);

        }
        private void btLoadTab3Pos2_Click(object sender, RoutedEventArgs e)
        {

            WndComfirm comfirmYesNo = new WndComfirm();
            if (!comfirmYesNo.DoComfirmYesNo($"Confrim Load Current to POS")) return;
            UiManager.Instance.PLC.device.WriteWord(DeviceCode.R, 5272, 2);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15776, true);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15776, false);

        }
        private void btLoadTab3Pos1_Click(object sender, RoutedEventArgs e)
        {

            WndComfirm comfirmYesNo = new WndComfirm();
            if (!comfirmYesNo.DoComfirmYesNo($"Confrim Load Current to POS")) return;
            UiManager.Instance.PLC.device.WriteWord(DeviceCode.R, 5272, 1);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15776, true);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15776, false);

        }
        private void btLoadTab3Pos0_Click(object sender, RoutedEventArgs e)
        {

            WndComfirm comfirmYesNo = new WndComfirm();
            if (!comfirmYesNo.DoComfirmYesNo($"Confrim Load Current to POS")) return;
            UiManager.Instance.PLC.device.WriteWord(DeviceCode.R, 5272, 0);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15776, true);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15776, false);

        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////


        private void btLoadTab2Pos9_Click(object sender, RoutedEventArgs e)
        {

            WndComfirm comfirmYesNo = new WndComfirm();
            if (!comfirmYesNo.DoComfirmYesNo($"Confrim Load Current to POS")) return;
            UiManager.Instance.PLC.device.WriteWord(DeviceCode.R, 5222, 9);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15726, true);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15726, false);

        }
        private void btLoadTab2Pos8_Click(object sender, RoutedEventArgs e)
        {

            WndComfirm comfirmYesNo = new WndComfirm();
            if (!comfirmYesNo.DoComfirmYesNo($"Confrim Load Current to POS")) return;
            UiManager.Instance.PLC.device.WriteWord(DeviceCode.R, 5222, 8);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15726, true);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15726, false);

        }
        private void btLoadTab2Pos7_Click(object sender, RoutedEventArgs e)
        {

            WndComfirm comfirmYesNo = new WndComfirm();
            if (!comfirmYesNo.DoComfirmYesNo($"Confrim Load Current to POS")) return;
            UiManager.Instance.PLC.device.WriteWord(DeviceCode.R, 5222, 7);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15726, true);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15726, false);

        }
        private void btLoadTab2Pos6_Click(object sender, RoutedEventArgs e)
        {

            WndComfirm comfirmYesNo = new WndComfirm();
            if (!comfirmYesNo.DoComfirmYesNo($"Confrim Load Current to POS")) return;
            UiManager.Instance.PLC.device.WriteWord(DeviceCode.R, 5222, 6);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15726, true);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15726, false);

        }
        private void btLoadTab2Pos5_Click(object sender, RoutedEventArgs e)
        {

            WndComfirm comfirmYesNo = new WndComfirm();
            if (!comfirmYesNo.DoComfirmYesNo($"Confrim Load Current to POS")) return;
            UiManager.Instance.PLC.device.WriteWord(DeviceCode.R, 5222, 5);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15726, true);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15726, false);

        }
        private void btLoadTab2Pos4_Click(object sender, RoutedEventArgs e)
        {

            WndComfirm comfirmYesNo = new WndComfirm();
            if (!comfirmYesNo.DoComfirmYesNo($"Confrim Load Current to POS")) return;
            UiManager.Instance.PLC.device.WriteWord(DeviceCode.R, 5222, 4);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15726, true);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15726, false);

        }
        private void btLoadTab2Pos3_Click(object sender, RoutedEventArgs e)
        {

            WndComfirm comfirmYesNo = new WndComfirm();
            if (!comfirmYesNo.DoComfirmYesNo($"Confrim Load Current to POS")) return;
            UiManager.Instance.PLC.device.WriteWord(DeviceCode.R, 5222, 3);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15726, true);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15726, false);

        }
        private void btLoadTab2Pos2_Click(object sender, RoutedEventArgs e)
        {

            WndComfirm comfirmYesNo = new WndComfirm();
            if (!comfirmYesNo.DoComfirmYesNo($"Confrim Load Current to POS")) return;
            UiManager.Instance.PLC.device.WriteWord(DeviceCode.R, 5222, 2);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15726, true);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15726, false);

        }
        private void btLoadTab2Pos1_Click(object sender, RoutedEventArgs e)
        {

            WndComfirm comfirmYesNo = new WndComfirm();
            if (!comfirmYesNo.DoComfirmYesNo($"Confrim Load Current to POS")) return;
            UiManager.Instance.PLC.device.WriteWord(DeviceCode.R, 5222, 1);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15726, true);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15726, false);

        }
        private void btLoadTab2Pos0_Click(object sender, RoutedEventArgs e)
        {

            WndComfirm comfirmYesNo = new WndComfirm();
            if (!comfirmYesNo.DoComfirmYesNo($"Confrim Load Current to POS")) return;
            UiManager.Instance.PLC.device.WriteWord(DeviceCode.R, 5222, 0);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15726, true);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15726, false);

        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btLoadTab1Pos9_Click(object sender, RoutedEventArgs e)
        {

            WndComfirm comfirmYesNo = new WndComfirm();
            if (!comfirmYesNo.DoComfirmYesNo($"Confrim Load Current to POS")) return;
            UiManager.Instance.PLC.device.WriteWord(DeviceCode.R, 5212, 9);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15716, true);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15716, false);

        }
        private void btLoadTab1Pos8_Click(object sender, RoutedEventArgs e)
        {

            WndComfirm comfirmYesNo = new WndComfirm();
            if (!comfirmYesNo.DoComfirmYesNo($"Confrim Load Current to POS")) return;
            UiManager.Instance.PLC.device.WriteWord(DeviceCode.R, 5212, 8);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15716, true);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15716, false);

        }
        private void btLoadTab1Pos7_Click(object sender, RoutedEventArgs e)
        {

            WndComfirm comfirmYesNo = new WndComfirm();
            if (!comfirmYesNo.DoComfirmYesNo($"Confrim Load Current to POS")) return;
            UiManager.Instance.PLC.device.WriteWord(DeviceCode.R, 5212, 7);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15716, true);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15716, false);

        }
        private void btLoadTab1Pos6_Click(object sender, RoutedEventArgs e)
        {

            WndComfirm comfirmYesNo = new WndComfirm();
            if (!comfirmYesNo.DoComfirmYesNo($"Confrim Load Current to POS")) return;
            UiManager.Instance.PLC.device.WriteWord(DeviceCode.R, 5212, 6);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15716, true);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15716, false);

        }
        private void btLoadTab1Pos5_Click(object sender, RoutedEventArgs e)
        {

            WndComfirm comfirmYesNo = new WndComfirm();
            if (!comfirmYesNo.DoComfirmYesNo($"Confrim Load Current to POS")) return;
            UiManager.Instance.PLC.device.WriteWord(DeviceCode.R, 5212, 5);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15716, true);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15716, false);

        }
        private void btLoadTab1Pos4_Click(object sender, RoutedEventArgs e)
        {

            WndComfirm comfirmYesNo = new WndComfirm();
            if (!comfirmYesNo.DoComfirmYesNo($"Confrim Load Current to POS")) return;
            UiManager.Instance.PLC.device.WriteWord(DeviceCode.R, 5212, 4);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15716, true);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15716, false);

        }
        private void btLoadTab1Pos3_Click(object sender, RoutedEventArgs e)
        {

            WndComfirm comfirmYesNo = new WndComfirm();
            if (!comfirmYesNo.DoComfirmYesNo($"Confrim Load Current to POS")) return;
            UiManager.Instance.PLC.device.WriteWord(DeviceCode.R, 5212, 3);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15716, true);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15716, false);

        }
        private void btLoadTab1Pos2_Click(object sender, RoutedEventArgs e)
        {

            WndComfirm comfirmYesNo = new WndComfirm();
            if (!comfirmYesNo.DoComfirmYesNo($"Confrim Load Current to POS")) return;
            UiManager.Instance.PLC.device.WriteWord(DeviceCode.R, 5212, 2);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15716, true);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15716, false);

        }
        private void btLoadTab1Pos1_Click(object sender, RoutedEventArgs e)
        {

            WndComfirm comfirmYesNo = new WndComfirm();
            if (!comfirmYesNo.DoComfirmYesNo($"Confrim Load Current to POS")) return;
            UiManager.Instance.PLC.device.WriteWord(DeviceCode.R, 5212, 1);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15716, true);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15716, false);

        }
        private void btLoadTab1Pos0_Click(object sender, RoutedEventArgs e)
        {

            WndComfirm comfirmYesNo = new WndComfirm();
            if (!comfirmYesNo.DoComfirmYesNo($"Confrim Load Current to POS")) return;
            UiManager.Instance.PLC.device.WriteWord(DeviceCode.R, 5212, 0);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15716, true);
            Thread.Sleep(10);
            UiManager.Instance.PLC.device.WriteBit(DeviceCode.L, 15716, false);

        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////

        private void BtTeaching4_Click(object sender, RoutedEventArgs e)
        {
            UiManager.Instance.SwitchPage(PAGE_ID.PAGE_TEACHING_MENU_04);
        }
        private void BtTeaching3_Click(object sender, RoutedEventArgs e)
        {
            UiManager.Instance.SwitchPage(PAGE_ID.PAGE_TEACHING_MENU_03);
        }
        private void BtTeaching2_Click(object sender, RoutedEventArgs e)
        {
            UiManager.Instance.SwitchPage(PAGE_ID.PAGE_TEACHING_MENU_02);
        }
        private void BtTeaching1_Click(object sender, RoutedEventArgs e)
        {
            UiManager.Instance.SwitchPage(PAGE_ID.PAGE_TEACHING_MENU_01);
        }
        private void BtTeaching0_Click(object sender, RoutedEventArgs e)
        {
            UiManager.Instance.SwitchPage(PAGE_ID.PAGE_MANUAL_OPERATION_01);
        }
    }
}
