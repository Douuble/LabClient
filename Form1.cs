using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LabClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            /*if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("请输入用户名!","提示",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("请输入密码!","提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }*/
            //String connStr = String.Format("Data Source = 10.0.2.5;Initial Catalog = LabDB;User Id = {0};Password = {1};", textBox1.Text, textBox2.Text);
            String connStr = String.Format("Data Source = 10.0.2.5;Initial Catalog = LabDB;User Id = sa;Password = GardeniaChan2K57;");
            SqlConnection sqlConn = new SqlConnection();
            sqlConn.ConnectionString = connStr;
            String exStr = "";
            try
            {
                sqlConn.Open();
            }
            catch (Exception ex)
            {
                exStr = ex.Message;
            }
            if (exStr == "" && sqlConn.State == System.Data.ConnectionState.Open)
            {
                this.Hide();
                MDIParent1 mdiWnd=new MDIParent1();
                mdiWnd.sqlConn = sqlConn;
                mdiWnd.Show();
                return;
            }
            else
            {
                MessageBox.Show("登录失败!\r\n" + exStr,"错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
