using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace LabClient
{
    public partial class Form2 : Form
    {

        public SqlConnection sqlConn = null;
        public ArrayList arr;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            arr = null;
            arr = new ArrayList();
            Form2_Resize(sender, e);
            treeView1.Indent = 16;
            treeView1.Nodes.Add("实验室");
            SqlCommand sqlCmd = new SqlCommand();
            String cmdStr = "SELECT l_id,l_no,l_name FROM lab";
            sqlCmd.CommandText = cmdStr;
            sqlCmd.Connection = sqlConn;
            SqlDataReader sqlRead = sqlCmd.ExecuteReader();
            while (sqlRead.Read())
            {
                String no = sqlRead["l_no"].ToString();
                String name = sqlRead["l_name"].ToString();
                treeView1.Nodes[0].Nodes.Add(string.Format("[{0}]{1}", no, name));
                arr.Add(sqlRead.GetInt32(0));
            }
            sqlRead.Close();
            treeView1.ExpandAll();
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            treeView1.Height = this.Height-SystemInformation.CaptionHeight; ;
            treeView1.Width = this.Width;
        }

        private void 添加实验室ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3=new Form3();
            form3.sqlConn = sqlConn;
            form3.ShowDialog();
            treeView1.Nodes.Clear();
            this.Form2_Load(sender, e);
        }

        private void 编辑实验室信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form30 form30 = new Form30();
            form30.sqlConn = sqlConn;
            form30.idx = (int)arr[treeView1.SelectedNode.Index];
            form30.ShowDialog();
            treeView1.Nodes.Clear();
            this.Form2_Load(sender, e);
        }

        private void TreeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            编辑实验室信息ToolStripMenuItem_Click(sender,e);
        }

        private void 查看实验室状态ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
