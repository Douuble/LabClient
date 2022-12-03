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
    public partial class Form3 : Form
    {
        public SqlConnection sqlConn = null;
        public LabClass labObj;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            labObj = new LabClass();
            propertyGrid1.SelectedObject = labObj;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCmd = new SqlCommand();
            String cmdStr = String.Format(
                "INSERT INTO lab (l_no,l_name,l_mgr_name,l_mgr_tel,l_is_open) " +
                "VALUES ({0},\'{1}\',\'{2}\',\'{3}\',{4})",
                labObj.No, labObj.Name, labObj.Mgr_name, labObj.Mgr_tel, labObj.Is_open);
            sqlCmd.CommandText = cmdStr;
            sqlCmd.Connection = sqlConn;
            try
            {
                int res = sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("添加失败！\r\n" + ex.Message,
                    "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("添加成功。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }
    }
    public class LabClass
    {
        private int no;
        private String name;
        private String mgr_name;
        private String mgr_tel;
        private int is_open;

        [Browsable(true), Category("实验室信息"), Description("房间号")]
        public int No { get => no; set => no = value; }
        [Browsable(true), Category("实验室信息"), Description("实验室名称")]
        public string Name { get => name; set => name = value; }
        [Browsable(true), Category("实验室信息"), Description("管理员姓名")]
        public string Mgr_name { get => mgr_name; set => mgr_name = value; }
        [Browsable(true), Category("实验室信息"), Description("管理员联系方式")]
        public string Mgr_tel { get => mgr_tel; set => mgr_tel = value; }
        [Browsable(true), Category("实验室信息"), Description("开放策略")]
        public int Is_open { get => is_open; set => is_open = value; }
    }
}
