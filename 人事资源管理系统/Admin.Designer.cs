
namespace 人事资源管理系统
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ssex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sbir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.squal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.swed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.chID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch_sno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.change_sname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rawdeptID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rawstitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newdeptID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newstitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admin_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sno,
            this.sname,
            this.ssex,
            this.sbir,
            this.squal,
            this.swed,
            this.stitle,
            this.deptID,
            this.sinduction});
            this.dataGridView1.Location = new System.Drawing.Point(11, 43);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1048, 314);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.Visible = false;
            // 
            // sno
            // 
            this.sno.FillWeight = 103.2081F;
            this.sno.HeaderText = "员工编号";
            this.sno.MinimumWidth = 6;
            this.sno.Name = "sno";
            // 
            // sname
            // 
            this.sname.FillWeight = 72.00564F;
            this.sname.HeaderText = "姓名";
            this.sname.MinimumWidth = 6;
            this.sname.Name = "sname";
            // 
            // ssex
            // 
            this.ssex.FillWeight = 69.2845F;
            this.ssex.HeaderText = "性别";
            this.ssex.MinimumWidth = 6;
            this.ssex.Name = "ssex";
            // 
            // sbir
            // 
            this.sbir.FillWeight = 103.2081F;
            this.sbir.HeaderText = "出生年月";
            this.sbir.MinimumWidth = 6;
            this.sbir.Name = "sbir";
            // 
            // squal
            // 
            this.squal.FillWeight = 103.2081F;
            this.squal.HeaderText = "最高学历";
            this.squal.MinimumWidth = 6;
            this.squal.Name = "squal";
            // 
            // swed
            // 
            this.swed.FillWeight = 103.2081F;
            this.swed.HeaderText = "婚姻状况";
            this.swed.MinimumWidth = 6;
            this.swed.Name = "swed";
            // 
            // stitle
            // 
            this.stitle.FillWeight = 112.2422F;
            this.stitle.HeaderText = "职称";
            this.stitle.MinimumWidth = 6;
            this.stitle.Name = "stitle";
            // 
            // deptID
            // 
            this.deptID.FillWeight = 69.99911F;
            this.deptID.HeaderText = "现岗位";
            this.deptID.MinimumWidth = 6;
            this.deptID.Name = "deptID";
            // 
            // sinduction
            // 
            this.sinduction.FillWeight = 103.2081F;
            this.sinduction.HeaderText = "入职时间";
            this.sinduction.MinimumWidth = 6;
            this.sinduction.Name = "sinduction";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(601, 361);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "查询员工信息";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(316, 364);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 25);
            this.textBox1.TabIndex = 6;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 401);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1066, 26);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(159, 20);
            this.toolStripStatusLabel1.Text = "人事管理系统欢迎您！";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(836, 20);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(45, 20);
            this.toolStripStatusLabel3.Text = "Time";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(13, 20);
            this.toolStripStatusLabel4.Text = " ";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(798, 361);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 32);
            this.button2.TabIndex = 8;
            this.button2.Text = "清空";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.label1.Location = new System.Drawing.Point(26, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "请输关键字查询员工信息：";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(921, 361);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 32);
            this.button3.TabIndex = 10;
            this.button3.Text = "退出查询";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "溯源码";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 83;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "生产园区";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 83;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "茶叶品种";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 83;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "保质期";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 82;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "制茶厂";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 83;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "销售点";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 82;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "水分";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 84;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "总灰分";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Width = 83;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "农药含量";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 83;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "铅含量";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 84;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "水浸出物";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "粗纤维";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.Width = 125;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(921, 9);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 28);
            this.button4.TabIndex = 11;
            this.button4.Text = "返回主界面";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button7.Location = new System.Drawing.Point(158, 9);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 28);
            this.button7.TabIndex = 14;
            this.button7.Text = "刷新";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button8.Location = new System.Drawing.Point(31, 10);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 27);
            this.button8.TabIndex = 15;
            this.button8.Text = "转岗";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.Location = new System.Drawing.Point(316, 9);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(198, 28);
            this.button5.TabIndex = 16;
            this.button5.Text = "查看员工工作经历";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button6.Location = new System.Drawing.Point(338, 9);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(151, 28);
            this.button6.TabIndex = 17;
            this.button6.Text = "查看员工信息";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chID,
            this.ch_sno,
            this.change_sname,
            this.rawdeptID,
            this.rawstitle,
            this.newdeptID,
            this.newstitle,
            this.chtime,
            this.admin_user});
            this.dataGridView2.Location = new System.Drawing.Point(11, 43);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(1048, 314);
            this.dataGridView2.TabIndex = 18;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button9.Location = new System.Drawing.Point(158, 10);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 27);
            this.button9.TabIndex = 19;
            this.button9.Text = "刷新";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button10.Location = new System.Drawing.Point(559, 362);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(206, 31);
            this.button10.TabIndex = 20;
            this.button10.Text = "查询员工转岗信息";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // chID
            // 
            this.chID.HeaderText = "转岗ID";
            this.chID.MinimumWidth = 6;
            this.chID.Name = "chID";
            // 
            // ch_sno
            // 
            this.ch_sno.HeaderText = "员工编号";
            this.ch_sno.MinimumWidth = 6;
            this.ch_sno.Name = "ch_sno";
            // 
            // change_sname
            // 
            this.change_sname.HeaderText = "员工姓名";
            this.change_sname.MinimumWidth = 6;
            this.change_sname.Name = "change_sname";
            // 
            // rawdeptID
            // 
            this.rawdeptID.HeaderText = "原部门编号";
            this.rawdeptID.MinimumWidth = 6;
            this.rawdeptID.Name = "rawdeptID";
            // 
            // rawstitle
            // 
            this.rawstitle.HeaderText = "原职务";
            this.rawstitle.MinimumWidth = 6;
            this.rawstitle.Name = "rawstitle";
            // 
            // newdeptID
            // 
            this.newdeptID.HeaderText = "新部门编号";
            this.newdeptID.MinimumWidth = 6;
            this.newdeptID.Name = "newdeptID";
            // 
            // newstitle
            // 
            this.newstitle.HeaderText = "新职务";
            this.newstitle.MinimumWidth = 6;
            this.newstitle.Name = "newstitle";
            // 
            // chtime
            // 
            this.chtime.HeaderText = "转岗时间";
            this.chtime.MinimumWidth = 6;
            this.chtime.Name = "chtime";
            // 
            // admin_user
            // 
            this.admin_user.HeaderText = "经办人";
            this.admin_user.MinimumWidth = 6;
            this.admin_user.Name = "admin_user";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 427);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Admin";
            this.Text = "管理员操作界面";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Staff_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn sno;
        private System.Windows.Forms.DataGridViewTextBoxColumn sname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ssex;
        private System.Windows.Forms.DataGridViewTextBoxColumn sbir;
        private System.Windows.Forms.DataGridViewTextBoxColumn squal;
        private System.Windows.Forms.DataGridViewTextBoxColumn swed;
        private System.Windows.Forms.DataGridViewTextBoxColumn stitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptID;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinduction;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.DataGridViewTextBoxColumn chID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch_sno;
        private System.Windows.Forms.DataGridViewTextBoxColumn change_sname;
        private System.Windows.Forms.DataGridViewTextBoxColumn rawdeptID;
        private System.Windows.Forms.DataGridViewTextBoxColumn rawstitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn newdeptID;
        private System.Windows.Forms.DataGridViewTextBoxColumn newstitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn chtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn admin_user;
    }
}