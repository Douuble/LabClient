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
    public partial class Form30 : Form
    {
        public SqlConnection sqlConn = null;
        public LabClass labObj;
        public int idx;
        public Form30()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCmd = new SqlCommand();
            String cmdStr = String.Format(
                "UPDATE lab SET " +
                "l_no={0}, " +
                "l_name=\'{1}\', " +
                "l_mgr_name=\'{2}\', " +
                "l_mgr_tel=\'{3}\', " +
                "l_is_open={4} " +
                "WHERE l_id={5}",
                labObj.No, labObj.Name, labObj.Mgr_name, labObj.Mgr_tel, labObj.Is_open, idx); ;
            sqlCmd.CommandText = cmdStr;
            sqlCmd.Connection = sqlConn;
            try
            {
                int res = sqlCmd.ExecuteNonQuery();
                if (res <= 0) throw new Exception("该条目已从数据库中丢失");
            }
            catch (Exception ex)
            {
                MessageBox.Show("修改失败！\r\n" + ex.Message,
                    "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("修改成功。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }

        private void Form30_Load(object sender, EventArgs e)
        {
            labObj = new LabClass();
            SqlCommand sqlCmd = new SqlCommand();
            String cmdStr = String.Format(
                "SELECT l_no,l_name,l_mgr_name,l_mgr_tel,l_is_open FROM lab " +
                "WHERE l_id = {0}", idx);
            sqlCmd.CommandText = cmdStr;
            sqlCmd.Connection = sqlConn;
            SqlDataReader sqlRead = sqlCmd.ExecuteReader();
            while (sqlRead.Read())
            {
                labObj.No = sqlRead.GetInt32(0);
                labObj.Name = sqlRead.GetString(1);
                labObj.Mgr_name = sqlRead.GetString(2);
                labObj.Mgr_tel = sqlRead.GetString(3);
                labObj.Is_open = sqlRead.GetInt32(4);
            }
            sqlRead.Close();
            propertyGrid1.SelectedObject = labObj;
        }
    }
}
