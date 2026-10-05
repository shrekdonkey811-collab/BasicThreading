using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace BasicThreading
{
    public partial class frmBasicThread : Form
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        Thread Thread1;
        Thread Thread2;

        public frmBasicThread()
        {
            InitializeComponent();
        }

        private void runbtn_Click(object sender, EventArgs e)
        {
            AllocConsole();

            Console.WriteLine("-Before starting thread-");

            Thread1 = new Thread(MyThreadClass.Thread1) { Name = "Thread A" };
            Thread2 = new Thread(MyThreadClass.Thread1) { Name = "Thread B" };

            Thread1.Start();
            Thread.Sleep(50);
            Thread2.Start();

            Thread1.Join();
            Thread2.Join();

            Console.WriteLine($"The thread 0x{Thread1.ManagedThreadId:x4} has exited with code 0 (0x0).");
            Console.WriteLine($"The thread 0x{Thread2.ManagedThreadId:x4} has exited with code 0 (0x0).");

            Console.WriteLine("-End of Thread-");
            titlecard.Text = "-End of Thread-";
        }

        private void frmBasicThread_Load(object sender, EventArgs e)
        {

        }
    }
}