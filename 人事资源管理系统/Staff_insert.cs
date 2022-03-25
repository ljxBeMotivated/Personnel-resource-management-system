using System;
using System.Windows.Forms;

namespace 人事资源管理系统
{
    public partial class Staff_insert : Form
    {
        public Staff_insert()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" | textBox4.Text == "" || 
                textBox5.Text == "" || textBox6.Text == "" || comboBox1.Text=="")
            {
                MessageBox.Show("输入有错误或不完整，请检查", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string sql = "exec staff_insert '"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+dateTimePicker1.Text+"'," +
                    "'"+textBox4.Text+"','"+textBox5.Text+"','"+textBox6.Text+"','"+comboBox1.Text+"'";
                dao da = new dao();
                int i=da.Execute(sql);
                if (i > 0)
                {
                    MessageBox.Show("添加成功");
                    textBox1.Text = null;
                    textBox2.Text = null;
                    textBox3.Text = null;
                    textBox4.Text = null;
                    textBox5.Text = null;
                    textBox6.Text = null;
                    comboBox1.Text = null;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
            comboBox1.Text = null;
            this.Close();
        }
    }
}
