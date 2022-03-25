using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;

namespace 人事资源管理系统
{
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
            timer1.Start();
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            button10.Visible = false;
            button6.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToString();
        }
       private void TableName()
        {
            dataGridView1.Rows.Clear();
            string sql = "select * from dbo.selectBysID('"+textBox1.Text+"')";
            dao da = new dao();
            if (da.read(sql).Read() == false)
            {
                MessageBox.Show("查询失败，请重新查询", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                IDataReader dr = da.read(sql);
                string a, b, c, d,e,g,i,j,k,l;
                while (dr.Read())
                {             
                    a = dr["身份证号"].ToString();
                    b = dr["员工编号"].ToString();
                    c = dr["姓名"].ToString();
                    d = dr["性别"].ToString();
                    e = dr["生日"].ToString().Substring(0,10);
                    g = dr["学历"].ToString();
                    i = dr["婚姻情况"].ToString();
                    j = dr["职务"].ToString();
                    k = dr["现部门"].ToString();
                    l = dr["入职时间"].ToString().Substring(0, 10);
                    string[] str = { a, b, c, d, e ,g,i,j,k,l};
                    dataGridView1.Rows.Add(str);
                }
                dr.Close();
            }
        }
        private void SelectRetire()
        {
            dataGridView2.Rows.Clear();
            string sql = "select * from dbo.selectRetire()";
            dao da = new dao();
            if (da.read(sql).Read() == false)
            {
                MessageBox.Show("无可退休人员", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                IDataReader dr = da.read(sql);
                string a, b, c, d, e, g, i, j;
                while (dr.Read())
                {
                    a = dr["员工编号"].ToString();
                    b = dr["姓名"].ToString();
                    c = dr["性别"].ToString();
                    d = dr["年龄"].ToString();
                    e = dr["学历"].ToString();
                    g = dr["职务"].ToString();
                    i = dr["现部门"].ToString();
                    j = dr["入职时间"].ToString().Substring(0, 10);
                    string[] str = { a, b, c, d, e, g, i, j };
                    dataGridView2.Rows.Add(str);
                }
                dr.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TableName();
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

        private void button5_Click(object sender, EventArgs e)
        {
            Staff_insert staff_Insert = new Staff_insert();
            staff_Insert.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("确定离职", "提示", MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK)
            {
                string sID;
                sID = dataGridView1.SelectedCells[0].Value.ToString();//获取用户选中的单元格集合
                string sql = "exec staff_del '"+sID+"' ";
                dao da = new dao();
                da.Execute(sql);
                dataGridView1.Rows.Clear();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string[] str = { dataGridView1.SelectedCells[2].Value.ToString(), dataGridView1.SelectedCells[3].Value.ToString(),
                dataGridView1.SelectedCells[6].Value.ToString(),dataGridView1.SelectedCells[5].Value.ToString(),dataGridView1.SelectedCells[0].Value.ToString()};
            Staff_update staff_Update = new Staff_update(str);
            staff_Update.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length != 0)
            {
                TableName();
            }
            button6.Visible = true;
            button10.Visible = false;
            dataGridView2.Visible = false;
            dataGridView1.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SelectRetire();
            dataGridView2.Visible = true;
            dataGridView1.Visible = false;
            button6.Visible = false;
            button10.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string str = dataGridView2.SelectedCells[0].Value.ToString();
            validation validation = new validation(str);
            validation.ShowDialog();
        }
    }
}
