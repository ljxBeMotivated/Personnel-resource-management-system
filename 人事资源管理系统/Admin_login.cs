using System;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace 人事资源管理系统
{
    public partial class Admin_login : Form
    {
        static string str;
        public Admin_login()
        {
            InitializeComponent();
        }
        //登陆事件
        private void button1_Click(object sender, EventArgs e)
        {
            if (login())
            {
                timer1.Start();//启动计时器控件，图片开始移动
                textBox1.Visible = false;
                textBox2.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                str = textBox1.Text;
            }
        }
        private bool login()
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("输入不完整请检查", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                string sql = "select * from dbo.Admin_login('" + textBox1.Text+"','"+textBox2.Text+"')";
                dao da = new dao();
                IDataReader dr = da.read(sql);
                if (dr.Read())
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("用户名或密码错误");
                    return false;
                }
            }
        }
        private static void StartMainForm0()
        {
            Login login = new Login();
            Application.Run(login);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            Thread th = new Thread(new ThreadStart(StartMainForm0));
            th.Start();
            this.Close();
        }

        private static void StartMainForm4()
        {
            Admin admin = new Admin(str);
            Application.Run(admin);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X < 160)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 1, pictureBox1.Location.Y);
            }
            else
            {
                Thread th = new Thread(new ThreadStart(StartMainForm4));
                th.Start();
                this.Close();
                timer1.Stop();
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();//结束整个程序
        }
    }
}
