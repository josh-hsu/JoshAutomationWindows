using GL = JoshGameLibrary20;
using System;
using System.Windows.Forms;

namespace JoshAutomationWindows
{
    public partial class MainForm : Form
    {
        public GL.JoshGameLibrary20 mGL20;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            mGL20 = new GL.JoshGameLibrary20();
            mGL20.ChooseDevice(GL.JoshGameLibrary20.DEVICE_TYPE_BLUE_STACK);
            mGL20.InitDevice(null);

            Console.WriteLine("  Name:                " + mGL20.GetDeviceName());
            Console.WriteLine("  Type:                " + mGL20.GetType());
            Console.WriteLine("  Version:             " + mGL20.GetVersion());
            Console.WriteLine("  System Type:         " + mGL20.GetDeviceSystemType());
            Console.WriteLine("  Resolution:          " + mGL20.GetDeviceResolution()[0] + " x " + mGL20.GetDeviceResolution()[1]);
            Console.WriteLine("  Orientation:         " + mGL20.GetDeviceMainOrientation());
            Console.WriteLine("  Slot count:          " + mGL20.GetScreenshotSlotCount());
            Console.WriteLine("  Current Slot Index:  " + mGL20.GetCurrentSlot());
        }
    }
}
