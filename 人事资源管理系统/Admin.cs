using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;

namespace 人事资源管理系统
{
    public partial class Admin : Form
    {
        string b;
        public Admin()
        {
            InitializeComponent();
            timer1.Start();
            Staff_Msg();
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            button1.Visible = true;
            button10.Visible = false;
            button7.Visible = true;
            button9.Visible = false;
        }
        public Admin(string a)
        {
            b = a;
            InitializeComponent();
            timer1.Start();
            Staff_Msg();
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            button1.Visible = true;
            button10.Visible = false;
            button7.Visible = true;
            button9.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToString();
        }
       private void Staff_Msg()
        {
            dataGridView1.Rows.Clear();
            string sql = "select * from dbo.selectByWord()";
            dao da = new dao();
            if (da.read(sql).Read() == false)
            {
                MessageBox.Show("查询失败，请重新查询", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                IDataReader dr = da.read(sql);
                string b, c, d,e,g,i,j,k,l;
                while (dr.Read())
                {             
                    b = dr["员工编号"].ToString();
                    c = dr["姓名"].ToString();
                    d = dr["性别"].ToString();
                    e = dr["出生日期"].ToString().Substring(0,10);
                    g = dr["最高学历"].ToString();
                    i = dr["婚姻状况"].ToString();
                    j = dr["职称"].ToString();
                    k = dr["现岗位"].ToString();
                    l = dr["入职时间"].ToString().Substring(0, 10);
                    string[] str = {b, c, d, e ,g,i,j,k,l};
                    dataGridView1.Rows.Add(str);
                }
                dr.Close();
            }
        }

        private void Staff_exp()
        {
            dataGridView2.Rows.Clear();
            string sql = "select * from dbo.selectExp()";
            dao da = new dao();
            if (da.read(sql).Read() == false)
            {
                MessageBox.Show("查询失败，请重新查询", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else{
                IDataReader dr = da.read(sql);
                string a, b, c, d, e, f, g, h, i;
                while (dr.Read())
                {
                    a = dr["转岗ID"].ToString();
                    b = dr["员工编号"].ToString();
                    c = dr["员工姓名"].ToString();
                    d = dr["原部门编号"].ToString();
                    e = dr["原职务"].ToString();
                    f = dr["新部门编号"].ToString();
                    g = dr["新职务"].ToString();
                    h = dr["转岗时间"].ToString().Substring(0, 10);
                    i = dr["经办管理员"].ToString();
                    string[] str = { a, b, c, d, e, f, g, h, i };
                    dataGridView2.Rows.Add(str);
                }
                dr.Close();
            }
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string sql = "select * from dbo.selectByWord() where (员工编号+姓名+最高学历+婚姻状况+职称+现岗位+入职时间) like '%"+textBox1.Text+"%'";
            dao da = new dao();
            if (da.read(sql).Read() == false)
            {
                MessageBox.Show("查询失败，请重新查询", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                IDataReader dr = da.read(sql);
                string b, c, d, a, g, i, j, k, l;
                while (dr.Read())
                {
                    b = dr["员工编号"].ToString();
                    c = dr["姓名"].ToString();
                    d = dr["性别"].ToString();
                    a = dr["出生日期"].ToString().Substring(0, 10);
                    g = dr["最高学历"].ToString();
                    i = dr["婚姻状况"].ToString();
                    j = dr["职称"].ToString();
                    k = dr["现岗位"].ToString();
                    l = dr["入职时间"].ToString().Substring(0, 10);
                    string[] str = { b, c, d, a, g, i, j, k, l };
                    dataGridView1.Rows.Add(str);
                }
                dr.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private static void StartMainLogin()
        {
            Login login = new Login();
            Application.Run(login);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(new ThreadStart(StartMainLogin));
            th.Start();
            this.Close();
        }

        private void Staff_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();//结束整个程序
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string[] str = { dataGridView1.SelectedCells[0].Value.ToString(),b};
            Staff_change staff_Change = new Staff_change(str);
            staff_Change.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Staff_Msg();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Staff_exp();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            button6.Visible = false;
            button5.Visible = true;
            button7.Visible = true;
            button9.Visible = false;
            button1.Visible = true;
            button10.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Staff_exp();
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
            button6.Visible = true;
            button5.Visible = false;
            button7.Visible = false;
            button9.Visible = true;
            button1.Visible = false;
            button10.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            string sql = "select * from dbo.selectExp() where (转岗ID+员工编号+员工姓名+原部门编号+原职务+新部门编号+新职务+转岗时间) like '%" + textBox1.Text + "%'";
            dao da = new dao();
            if (da.read(sql).Read() == false)
            {
                MessageBox.Show("查询失败，请重新查询", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                IDataReader dr = da.read(sql);
                string a, b, c, d, j, f, g, h;
                while (dr.Read())
                {
                    a = dr["转岗ID"].ToString();
                    b = dr["员工编号"].ToString();
                    c = dr["员工姓名"].ToString();
                    d = dr["原部门编号"].ToString();
                    j = dr["原职务"].ToString();
                    f = dr["新部门编号"].ToString();
                    g = dr["新职务"].ToString();
                    h = dr["转岗时间"].ToString().Substring(0, 10);
                    string[] str = { a, b, c, d, j, f, g, h };
                    dataGridView2.Rows.Add(str);
                }
                dr.Close();
            }
        }
    }
}
