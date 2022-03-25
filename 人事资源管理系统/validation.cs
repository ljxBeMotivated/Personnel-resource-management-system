using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;

namespace 人事资源管理系统
{
    public partial class validation : Form
    {
        string str;
        public validation()
        {
            InitializeComponent();
        }
        public validation(string a)
        {
            InitializeComponent();
            str = a;
        }
        public Boolean validationsID()
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("输入不完整请检查", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                string sql = "select * from dbo.validationBysID('" + textBox1.Text + "','"+str+"')";
                dao da = new dao();
                IDataReader dr = da.read(sql);
                if (dr.Read())
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("身份证号错误");
                    return false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validationsID())
            {
                DialogResult r = MessageBox.Show("确定退休", "提示", MessageBoxButtons.OKCancel);
                if (r == DialogResult.OK)
                {
                    string sql = "exec staff_del '" + textBox1.Text + "' ";
                    dao da = new dao();
                    da.Execute(sql);
                    MessageBox.Show("退休成功");
                    this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            this.Close();
        }
    }
}
