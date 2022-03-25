using System.Windows.Forms;

namespace 人事资源管理系统
{
    public partial class Staff_change : Form
    {
        string str;
        public Staff_change()
        {
            InitializeComponent();
        }
        public Staff_change(string[] a)
        {
            InitializeComponent();
            textBox1.Text = a[0];
            str = a[1];
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (textBox2.Text == "" || comboBox1.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("修改后有空项，请检查", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string sql = "exec staff_change '" + textBox2.Text + "','" + textBox1.Text + "','" + comboBox1.Text + "','" + textBox4.Text + "','"+str+"' ";
                dao da = new dao();
                da.Execute(sql);
            }
            MessageBox.Show("转岗成功");
            this.Close();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
