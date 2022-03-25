using System;
using System.Threading;
using System.Windows.Forms;

namespace 人事资源管理系统
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form0_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();//结束整个程序
        }

        private static void StartMainStaff()
        {
            Staff staff = new Staff();
            Application.Run(staff);
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           Thread th = new Thread(new ThreadStart(StartMainStaff));
            th.Start();
            this.Close();
        }

        private static void StartMainForm1()
        {
            Admin_login admin_Login = new Admin_login();
            Application.Run(admin_Login);
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Thread th = new Thread(new ThreadStart(StartMainForm1));
            th.Start();
            this.Hide();
        }
    }
}
