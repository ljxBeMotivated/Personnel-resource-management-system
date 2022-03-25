using System.Windows.Forms;

namespace 人事资源管理系统
{
    public partial class Staff_update : Form
    {
        string[] str = new string[5];
        public Staff_update()
        {
            InitializeComponent();
        }
        public Staff_update(string[] a)
        {
            InitializeComponent();
            for (int i = 0; i <5; i++)
            {
                str[i] = a[i];
            }
            textBox1.Text = str[0];
            textBox2.Text = str[4];
            textBox3.Text = str[1];
            textBox4.Text = str[2];
            textBox5.Text = str[3];
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (textBox1.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("修改后有空项，请检查", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string sql = "exec staff_update '" + textBox2.Text + "','" + textBox1.Text + "','" + textBox3.Text + "','" + dateTimePicker1.Text + "','" + textBox5.Text + "','" + textBox4.Text + "'";
                dao da = new dao();
                da.Execute(sql);
            }
            MessageBox.Show("修改成功");
            this.Close();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
